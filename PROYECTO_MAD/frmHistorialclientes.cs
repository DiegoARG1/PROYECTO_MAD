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
    public partial class frmHistorialclientes : Form
    {
        // Variables
        private Cliente clienteSeleccionado = null;

        // Funciones
        private void CargarOpcionesBusqueda()
        {
            cboBuscarPor.Items.Clear();
            cboBuscarPor.Items.Add("Apellidos");
            cboBuscarPor.Items.Add("RFC");
            cboBuscarPor.Items.Add("Correo Electronico");
            cboBuscarPor.SelectedIndex = 0;
        }
        private void CargarAnios()
        {
            cboAnio.Items.Clear();
            cboAnio.Items.Add("[Toda la historia]");
            int anioActual = DateTime.Today.Year;
            for (int i = 0; i < 10; i++)
            {
                cboAnio.Items.Add(anioActual - i);
            }
            cboAnio.SelectedIndex = 0;
        }
        private void LimpiarFormulario()
        {
            if (cboBuscarPor.Items.Count > 0) cboBuscarPor.SelectedIndex = 0;
            txtValorBusqueda.Clear();
            if (cboAnio.Items.Count > 0) cboAnio.SelectedIndex = 0;
            dgvHistorial.DataSource = null;
            clienteSeleccionado = null;

            cboBuscarPor.Focus();
        }
        private void GenerarReporte()
        {
            if (clienteSeleccionado == null)
            {
                dgvHistorial.DataSource = null;
                return;
            }

            int? anioSeleccionado = null;
            if (cboAnio.SelectedIndex > 0 && cboAnio.SelectedItem is int)
            {
                anioSeleccionado = (int)cboAnio.SelectedItem;
            }

            try
            {
                List<HistorialCliente> historialData = ReservacionesDAO.ObtenerHistorialCliente(clienteSeleccionado.IdCliente, anioSeleccionado);

                dgvHistorial.AutoGenerateColumns = false;
                dgvHistorial.DataSource = historialData;


                dgvHistorial.Columns["NombreClienteHistorial"].DataPropertyName = "NombreCliente";
                dgvHistorial.Columns["CiudadHotelHistorial"].DataPropertyName = "Ciudad";
                dgvHistorial.Columns["NombreHotelHistorial"].DataPropertyName = "Hotel";
                dgvHistorial.Columns["NroPersonasHistorial"].DataPropertyName = "NumeroPersonasHospedadas";
                dgvHistorial.Columns["CodigoReservacionHistorial"].DataPropertyName = "CodigoReservacion";
                dgvHistorial.Columns["FechaReservacionHistorial"].DataPropertyName = "FechaReservacion";
                dgvHistorial.Columns["FechaCheckInHistorial"].DataPropertyName = "FechaCheckIn";
                dgvHistorial.Columns["FechaCheckOutHistorial"].DataPropertyName = "FechaCheckOut";
                dgvHistorial.Columns["EstatusReservacionHistorial"].DataPropertyName = "EstatusReservacion";
                dgvHistorial.Columns["AnticipoHistorial"].DataPropertyName = "Anticipo";
                dgvHistorial.Columns["MontoHospedajeHistorial"].DataPropertyName = "MontoHospedaje";
                dgvHistorial.Columns["TotalFacturaHistorial"].DataPropertyName = "TotalFactura";

                // Formatos
                dgvHistorial.Columns["AnticipoHistorial"].DefaultCellStyle.Format = "C2";
                dgvHistorial.Columns["MontoHospedajeHistorial"].DefaultCellStyle.Format = "C2";
                dgvHistorial.Columns["TotalFacturaHistorial"].DefaultCellStyle.Format = "C2";
                dgvHistorial.Columns["FechaReservacionHistorial"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvHistorial.Columns["FechaCheckInHistorial"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvHistorial.Columns["FechaCheckOutHistorial"].DefaultCellStyle.Format = "dd/MM/yyyy";

                if (historialData.Count == 0)
                {
                    MessageBox.Show("El cliente seleccionado no tiene historial para el año especificado.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el historial: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvHistorial.DataSource = null;
            }
        }

        // Elementos Form
        public frmHistorialclientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargarOpcionesBusqueda();
            CargarAnios();
            LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = cboBuscarPor.SelectedItem?.ToString();
            string valor = txtValorBusqueda.Text.Trim().Replace("\r", "").Replace("\n", "");

            if (string.IsNullOrEmpty(criterio) || string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("Seleccione criterio y valor para buscar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            try
            {
                List<Cliente> resultados = ClienteDAO.BuscarClientes(criterio, valor);
                dgvHistorial.DataSource = null;

                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron clientes.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clienteSeleccionado = null;
                }
                else if (resultados.Count == 1)
                {
                    clienteSeleccionado = resultados[0];
                    GenerarReporte();
                }
                else
                {
                    // Manejo de multiples resultados (simplificado: tomar el primero)
                    MessageBox.Show($"Se encontraron {resultados.Count} clientes. Mostrando historial del primero. Refine la búsqueda si es necesario.", "Múltiples Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clienteSeleccionado = resultados[0];
                    GenerarReporte();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clienteSeleccionado = null;
            }
        }

        private void cboAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarReporte();
        }
    }
}
