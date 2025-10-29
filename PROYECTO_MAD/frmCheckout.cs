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
        private void GenerarArchivoFactura(Factura factura, string numeroFactura)
        {
            if (reservacionActual == null) return;

            StringBuilder sb = new StringBuilder();
            int noches = Math.Max(1, (int)(reservacionActual.FechaSalida.Date - reservacionActual.FechaEntrada.Date).TotalDays);

            sb.AppendLine("================================================");
            sb.AppendLine("              FACTURA HOTEL                     ");
            sb.AppendLine("================================================");
            sb.AppendLine($"Factura Nro: {numeroFactura}");
            sb.AppendLine($"Fecha Emisión: {DateTime.Now:dd/MM/yyyy HH:mm}");
            sb.AppendLine($"Código Reserva: {reservacionActual.IdReservacion.ToString().ToUpper()}");
            sb.AppendLine();
            sb.AppendLine("--- Hotel ---");
            sb.AppendLine($"{reservacionActual.NombreHotel}");
            sb.AppendLine();
            sb.AppendLine("--- Cliente ---");
            sb.AppendLine($"{reservacionActual.NombreCliente}");
            sb.AppendLine($"RFC: {reservacionActual.RFCCliente}");
            sb.AppendLine();
            sb.AppendLine("--- Estancia ---");
            sb.AppendLine($"Entrada: {reservacionActual.FechaEntrada:dd/MM/yyyy}");
            sb.AppendLine($"Salida: {DateTime.Today:dd/MM/yyyy}");
            sb.AppendLine($"Noches: {noches}");
            sb.AppendLine();
            sb.AppendLine("--- Cargos ---");
            sb.AppendLine("Concepto".PadRight(40) + "| Monto");
            sb.AppendLine("----------------------------------------|-----------");

            var detallesAgrupados = reservacionActual.Detalles
                                        .GroupBy(d => new { d.NivelTipoHabitacion, d.PrecioNoche })
                                        .Select(g => new {
                                            Tipo = g.Key.NivelTipoHabitacion,
                                            Precio = g.Key.PrecioNoche,
                                            Cantidad = g.Count(),
                                            TotalPersonas = g.Sum(d => d.NroPersonas)
                                        });

            foreach (var grupo in detallesAgrupados)
            {
                decimal costoTipo = noches * grupo.TotalPersonas * grupo.Precio;
                string concepto = $"{grupo.Cantidad}x {grupo.Tipo} ({grupo.TotalPersonas} pers.)";
                sb.AppendLine(concepto.PadRight(40) + $"| {costoTipo:C2}");
            }
            sb.AppendLine("----------------------------------------|-----------");
            sb.AppendLine("Total Hospedaje:".PadRight(40) + $"| {factura.TotalHospedaje:C2}");
            sb.AppendLine("Anticipo Pagado:".PadRight(40) + $"| {factura.MontoAnticipo:C2}");
            sb.AppendLine("========================================|===========");
            sb.AppendLine("MONTO PAGADO HOY:".PadRight(40) + $"| {factura.MontoPendientePagado:C2}");
            sb.AppendLine("========================================|===========");
            sb.AppendLine();
            sb.AppendLine($"Forma de Pago: {factura.FormaPago}");
            sb.AppendLine();
            sb.AppendLine("¡Gracias por su preferencia!");


            // Guardar Archivo
            try
            {
                string carpetaFacturas = Path.Combine(Application.StartupPath, "Facturas");
                Directory.CreateDirectory(carpetaFacturas);

                string nombreArchivo = $"Factura_{numeroFactura}_{reservacionActual.NombreCliente.Replace(" ", "")}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                string rutaCompleta = Path.Combine(carpetaFacturas, nombreArchivo);

                File.WriteAllText(rutaCompleta, sb.ToString());

                MessageBox.Show($"Factura guardada en: {rutaCompleta}", "Archivo Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ioEx)
            {
                throw new Exception("No se pudo escribir el archivo de la factura. Verifique permisos o si el archivo está en uso.", ioEx);
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
                    decimal costoTipo = nochesEstancia * grupo.TotalPersonas * grupo.Precio;
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

                // Generar Archivo de Texto (despues del Commit)
                try
                {
                    GenerarArchivoFactura(factura, nuevaFacturaId.ToString());
                }
                catch (Exception fileEx)
                {
                    MessageBox.Show("La operación en la base de datos fue exitosa, pero ocurrió un error al generar el archivo de texto de la factura:\n" + fileEx.Message,
                                    "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                MessageBox.Show($"¡Check-Out realizado con éxito!\nFactura Nro: {nuevaFacturaId} generada.", "Check-Out Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
