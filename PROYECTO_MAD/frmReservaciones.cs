using PROYECTO_MAD.DAO;
using PROYECTO_MAD.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_MAD
{
    public partial class frmReservaciones : Form
    {
        // Variables
        private Cliente clienteSeleccionado = null;
        private Usuario usuarioLogueado;

        // Funciones
        private void LimpiarFormularioCompleto()
        {
            if (cbFiltro.Items.Count > 0)
            {
                cbFiltro.SelectedIndex = 0;
            }
            txtBusqueda.Clear();
            dgvCliente.DataSource = null;
            clienteSeleccionado = null;

            gbDefinirestancia.Enabled = false;
            btnBuscardisponibilidad.Enabled = false;

            if (cbPais.Items.Count > 0)
            {
                cbPais.SelectedIndex = 0;
            }
            else
            {
                cbEstado.Items.Clear();
                cbCiudad.Items.Clear();
                cbEstado.SelectedIndex = -1;
                cbCiudad.SelectedIndex = -1;
            }

            dtpEntrada.Value = DateTime.Today;
            dtpSalida.Value = DateTime.Today.AddDays(1);

            dgvHabitaciones.DataSource = null;

            gbResumen.Enabled = false;
            nudAnticipo.Value = 0;
            cbMetodopago.SelectedIndex = -1;
            lbMontototal.Text = "$0.00";
            btnConfirmarreservacion.Enabled = false;

        }
        private void CargarOpcionesBusqueda()
        {
            cbFiltro.Items.Clear();
            cbFiltro.Items.Add("apellidos");
            cbFiltro.Items.Add("rfc");
            cbFiltro.Items.Add("correo electronico");
            cbFiltro.SelectedIndex = 0;
        }
        private void CargarMetodosPago()
        {
            cbMetodopago.Items.Clear();

            cbMetodopago.Items.Add("Tarjeta de Crédito");
            cbMetodopago.Items.Add("Tarjeta de Débito");
            cbMetodopago.Items.Add("Transferencia");
            cbMetodopago.Items.Add("Efectivo");
            cbMetodopago.SelectedIndex = -1;
        }
        private void CargarPaises()
        {
            cbPais.Items.Clear();
            cbPais.Items.Add("Mexico");
            cbPais.SelectedIndex = 0;
        }
        private void RecalcularMontoTotal()
        {
            decimal montoTotal = 0m;
            foreach (DataGridViewRow row in dgvHabitaciones.Rows)
            {
                // Asegúrate que la celda Subtotal no sea null y sea decimal
                if (row.Cells["SubTotalReservacion"].Value != null && row.Cells["SubTotalReservacion"].Value is decimal)
                {
                    montoTotal += (decimal)row.Cells["SubTotalReservacion"].Value;
                }
            }
            lbMontototal.Text = montoTotal.ToString("C2"); // Muestra con formato de moneda

            // Habilita/Deshabilita el botón de confirmar basado en si hay algo seleccionado
            btnConfirmarreservacion.Enabled = (montoTotal > 0);
        }
        private int CalcularNoches()
        {
            // Asegura que las fechas sean solo Date, sin hora
            DateTime fechaEntrada = dtpEntrada.Value.Date;
            DateTime fechaSalida = dtpSalida.Value.Date;

            // Calcula la diferencia y obtiene los días totales
            TimeSpan diferencia = fechaSalida - fechaEntrada;
            int noches = (int)diferencia.TotalDays;

            // Asegura que al menos sea 1 noche si las fechas son válidas
            return Math.Max(1, noches);
        }

        // Elementos del Form
        public frmReservaciones(Usuario usuarioQueInicioSesion)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioQueInicioSesion;
        }
        private void frmReservaciones_Load(object sender, EventArgs e)
        {
            CargarOpcionesBusqueda();
            CargarPaises();
            CargarMetodosPago();
            LimpiarFormularioCompleto();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = cbFiltro.SelectedItem?.ToString();
            string valor = txtBusqueda.Text.Trim();

            if (string.IsNullOrEmpty(criterio) || string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("Por favor, seleccione un criterio y escriba un valor para buscar.", "Búsqueda Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<Cliente> resultados = ClienteDAO.BuscarClientes(criterio, valor);

                dgvCliente.AutoGenerateColumns = false;

                dgvCliente.Columns["NombreCliente"].DataPropertyName = "Nombre";
                dgvCliente.Columns["ApellidosCliente"].DataPropertyName = "Apellidos";
                dgvCliente.Columns["RfcCliente"].DataPropertyName = "Rfc";
                dgvCliente.Columns["CorreoCliente"].DataPropertyName = "CorreoElectronico";
                dgvCliente.Columns["TelefonoCliente"].DataPropertyName = "Telefono";

                dgvCliente.DataSource = resultados;

                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron clientes que coincidan con la búsqueda.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show(argEx.Message, "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvCliente.DataSource = null;
            }
        }

        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                // Guarda el cliente seleccionado
                clienteSeleccionado = (Cliente)dgvCliente.SelectedRows[0].DataBoundItem;

                gbDefinirestancia.Enabled = true;
                btnBuscardisponibilidad.Enabled = true;
            }
            else
            {
                clienteSeleccionado = null;
                gbDefinirestancia.Enabled = false;
                btnBuscardisponibilidad.Enabled = false;
            }
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEstado.Items.Clear();
            cbCiudad.Items.Clear();
            cbEstado.SelectedIndex = -1;
            cbCiudad.SelectedIndex = -1;

            if (cbPais.SelectedItem != null && cbPais.SelectedItem.ToString() == "Mexico")
            {
                cbEstado.Items.Add("Quintana Roo");
                cbEstado.Items.Add("Oaxaca");
                cbEstado.Items.Add("Yucatan");
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCiudad.Items.Clear();
            cbCiudad.SelectedIndex = -1;

            if (cbEstado.SelectedItem != null)
            {
                string estadoSeleccionado = cbEstado.SelectedItem.ToString();

                switch (estadoSeleccionado)
                {
                    case "Quintana Roo":
                        cbCiudad.Items.Add("Cancun");
                        cbCiudad.Items.Add("Playa del Carmen");
                        cbCiudad.Items.Add("Chetumal");
                        break;
                    case "Oaxaca":
                        cbCiudad.Items.Add("Oaxaca de Juarez");
                        cbCiudad.Items.Add("Puerto Escondido");
                        cbCiudad.Items.Add("Salina Cruz");
                        break;
                    case "Yucatan":
                        cbCiudad.Items.Add("Merida");
                        cbCiudad.Items.Add("Valladolid");
                        cbCiudad.Items.Add("Progreso");
                        break;
                }
            }
        }

        private void btnClientenuevo_Click(object sender, EventArgs e)
        {
            frmClientes formClientes = new frmClientes(this.usuarioLogueado);
            formClientes.ShowDialog();
        }

        private void btnLimpiarfiltro_Click(object sender, EventArgs e)
        {
            LimpiarFormularioCompleto();
        }

        private void btnBuscardisponibilidad_Click(object sender, EventArgs e)
        {
            // Leer Datos de Busqueda
            string ciudad = cbCiudad.SelectedItem?.ToString();
            DateTime fechaEntrada = dtpEntrada.Value.Date; // Tomar solo la fecha
            DateTime fechaSalida = dtpSalida.Value.Date;   // Tomar solo la fecha

            // Validaciones
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente primero.", "Cliente Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(ciudad))
            {
                MessageBox.Show("Por favor, seleccione Pais, Estado y Ciudad.", "Ubicación Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCiudad.Focus();
                return;
            }
            if (fechaSalida <= fechaEntrada)
            {
                MessageBox.Show("La fecha de salida debe ser posterior a la fecha de entrada.", "Fechas Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpSalida.Focus();
                return;
            }
            if (fechaEntrada < DateTime.Today)
            {
                MessageBox.Show("La fecha de entrada no puede ser anterior a hoy.", "Fechas Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEntrada.Focus();
                return;
            }

            // Buscar Disponibilidad
            try
            {
                List<TipoHabitacion> disponibles = TipoHabitacionDAO.BuscarDisponibilidad(ciudad, fechaEntrada, fechaSalida);

                // Configurar y Llenar DataGridView
                dgvHabitaciones.AutoGenerateColumns = false;
                //dgvHabitaciones.Columns.Clear();

                dgvHabitaciones.Columns["NombreHotelReservacion"].DataPropertyName = "NombreHotel";
                dgvHabitaciones.Columns["TipoHabitacionReservacion"].DataPropertyName = "Nivel";
                dgvHabitaciones.Columns["CapacidadReservacion"].DataPropertyName = "Capacidad";
                dgvHabitaciones.Columns["PrecioNocheReservacion"].DataPropertyName = "PrecioNoche";
                dgvHabitaciones.Columns["DisponibilidadReservacion"].DataPropertyName = "Disponibles";
                // Columnas editables (Cantidad, Personas) y calculada (Subtotal)
                // dgvHabitaciones.Columns["CantidadReservacion"].DataPropertyName = ""; // Vacío
                // dgvHabitaciones.Columns["NumeroPersonasReservacion"].DataPropertyName = ""; // Vacío
                // dgvHabitaciones.Columns["SubTotalReservacion"].DataPropertyName = ""; // Vacío

                // Formato de moneda para el precio
                dgvHabitaciones.Columns["PrecioNocheReservacion"].DefaultCellStyle.Format = "C2";
                dgvHabitaciones.Columns["SubTotalReservacion"].DefaultCellStyle.Format = "C2";

                // Enlaza los datos
                dgvHabitaciones.DataSource = disponibles;

                foreach (DataGridViewRow row in dgvHabitaciones.Rows)
                {
                    row.Cells["CantidadReservacion"].Value = 0;
                    row.Cells["NumeroPersonasReservacion"].Value = 0;
                    row.Cells["SubTotalReservacion"].Value = 0m;
                }


                // Habilita el resumen si hay resultados
                if (disponibles.Count > 0)
                {
                    gbResumen.Enabled = true; // Habilita la sección de resumen
                    MessageBox.Show($"Se encontraron {disponibles.Count} tipos de habitación disponibles.", "Disponibilidad Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    gbResumen.Enabled = false; // Deshabilita si no hay nada
                    btnConfirmarreservacion.Enabled = false; // Asegúrate que confirmar esté deshabilitado
                    MessageBox.Show("No se encontraron habitaciones disponibles para las fechas y ciudad seleccionadas.", "Sin Disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Resetea el monto total cada vez que buscas
                RecalcularMontoTotal();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar disponibilidad: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvHabitaciones.DataSource = null;
                gbResumen.Enabled = false;
                btnConfirmarreservacion.Enabled = false;
            }
        }

        private void dgvHabitaciones_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Salimos si el evento no fue en una fila valida o si no hay datos
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || dgvHabitaciones.Rows[e.RowIndex].DataBoundItem == null)
                return;

            // Obtenemos la fila actual y el objeto TipoHabitacion enlazado
            DataGridViewRow fila = dgvHabitaciones.Rows[e.RowIndex];
            TipoHabitacion tipoHab = (TipoHabitacion)fila.DataBoundItem;

            // Identificamos la columna que cambio
            string nombreColumna = dgvHabitaciones.Columns[e.ColumnIndex].Name;

            // Variables para leer los valores
            int cantidad = 0;
            int personas = 0;
            decimal precio = tipoHab.PrecioNoche; // Precio por noche por persona
            int capacidadPorHabitacion = tipoHab.Capacidad;
            int disponibles = tipoHab.Disponibles;
            int noches = CalcularNoches();

            bool recalcular = false; // Bandera para saber si recalculamos subtotal y total

            // si cambio la CANTIDAD
            if (nombreColumna == "CantidadReservacion")
            {
                // Intenta leer el nuevo valor de Cantidad
                if (fila.Cells["CantidadReservacion"].Value != null && int.TryParse(fila.Cells["CantidadReservacion"].Value.ToString(), out cantidad))
                {
                    // Validar vs Disponibles
                    if (cantidad < 0) // No permitir negativos
                    {
                        MessageBox.Show("La cantidad no puede ser negativa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        fila.Cells["CantidadReservacion"].Value = 0;
                        cantidad = 0; // Actualizar variable local
                    }
                    else if (cantidad > disponibles)
                    {
                        MessageBox.Show($"Solo hay {disponibles} habitaciones de este tipo disponibles.", "Cantidad Excedida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        fila.Cells["CantidadReservacion"].Value = disponibles;
                        cantidad = disponibles; // Actualizar variable local
                    }

                    // leemos el numero de personas para poder recalcular el subtotal
                    if (fila.Cells["NumeroPersonasReservacion"].Value != null)
                    {
                        int.TryParse(fila.Cells["NumeroPersonasReservacion"].Value.ToString(), out personas);
                    }
                    recalcular = true;
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido para la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fila.Cells["CantidadReservacion"].Value = 0; // Revertir a 0
                    cantidad = 0;
                    recalcular = true;
                }
            }
            // si cambio el NUMERO DE PERSONAS
            else if (nombreColumna == "NumeroPersonasReservacion")
            {
                // Intenta leer el nuevo valor de Personas
                if (fila.Cells["NumeroPersonasReservacion"].Value != null && int.TryParse(fila.Cells["NumeroPersonasReservacion"].Value.ToString(), out personas))
                {
                    // Necesitamos leer la cantidad actual para validar
                    if (fila.Cells["CantidadReservacion"].Value != null)
                    {
                        int.TryParse(fila.Cells["CantidadReservacion"].Value.ToString(), out cantidad);
                    }

                    // Validar vs Capacidad Total (Capacidad * Cantidad)
                    int capacidadTotal = capacidadPorHabitacion * cantidad;
                    if (personas < 0)
                    {
                        MessageBox.Show("El número de personas no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        fila.Cells["NumeroPersonasReservacion"].Value = 0;
                        personas = 0;
                    }
                    else if (cantidad > 0 && personas > capacidadTotal) // Solo valida si hay habitaciones seleccionadas
                    {
                        MessageBox.Show($"La capacidad máxima para {cantidad} habitación(es) de este tipo es {capacidadTotal} personas.", "Capacidad Excedida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        fila.Cells["NumeroPersonasReservacion"].Value = capacidadTotal;
                        personas = capacidadTotal;
                    }
                    recalcular = true; // Marcamos para recalcular
                }
                else // Si no es un numero valido
                {
                    MessageBox.Show("Ingrese un número válido para las personas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fila.Cells["NumeroPersonasReservacion"].Value = 0;
                    personas = 0;
                    recalcular = true;
                }
            }

            // Recalcular Subtotal y Total si hubo un cambio valido
            if (recalcular)
            {
                // Calcular Subtotal
                decimal subtotal = noches * personas * precio;
                fila.Cells["SubTotalReservacion"].Value = subtotal;
                RecalcularMontoTotal();
            }
        }
    }
}
