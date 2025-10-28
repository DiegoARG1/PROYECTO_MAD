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
    }
}
