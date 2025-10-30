using PROYECTO_MAD.DAO;
using PROYECTO_MAD.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestPDF.Fluent;

namespace PROYECTO_MAD
{
    public partial class frmCheckout : Form
    {
        // Variables
        private Usuario usuarioLogueado;
        private Reservacion reservacionActual = null;

        // Funciones
        private void LimpiarFormulario()
        {
            txtCodigoBusqueda.Clear();
            dgvDetalleFactura.DataSource = null;
            dgvDetalleFactura.Rows.Clear();
            // Limpia Labels de detalle
            lblCliente.Text = "####################";
            lblRFC.Text = "####################";
            lblHotel.Text = "####################";
            lblFechaCheckIn.Text = "####################";
            lblFechaCheckOut.Text = "####################";
            // Limpia Resumen
            lblTotalHospedaje.Text = "$0.00";
            lblAnticipoPagado.Text = "$0.00";
            lblMontoPendiente.Text = "$0.00";
            cbMetodoPago.SelectedIndex = -1;

            reservacionActual = null;
            btnConfirmarCheckOut.Enabled = false;
            txtCodigoBusqueda.Focus();
        }
        private void CargarMetodosPagoCombo()
        {
            cbMetodoPago.Items.Clear();
            cbMetodoPago.Items.Add("Tarjeta de Crédito");
            cbMetodoPago.Items.Add("Tarjeta de Débito");
            cbMetodoPago.Items.Add("Transferencia");
            cbMetodoPago.Items.Add("Efectivo");
            cbMetodoPago.SelectedIndex = -1;
        }
        private string GenerarArchivoFactura(Factura factura, string numeroFactura)
        {
            // Asegúrate de que la reservación actual (con todos los datos) esté disponible
            if (reservacionActual == null)
            {
                throw new InvalidOperationException("No hay datos de reservación para generar la factura.");
            }

            // 1. Define la ruta (usando Mis Documentos para evitar problemas de permisos)
            string carpetaFacturas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FacturasHotelDemo");
            Directory.CreateDirectory(carpetaFacturas); // Crea la carpeta si no existe

            // 2. Define el nombre del archivo
            string nombreArchivo = $"Factura_{numeroFactura}_{reservacionActual.NombreCliente.Replace(" ", "")}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string rutaCompleta = Path.Combine(carpetaFacturas, nombreArchivo);

            // 3. Crea la instancia del documento PDF (la clase que hicimos)
            var documento = new FacturaPDFDocument(factura, reservacionActual, numeroFactura);

            // 4. Genera el archivo PDF
            try
            {
                documento.GeneratePdf(rutaCompleta);
                return rutaCompleta; // Devuelve la ruta donde se guardó
            }
            catch (IOException ioEx)
            {
                throw new Exception($"No se pudo escribir el archivo PDF en '{rutaCompleta}'. Verifique permisos o si está en uso.", ioEx);
            }
        }

        // Elementos Form
        public frmCheckout(Usuario usuarioQueInicioSesion)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioQueInicioSesion;
            LimpiarFormulario();
            CargarMetodosPagoCombo();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string codigoTextoOriginal = txtCodigoBusqueda.Text;
            string codigoTextoLimpio = Regex.Replace(codigoTextoOriginal, @"[^a-fA-F0-9-]", "");

            lblCliente.Text = "####################";
            lblRFC.Text = "####################";
            lblHotel.Text = "####################";
            lblFechaCheckIn.Text = "####################";
            lblFechaCheckOut.Text = "####################";
            // Limpia Resumen
            lblTotalHospedaje.Text = "$0.00";
            lblAnticipoPagado.Text = "$0.00";
            lblMontoPendiente.Text = "$0.00";
            cbMetodoPago.SelectedIndex = -1;

            reservacionActual = null;
            btnConfirmarCheckOut.Enabled = false;

            if (string.IsNullOrEmpty(codigoTextoLimpio) || !Guid.TryParse(codigoTextoLimpio, out Guid codigoGuid))
            {
                MessageBox.Show($"El código '{codigoTextoOriginal}' no es un GUID válido.", "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Buscar Reservacion 'En-Curso' con sus detalles
                reservacionActual = ReservacionesDAO.ObtenerReservacionParaCheckout(codigoGuid);

                // Validar si se encontro y esta 'En-Curso'
                if (reservacionActual == null)
                {
                    MessageBox.Show("No se encontró una reservación 'En-Curso' con ese código.", "No Encontrado o Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Llenar Detalles y Calcular Factura
                lblCliente.Text = reservacionActual.NombreCliente;
                lblRFC.Text = reservacionActual.RFCCliente;
                lblHotel.Text = reservacionActual.NombreHotel;
                lblFechaCheckIn.Text = reservacionActual.FechaEntrada.ToString("dd/MM/yyyy");
                DateTime fechaSalidaReal = DateTime.Today;
                lblFechaCheckOut.Text = fechaSalidaReal.ToString("dd/MM/yyyy");

                dgvDetalleFactura.Rows.Clear();
                dgvDetalleFactura.Columns.Clear();

                // Define columnas de la factura
                dgvDetalleFactura.Columns.Add("colConcepto", "Concepto");
                dgvDetalleFactura.Columns.Add("colMonto", "Monto");
                dgvDetalleFactura.Columns["colMonto"].DefaultCellStyle.Format = "C2"; // Formato moneda
                dgvDetalleFactura.Columns["colConcepto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                decimal totalHospedajeCalculado = 0m;
                int nochesEstancia = Math.Max(1, (int)(fechaSalidaReal - reservacionActual.FechaEntrada.Date).TotalDays); // Calcula noches

                // Agrupa detalles por tipo para mostrar un resumen
                var detallesAgrupados = reservacionActual.Detalles
                                            .GroupBy(d => new { d.IdTipoHabitacion, d.NivelTipoHabitacion, d.PrecioNoche })
                                            .Select(g => new {
                                                Tipo = g.Key.NivelTipoHabitacion,
                                                Precio = g.Key.PrecioNoche,
                                                Cantidad = g.Count(), // Cuántas habitaciones de este tipo
                                                TotalPersonas = g.Sum(d => d.NroPersonas) // Suma de personas en este tipo
                                            });

                foreach (var grupo in detallesAgrupados)
                {
                    // Calcula costo: Noches * TotalPersonasEnTipo * PrecioNochePersona
                    decimal costoTipo = nochesEstancia * grupo.Cantidad * grupo.Precio;
                    string concepto = $"Hospedaje: {grupo.Cantidad} x {grupo.Tipo} ({nochesEstancia} Noches, {grupo.TotalPersonas} Personas)";
                    dgvDetalleFactura.Rows.Add(concepto, costoTipo);
                    totalHospedajeCalculado += costoTipo;
                }

                // Llenar Resumen Financiero
                lblTotalHospedaje.Text = totalHospedajeCalculado.ToString("C2");
                lblAnticipoPagado.Text = reservacionActual.Anticipo.ToString("C2");
                decimal montoPendiente = totalHospedajeCalculado - reservacionActual.Anticipo;
                // Asegurarse que no sea negativo si el anticipo fue mayor
                montoPendiente = Math.Max(0, montoPendiente);
                lblMontoPendiente.Text = montoPendiente.ToString("C2");

                // Habilitar Confirmación
                cbMetodoPago.Enabled = true;
                btnConfirmarCheckOut.Enabled = true;
                gbResumen.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar o calcular la reservación para Check-Out: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarFormulario();
            }
        }

        private void btnConfirmarCheckOut_Click(object sender, EventArgs e)
        {
            if (reservacionActual == null || reservacionActual.Estado != "En-Curso")
            {
                MessageBox.Show("Debe buscar y cargar una reservacion valida en estado 'En-Curso' primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbMetodoPago.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Metodo de Pago para el monto pendiente.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMetodoPago.Focus();
                return;
            }

            // Recolectar Datos para la Factura y Actualizaciones
            string formaPagoSeleccionada = cbMetodoPago.SelectedItem.ToString();
            decimal totalHospedaje = 0m;
            Decimal.TryParse(lblTotalHospedaje.Text.Replace("$", "").Replace(",", ""), out totalHospedaje);
            decimal montoPendiente = 0m;
            Decimal.TryParse(lblMontoPendiente.Text.Replace("$", "").Replace(",", ""), out montoPendiente);

            // Lista de IDs de habitaciones fisicas a liberar
            List<int> idsHabitacionesALiberar = reservacionActual.Detalles
                                                .Where(d => d.IdHabitacion.HasValue) // Solo las que se asignaron
                                                .Select(d => d.IdHabitacion.Value)
                                                .ToList();

            // Crear objeto Factura
            Factura factura = new Factura();
            factura.IdReservacion = reservacionActual.IdReservacion;
            factura.IdHotel = reservacionActual.IdHotel;
            factura.IdCliente = reservacionActual.IdCliente;
            factura.IdUsuario = this.usuarioLogueado.IdUsuario; // Usuario que hace el checkout
            factura.FechaEmision = DateTime.Now;
            factura.TotalHospedaje = totalHospedaje;
            factura.MontoAnticipo = reservacionActual.Anticipo;
            factura.MontoPendientePagado = montoPendiente;
            factura.FormaPago = formaPagoSeleccionada;
            factura.Estatus = "Pagada"; // Estado inicial

            // Confirmacion Final
            DialogResult confirmacion = MessageBox.Show($"Se procederá a finalizar la estancia.\nTotal Hospedaje: {totalHospedaje:C2}\nAnticipo: {reservacionActual.Anticipo:C2}\nPendiente a Cobrar: {montoPendiente:C2}\n\n¿Confirmar Check-Out?",
                                                     "Confirmar Check-Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
            {
                return;
            }

            // Ejecutar Operaciones con Transaccion
            SqlConnection conexion = null;
            SqlTransaction transaction = null;
            int nuevaFacturaId = 0; // Para guardar el ID de la factura generada

            try
            {
                conexion = BDConexion.ObtenerConexion();
                if (conexion == null) throw new Exception("No se pudo conectar a la BD.");
                transaction = conexion.BeginTransaction(IsolationLevel.ReadCommitted);

                // PASO A: Insertar Factura
                nuevaFacturaId = FacturaDAO.InsertarFactura(factura, conexion, transaction);
                if (nuevaFacturaId <= 0) throw new Exception("No se pudo guardar la factura.");

                // PASO B: Liberar Habitaciones
                int habsLiberadas = HabitacionDAO.MarcarHabitacionesDisponibles(idsHabitacionesALiberar, conexion, transaction);
                // Podrías añadir una verificación si habsLiberadas != idsHabitacionesALiberar.Count

                // PASO C: Actualizar Estado Reserva
                int resActualizada = ReservacionesDAO.ActualizarEstadoReserva(reservacionActual.IdReservacion, "Completada", conexion, transaction);
                if (resActualizada <= 0) throw new Exception("No se pudo actualizar el estado de la reservación.");

                // Si todo ok, COMMIT
                transaction.Commit();

                string mensajeExitoDB = $"¡Check-Out realizado con éxito!\nFactura Nro: {nuevaFacturaId} registrada en la base de datos.";
                string rutaArchivoGenerado = "";

                // Generar Archivo de Texto (despues del Commit)
                try
                {
                    // Llama al NUEVO método de PDF
                    rutaArchivoGenerado = GenerarArchivoFactura(factura, nuevaFacturaId.ToString());

                    MessageBox.Show(mensajeExitoDB + $"\n\nFactura PDF generada en:\n{rutaArchivoGenerado}",
                                    "Check-Out Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Opcional: Abrir la carpeta
                    System.Diagnostics.Process.Start("explorer.exe", Path.GetDirectoryName(rutaArchivoGenerado));
                }
                catch (Exception fileEx) // Captura error específico del PDF
                {
                    MessageBox.Show(mensajeExitoDB +
                                    "\n\nADVERTENCIA:\nOcurrió un error al generar el archivo PDF de la factura:\n" + fileEx.Message,
                                    "Error al Generar PDF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                LimpiarFormulario();

            }
            catch (Exception ex)
            {
                try { transaction?.Rollback(); } catch { /* Ignora error de rollback */ }
                MessageBox.Show("Error durante el proceso de Check-Out: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion?.Close();
            }
        }
    }
}
