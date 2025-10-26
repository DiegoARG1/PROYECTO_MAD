using PROYECTO_MAD.DAO;
using PROYECTO_MAD.Entidad;
using PROYECTO_MAD.Negocio;
using PROYECTO_MAD.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_MAD
{
    public partial class frmEmpleados : Form
    {
        // Variables
        private int? idEmpleadoSeleccionado = null;
        private int? idDomicilioSeleccionado = null;
        private Usuario usuarioLogueado;
        
        // Funciones
        private void CargarPaises()
        {
            cbPais.Items.Clear();
            cbPais.Items.Add("Mexico");
            cbPais.SelectedIndex = 0;
        }
        private void CargarRoles()
        {
            try
            {
                List<Rol> roles = RolDAO.ObtenerRoles();

                // Asigna la lista como fuente de datos
                cbRol.DataSource = roles;

                // Displaymeber es lo que se va a mostrar en el combobox
                cbRol.DisplayMember = "Descripcion";

                // Y este es el valor que te va a devolver el cb cuando quieras acceder al valor seleccionado
                cbRol.ValueMember = "IdRol";

                cbRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtContra.Clear();
            txtConfirmarcontra.Clear();
            txtNomina.Clear();
            txtTel.Clear();
            txtCalle.Clear();
            txtNumero.Clear();
            txtCp.Clear();

            dtpNacimiento.Value = DateTime.Today;

            cbRol.SelectedIndex = -1;
            cbPais.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            cbCiudad.SelectedIndex = -1;

            idEmpleadoSeleccionado = null;

            txtContra.Enabled = true;
            txtConfirmarcontra.Enabled = true;
            txtNomina.Enabled = true;

            txtNombre.Focus();
        }
        private void CargarEmpleados()
        {
            try
            {
                UsuarioN negocio = new UsuarioN();

                List<Usuario> listaEmpleados = negocio.ObtenerUsuarios();

                dgvEmpleados.AutoGenerateColumns = false;

                dgvEmpleados.DataSource = listaEmpleados;

                //Ajuste de columnas manual
                dgvEmpleados.Columns["NombreUsuario"].DataPropertyName = "Nombre";
                dgvEmpleados.Columns["ApellidosUsuario"].DataPropertyName = "Apellidos";
                dgvEmpleados.Columns["NroNominaUsuario"].DataPropertyName = "NumeroNomina";
                dgvEmpleados.Columns["TelefonoUsuario"].DataPropertyName = "Telefono";
                dgvEmpleados.Columns["RolUsuario"].DataPropertyName = "oRol";
                dgvEmpleados.Columns["EstadoUsuario"].DataPropertyName = "Estado";
                dgvEmpleados.Columns["FechaRegistroUsuario"].DataPropertyName = "FechaRegistro";
                dgvEmpleados.Columns["UsuarioCreadorUsuario"].DataPropertyName = "UsuarioCreador";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Eventos Form
        public frmEmpleados(Usuario usuarioQueInicioSesion)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioQueInicioSesion;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarPaises();
            CargarRoles();
            CargarEmpleados();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (idEmpleadoSeleccionado != null)
            {
                MessageBox.Show("Ya hay un usuario seleccionado. Use el boton 'Editar' para guardar los cambios o 'Limpiar' para agregar uno nuevo.","Accion invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                Usuario empleado = new Usuario();

                empleado.Nombre = txtNombre.Text.Trim();
                empleado.Apellidos = txtApellidos.Text.Trim();
                empleado.Correo = txtCorreo.Text.Trim();
                empleado.Contrasenia = txtContra.Text;
                string confirmarContrasenia = txtConfirmarcontra.Text;
                empleado.NumeroNomina = txtNomina.Text.Trim();
                empleado.FechaNacimiento = dtpNacimiento.Value;
                empleado.Telefono = txtTel.Text.Trim();

                //Validacion de que un rol esta seleccionado
                if (cbRol.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione un Rol.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbRol.Focus();
                    return;
                }
                empleado.oRol = new Rol() { IdRol = Convert.ToInt32(cbRol.SelectedValue) };
                empleado.Estado = true;

                string paisSeleccionado = cbPais.SelectedItem?.ToString();
                string estadoSeleccionado = cbEstado.SelectedItem?.ToString();
                string ciudadSeleccionada = cbCiudad.SelectedItem?.ToString();
                string calle = txtCalle.Text.Trim();
                string numero = txtNumero.Text.Trim();
                string codigoPostal = txtCp.Text.Trim();

                if (!ValidacionesHelper.ValidarDomicilio(paisSeleccionado,estadoSeleccionado,ciudadSeleccionada,calle,numero,codigoPostal))
                {
                    return;   
                }

                Domicilio domicilio = new Domicilio();

                domicilio.Pais = paisSeleccionado;
                domicilio.Estado = estadoSeleccionado;
                domicilio.Ciudad = ciudadSeleccionada;
                domicilio.Calle = calle;
                domicilio.Numero = numero;
                domicilio.CodigoPostal = codigoPostal;

                // ID es 0 porque es nuevo y se necesita para usar guardar domicilio en el DAO
                domicilio.IdDomicilio = 0;

                // --- 3. Validarcampos ---
                if (string.IsNullOrEmpty(empleado.Nombre) || string.IsNullOrEmpty(empleado.Apellidos) ||
                    string.IsNullOrEmpty(empleado.Correo) || string.IsNullOrEmpty(empleado.NumeroNomina) ||
                    string.IsNullOrEmpty(empleado.Telefono) || string.IsNullOrEmpty(empleado.Contrasenia))
                {
                    MessageBox.Show("Por favor rellene todos los campos.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            // Validar Numero Telefonico
            if (empleado.Telefono.Length != 10 || !empleado.Telefono.All(char.IsDigit))
            {
                MessageBox.Show("Ingrese un numero telefonico valido.", "Edad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTel.Focus();
                return;
            }

            // Validar edad correcta
            DateTime hoy = DateTime.Today;
            if (empleado.FechaNacimiento.Date.AddYears(18) > hoy)
            {
                MessageBox.Show("El empleado debe ser mayor de 18 años.", "Edad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNacimiento.Focus();
                return;
            }

            // Validar correo
            if (!empleado.Correo.Contains("@") || !empleado.Correo.Contains("."))
            {
                MessageBox.Show("Ingrese un correo electronico valido.", "Edad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            // Validación de Contraseña
            if (idEmpleadoSeleccionado == null || !string.IsNullOrEmpty(empleado.Contrasenia)) // Solo valida si es nuevo o si se escribió algo
                {
                    if (empleado.Contrasenia != confirmarContrasenia)
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtContra.Focus();
                        return;
                    }
                    if (!ValidacionesHelper.ValidarContrasena(empleado.Contrasenia, txtContra))
                    {
                        return;
                    }
                }
                // --- 4. Intentar Guardar ---
                try
                {
                    UsuarioN negocio = new UsuarioN();

                    // 4.1 Validar si ya existe (Correo o Nómina)
                    if (negocio.ExisteUsuario(empleado.Correo, empleado.NumeroNomina))
                    {
                        MessageBox.Show("Ya existe un empleado con ese Correo o Número de Nómina.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 4.2 Guardar el Domicilio
                    int? idDomicilioGuardado = null;
                    if (domicilio.IdDomicilio == 0)
                    { 
                        idDomicilioGuardado = DomicilioDAO.GuardarDomicilio(domicilio);
                    }

                    // 4.3 Guardar el Usuario (pasando el ID del domicilio y el ID del creador)
                    int idUsuarioLogueado = this.usuarioLogueado.IdUsuario;

                    if (idEmpleadoSeleccionado == null)
                    {
                        negocio.InsertarUsuario(empleado, idDomicilioGuardado, idUsuarioLogueado);
                        MessageBox.Show("Empleado agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // 4.5 Refrescar y Limpiar
                    CargarEmpleados();
                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el empleado: " + ex.Message + (ex.InnerException != null ? "\nDetalle: " + ex.InnerException.Message : ""), "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void dgvEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvEmpleados.Columns[e.ColumnIndex].Name == "EstadoUsuario")
            {
                if (e.Value != null)
                {
                    try
                    {
                        bool estado = Convert.ToBoolean(e.Value);

                        if (estado == true)
                        {
                            e.Value = "Activo";
                        }
                        else
                        {
                            e.Value = "Inactivo"; 
                        }

                        e.FormattingApplied = true;
                    }
                    catch (FormatException)
                    {
                        e.FormattingApplied = false;
                    }
                }
            }
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada
    if (dgvEmpleados.SelectedRows.Count > 0)
            {
                Usuario empleadoSeleccionado = (Usuario)dgvEmpleados.SelectedRows[0].DataBoundItem;

                txtNombre.Text = empleadoSeleccionado.Nombre;
                txtApellidos.Text = empleadoSeleccionado.Apellidos;
                txtCorreo.Text = empleadoSeleccionado.Correo;
                txtNomina.Text = empleadoSeleccionado.NumeroNomina;
                dtpNacimiento.Value = empleadoSeleccionado.FechaNacimiento;
                cbRol.SelectedValue = empleadoSeleccionado.oRol.IdRol;
                txtTel.Text = empleadoSeleccionado.Telefono;

                
                if (empleadoSeleccionado.oDomicilio != null)
                {
                    cbPais.SelectedItem = empleadoSeleccionado.oDomicilio.Pais;
                    cbEstado.SelectedItem = empleadoSeleccionado.oDomicilio.Estado;
                    cbCiudad.SelectedItem = empleadoSeleccionado.oDomicilio.Ciudad;
                    txtCalle.Text = empleadoSeleccionado.oDomicilio.Calle;
                    txtNumero.Text = empleadoSeleccionado.oDomicilio.Numero;
                    txtCp.Text = empleadoSeleccionado.oDomicilio.CodigoPostal;
                    idDomicilioSeleccionado = empleadoSeleccionado.oDomicilio.IdDomicilio;
                }
                else
                {
                    cbPais.SelectedIndex = -1;
                    cbEstado.SelectedIndex = -1;
                    cbCiudad.SelectedIndex = -1;
                    txtCalle.Clear();
                    txtNumero.Clear();
                    txtCp.Clear();
                    idDomicilioSeleccionado = null;
                }


                // Guarda el ID del usuario seleccionado
                idEmpleadoSeleccionado = empleadoSeleccionado.IdUsuario;
                txtNomina.Enabled = false;
                txtContra.Enabled = false;
                txtConfirmarcontra.Enabled = false;
            }
        }

        private void btnlimpiartxt_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEstado.Items.Clear();
            cbCiudad.Items.Clear();

            //Mientras solo este mexico no importa, si agregarmos mas paises hay que cambiar 
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

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (idEmpleadoSeleccionado == null)
            {
                MessageBox.Show("Por favor, selecciona un empleado de la lista para editar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Usuario empleado = new Usuario();

            empleado.IdUsuario = idEmpleadoSeleccionado.Value;
            empleado.Nombre = txtNombre.Text.Trim();
            empleado.Apellidos = txtApellidos.Text.Trim();
            empleado.Correo = txtCorreo.Text.Trim();
            empleado.NumeroNomina = txtNomina.Text.Trim();
            empleado.FechaNacimiento = dtpNacimiento.Value;
            empleado.Telefono = txtTel.Text.Trim();

            //Validacion de que un rol esta seleccionado
            if (cbRol.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un Rol.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbRol.Focus();
                return;
            }
            empleado.oRol = new Rol() { IdRol = Convert.ToInt32(cbRol.SelectedValue) };
            empleado.Estado = true;

            string paisSeleccionado = cbPais.SelectedItem?.ToString();
            string estadoSeleccionado = cbEstado.SelectedItem?.ToString();
            string ciudadSeleccionada = cbCiudad.SelectedItem?.ToString();
            string calle = txtCalle.Text.Trim();
            string numero = txtNumero.Text.Trim();
            string codigoPostal = txtCp.Text.Trim();

            if (!ValidacionesHelper.ValidarDomicilio(paisSeleccionado, estadoSeleccionado, ciudadSeleccionada, calle, numero, codigoPostal))
            {
                return;
            }

            Domicilio domicilio = new Domicilio();

            domicilio.IdDomicilio = idDomicilioSeleccionado ?? 0;

            domicilio.Pais = paisSeleccionado;
            domicilio.Estado = estadoSeleccionado;
            domicilio.Ciudad = ciudadSeleccionada;
            domicilio.Calle = calle;
            domicilio.Numero = numero;
            domicilio.CodigoPostal = codigoPostal;

            // --- 3. Validarcampos ---
            if (string.IsNullOrEmpty(empleado.Nombre) || string.IsNullOrEmpty(empleado.Apellidos) ||
                string.IsNullOrEmpty(empleado.Correo) || string.IsNullOrEmpty(empleado.Telefono))
            {
                MessageBox.Show("Por favor rellene todos los campos.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- 4. Intentar Guardar ---
            try
            {
                int idDomicilioGuardado = DomicilioDAO.GuardarDomicilio(domicilio);

                UsuarioN negocio = new UsuarioN();

                negocio.ActualizarUsuario(empleado, idDomicilioGuardado);

                MessageBox.Show("Empleado actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4.5 Refrescar y Limpiar
                CargarEmpleados();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el empleado: " + ex.Message + (ex.InnerException != null ? "\nDetalle: " + ex.InnerException.Message : ""), "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // --- 1. Verifica si hay un empleado seleccionado ---
            if (idEmpleadoSeleccionado == null)
            {
                MessageBox.Show("Por favor, selecciona un empleado de la lista para eliminar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // --- 2. Pide Confirmación ---
            string nombreEmpleado = txtNombre.Text + " " + txtApellidos.Text;
            DialogResult confirmacion = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar (marcar como inactivo) al empleado '{nombreEmpleado}'?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // --- 3. Procede solo si el usuario confirma ---
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    // --- 4. Llama a la Capa de Negocio ---
                    UsuarioN negocio = new UsuarioN();
                    int filasAfectadas = negocio.EliminarLogicoUsuario(idEmpleadoSeleccionado.Value);

                    // --- 5. Informa el resultado ---
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Empleado eliminado (marcado como inactivo) con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // --- 6. Refresca y Limpia ---
                        CargarEmpleados(); // Actualiza la tabla
                        LimpiarFormulario(); // Limpia campos y resetea modo
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el empleado. Es posible que ya haya sido eliminado o no se encuentre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el empleado: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Si el usuario presiona "No", no pasa nada.
        }
    }
}
