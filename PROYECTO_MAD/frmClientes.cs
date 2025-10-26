using PROYECTO_MAD.DAO;
using PROYECTO_MAD.Entidad;
using PROYECTO_MAD.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PROYECTO_MAD
{
    public partial class frmClientes : Form
    {
        // Variables
        private int? idClienteSeleccionado = null;
        private int? idDomicilioSeleccionado = null;
        private Usuario usuarioLogueado;

        // Funciones
        private void CargarEstadosCiviles()
        {
            cbEstadocivil.Items.Clear();
            cbEstadocivil.Items.Add("Soltero(a)");
            cbEstadocivil.Items.Add("Casado(a)");
            cbEstadocivil.Items.Add("Divorciado(a)");
            cbEstadocivil.Items.Add("Viudo(a)");
            cbEstadocivil.Items.Add("Concubinato");
            cbEstadocivil.SelectedIndex = -1;
        }
        private void CargarPaises()
        {
            cbPais.Items.Clear();
            cbPais.Items.Add("Mexico");
            cbPais.SelectedIndex = 0;
        }
        private void CargarClientes()
        {
            try
            {
                List<Cliente> listaClientes = ClienteDAO.ObtenerClientes();

                dgvClientes.AutoGenerateColumns = false;
                dgvClientes.DataSource = listaClientes;

                dgvClientes.Columns["NombreCliente"].DataPropertyName = "Nombre";
                dgvClientes.Columns["ApellidosCliente"].DataPropertyName = "Apellidos";
                dgvClientes.Columns["Rfc"].DataPropertyName = "RFC";
                dgvClientes.Columns["TelefonoCliente"].DataPropertyName = "Telefono";
                dgvClientes.Columns["FechaRegistroCliente"].DataPropertyName = "FechaRegistro";
                dgvClientes.Columns["UsuarioCreadorCliente"].DataPropertyName = "UsuarioCreador";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvClientes.DataSource = null;
            }
        }
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtRfc.Clear();
            txtTel.Clear();
            txtCalle.Clear();
            txtNumero.Clear();
            txtCp.Clear();

            cbEstadocivil.SelectedIndex = -1;
                                               
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

            dtpFechanacimiento.Value = DateTime.Today;

            idClienteSeleccionado = null;
            idDomicilioSeleccionado = null;
            if (dgvClientes.SelectedRows.Count > 0)
            {
                dgvClientes.ClearSelection();
            }

            txtCorreo.Enabled = true;
            txtRfc.Enabled = true;
            txtNombre.Focus();
        }


        // Elementos del Form
        public frmClientes(Usuario usuarioQueInicioSesion)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioQueInicioSesion;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargarEstadosCiviles();
            CargarPaises();
            CargarClientes();
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEstado.Items.Clear();
            cbCiudad.Items.Clear();

            if (cbPais.SelectedItem != null && cbPais.SelectedItem.ToString() == "Mexico")
            {
                cbEstado.Items.Add("Nuevo Leon");
                cbEstado.SelectedIndex = 0;
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCiudad.Items.Clear();

            if (cbEstado.SelectedItem != null && cbEstado.SelectedItem.ToString() == "Nuevo Leon")
            {
                cbCiudad.Items.Add("Monterrey");
                cbCiudad.Items.Add("San Nicolas");
                cbCiudad.Items.Add("Santa Catarina");
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                Cliente clienteSeleccionado = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;

                txtNombre.Text = clienteSeleccionado.Nombre;
                txtApellidos.Text = clienteSeleccionado.Apellidos;
                txtCorreo.Text = clienteSeleccionado.CorreoElectronico;
                txtRfc.Text = clienteSeleccionado.RFC;
                cbEstadocivil.SelectedItem = clienteSeleccionado.EstadoCivil;

                // Valida el rango de fechas antes de asignar
                if (clienteSeleccionado.FechaNacimiento >= dtpFechanacimiento.MinDate &&
                    clienteSeleccionado.FechaNacimiento <= dtpFechanacimiento.MaxDate)
                {
                    dtpFechanacimiento.Value = clienteSeleccionado.FechaNacimiento;
                }
                else
                {
                    dtpFechanacimiento.Value = DateTime.Today;
                }
                txtTel.Text = clienteSeleccionado.Telefono;

                //Llenar los campos del Domicilio
                if (clienteSeleccionado.oDomicilio != null)
                {
                    cbPais.SelectedItem = clienteSeleccionado.oDomicilio.Pais;
                    cbEstado.SelectedItem = clienteSeleccionado.oDomicilio.Estado;
                    cbCiudad.SelectedItem = clienteSeleccionado.oDomicilio.Ciudad;
                    txtCalle.Text = clienteSeleccionado.oDomicilio.Calle;
                    txtNumero.Text = clienteSeleccionado.oDomicilio.Numero;
                    txtCp.Text = clienteSeleccionado.oDomicilio.CodigoPostal;

                    // Guarda el ID del domicilio para la edición
                    idDomicilioSeleccionado = clienteSeleccionado.oDomicilio.IdDomicilio;
                }
                else
                {
                    if (cbPais.Items.Count > 0) cbPais.SelectedIndex = 0;
                    txtCalle.Clear();
                    txtNumero.Clear();
                    txtCp.Clear();
                    idDomicilioSeleccionado = null;
                }
                txtCorreo.Enabled = false;
                txtRfc.Enabled = false;

                idClienteSeleccionado = clienteSeleccionado.IdCliente;
            }
        }

        private void btnlimpiartxt_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado != null)
            {
                MessageBox.Show("Ya hay un cliente seleccionado. Use 'Editar' para guardar cambios o 'Limpiar' para agregar uno nuevo.", "Acción Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text.Trim();
            cliente.Apellidos = txtApellidos.Text.Trim();
            cliente.CorreoElectronico = txtCorreo.Text.Trim();
            cliente.RFC = txtRfc.Text.Trim();
            cliente.EstadoCivil = cbEstadocivil.SelectedItem?.ToString();
            cliente.FechaNacimiento = dtpFechanacimiento.Value;
            cliente.Telefono = txtTel.Text.Trim();

            Domicilio domicilio = new Domicilio();
            string pais = cbPais.SelectedItem?.ToString();
            string estado = cbEstado.SelectedItem?.ToString();
            string ciudad = cbCiudad.SelectedItem?.ToString();
            string calle = txtCalle.Text.Trim();
            string numero = txtNumero.Text.Trim();
            string cp = txtCp.Text.Trim();
            domicilio.IdDomicilio = 0;

            // Validaciones
            if (string.IsNullOrEmpty(cliente.Nombre) || string.IsNullOrEmpty(cliente.Apellidos) ||
                string.IsNullOrEmpty(cliente.RFC) || string.IsNullOrEmpty(cliente.CorreoElectronico) || string.IsNullOrEmpty(cliente.Telefono))
            {
                MessageBox.Show("Por favor, Ingrese todos los datos.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cliente.EstadoCivil))
            {
                MessageBox.Show("Por favor, seleccione un Estado Civil.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbEstadocivil.Focus();
                return;
            }

            // Validación de Correo
            string patternCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(cliente.CorreoElectronico, patternCorreo))
            {
                MessageBox.Show("El formato del correo electrónico no es válido (ej. usuario@dominio.com).", "Correo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            // Validación de Telefono
            string patternTelefono = @"^\d{10}$";
            if (!Regex.IsMatch(cliente.Telefono, patternTelefono))
            {
                MessageBox.Show("El número de teléfono debe contener exactamente 10 dígitos numéricos.", "Teléfono Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTel.Focus();
                return;
            }

            if (cliente.RFC.Length != 13)
            {
                MessageBox.Show("Ingrese un RFC válido (debe tener exactamente 13 caracteres).", "RFC Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRfc.Focus();
                return;
            }

            if (!ValidacionesHelper.ValidarDomicilio(pais, estado, ciudad, calle, numero, cp))
            {
                return;
            }
                
            domicilio.Pais = pais;
            domicilio.Estado = estado;
            domicilio.Ciudad = ciudad;
            domicilio.Calle = calle;
            domicilio.Numero = numero;
            domicilio.CodigoPostal = cp;

            try
            {
                // Validar Duplicados (RFC o Correo)
                if (ClienteDAO.ExisteCliente(cliente.RFC, cliente.CorreoElectronico))
                {
                    MessageBox.Show("Ya existe un cliente con ese RFC o Correo Electrónico.", "Cliente Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idDomicilioGuardado = DomicilioDAO.GuardarDomicilio(domicilio);

                int idUsuarioLogueado = this.usuarioLogueado.IdUsuario;
                int filasInsertadas = ClienteDAO.InsertarCliente(cliente, idDomicilioGuardado, idUsuarioLogueado);

                if (filasInsertadas > 0)
                {
                    MessageBox.Show("Cliente agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message + (ex.InnerException != null ? "\nDetalle: " + ex.InnerException.Message : ""), "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente de la lista para editar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cliente cliente = new Cliente();
            cliente.IdCliente = idClienteSeleccionado.Value;
            cliente.Nombre = txtNombre.Text.Trim();
            cliente.Apellidos = txtApellidos.Text.Trim();
            cliente.CorreoElectronico = txtCorreo.Text.Trim();
            cliente.RFC = txtRfc.Text.Trim();
            cliente.EstadoCivil = cbEstadocivil.SelectedItem?.ToString();
            cliente.FechaNacimiento = dtpFechanacimiento.Value;
            cliente.Telefono = txtTel.Text.Trim();

            Domicilio domicilio = new Domicilio();
            domicilio.IdDomicilio = idDomicilioSeleccionado ?? 0;
            string pais = cbPais.SelectedItem?.ToString();
            string estado = cbEstado.SelectedItem?.ToString();
            string ciudad = cbCiudad.SelectedItem?.ToString();
            string calle = txtCalle.Text.Trim();
            string numero = txtNumero.Text.Trim();
            string cp = txtCp.Text.Trim();

            // Validaciones
            if (string.IsNullOrEmpty(cliente.Nombre) || string.IsNullOrEmpty(cliente.Apellidos) ||
                string.IsNullOrEmpty(cliente.RFC) || string.IsNullOrEmpty(cliente.CorreoElectronico) || string.IsNullOrEmpty(cliente.Telefono))
            {
                MessageBox.Show("Nombre, Apellidos, RFC, Correo Electrónico y Teléfono son obligatorios.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Estado Civil
            if (string.IsNullOrEmpty(cliente.EstadoCivil)) { /*...*/ cbEstadocivil.Focus(); return; }

            // Validacion RFC (13 caracteres)
            cliente.RFC = cliente.RFC.Trim();
            if (cliente.RFC.Length != 13) { /*...*/ txtRfc.Focus(); return; }

            // Validacion Correo
            if (!Regex.IsMatch(cliente.CorreoElectronico, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) { /*...*/ txtCorreo.Focus(); return; }

            // Validacion Telefono (10 dígitos)
            if (!Regex.IsMatch(cliente.Telefono, @"^\d{10}$")) { /*...*/ txtTel.Focus(); return; }

            // Validacion Domicilio (Obligatorio)
            if (!ValidacionesHelper.ValidarDomicilio(pais, estado, ciudad, calle, numero, cp))
            {
                return;
            }

            domicilio.Pais = pais;
            domicilio.Estado = estado;
            domicilio.Ciudad = ciudad;
            domicilio.Calle = calle;
            domicilio.Numero = numero;
            domicilio.CodigoPostal = cp;

            try
            {

                int idDomicilioGuardado = DomicilioDAO.GuardarDomicilio(domicilio);

                int filasActualizadas = ClienteDAO.ActualizarCliente(cliente, idDomicilioGuardado);

                if (filasActualizadas > 0)
                {
                    MessageBox.Show("Cliente actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el cliente. Es posible que no se encontrara.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message + (ex.InnerException != null ? "\nDetalle: " + ex.InnerException.Message : ""), "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
