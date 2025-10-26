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

namespace PROYECTO_MAD
{
    public partial class frmHoteles : Form
    {
        // Funciones
        private void CargarPaises()
        {
            cbPais.Items.Clear();
            cbPais.Items.Add("Mexico");
            cbPais.SelectedIndex = 0;
        }
        private void CargarHoteles()
        {
            try
            {
                List<Hotel> listaHoteles = HotelDAO.ObtenerHoteles();

                dgvHoteles.AutoGenerateColumns = false;
                dgvHoteles.DataSource = listaHoteles;

                NombreHotel.DataPropertyName = "Nombre";
                PaisHotel.DataPropertyName = "oDomicilioH.Pais";
                EstadoHotel.DataPropertyName = "oDomicilioH.Estado";
                CiudadHotel.DataPropertyName = "oDomicilioH.Ciudad";
                NroHabitaciones.DataPropertyName = "NroHabitaciones";
                NroPisos.DataPropertyName = "NroPisos";
                FechaInicioOperaciones.DataPropertyName = "FechaInicioOperaciones";
                FechaRegistroHotel.DataPropertyName = "FechaRegistro";
                UsuarioCreadorHotel.DataPropertyName = "UsuarioCreador";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los hoteles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            nudNrohabitaciones.Value = 1;
            nudNropisos.Value = 0;
            dtpIniciooperaciones.Value = DateTime.Today;
            txtCalle.Clear();
            txtNumero.Clear();
            txtCp.Clear();

            if (cbPais.Items.Count > 0)
            {
                cbPais.SelectedIndex = 0;
            }
            
                cbEstado.Items.Clear();
                cbCiudad.Items.Clear();
                cbEstado.SelectedIndex = -1;
                cbCiudad.SelectedIndex = -1;

            if (cbPais.SelectedItem != null && cbPais.SelectedItem.ToString() == "Mexico")
            {
                cbEstado.Items.Add("Quintana Roo");
                cbEstado.Items.Add("Oaxaca");
                cbEstado.Items.Add("Yucatan");
                // No preseleccionamos estado, dejamos que el usuario elija de nuevo.
            }

            // Olvida la selección actual de la tabla
            idHotelSeleccionado = null;
            idDomicilioSeleccionado = null;
            dgvHoteles.ClearSelection();

            // Pone el foco en el primer campo
            txtNombre.Focus();
        }
        // Variables
        private int? idHotelSeleccionado = null;
        private int? idDomicilioSeleccionado = null;
        private Usuario usuarioLogueado;

        // Elementos Form
        public frmHoteles(Usuario usuarioQueInicioSesion)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioQueInicioSesion;
        }
        private void frmHoteles_Load(object sender, EventArgs e)
        {
            CargarPaises();
            CargarHoteles();
        }

        private void cbPaishotel_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnlimpiartxt_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (idHotelSeleccionado != null)
            {
                MessageBox.Show("Ya hay un hotel seleccionado. Use 'Editar' para guardar cambios o 'Limpiar' para agregar uno nuevo.", "Acción Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Hotel hotel = new Hotel();
            hotel.Nombre = txtNombre.Text.Trim();
            hotel.NroHabitaciones = (int)nudNrohabitaciones.Value;
            hotel.NroPisos = (int)nudNropisos.Value;
            hotel.FechaInicioOperaciones = dtpIniciooperaciones.Value;

            // Leer datos del Domicilio
            Domicilio domicilio = new Domicilio();
            string pais = cbPais.SelectedItem?.ToString();
            string estado = cbEstado.SelectedItem?.ToString();
            string ciudad = cbCiudad.SelectedItem?.ToString();
            string calle = txtCalle.Text.Trim();
            string numero = txtNumero.Text.Trim();
            string cp = txtCp.Text.Trim();
            domicilio.IdDomicilio = 0;

            //Validaciones

            if (string.IsNullOrEmpty(hotel.Nombre) || hotel.NroHabitaciones <= 0 || hotel.NroPisos < 0)
            {
                MessageBox.Show("Ingrese todos los datos.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                int idDomicilioGuardado = DomicilioDAO.GuardarDomicilio(domicilio);


                int idUsuarioLogueado = this.usuarioLogueado.IdUsuario;
                int filasInsertadas = HotelDAO.InsertarHotel(hotel, idDomicilioGuardado, idUsuarioLogueado);

                if (filasInsertadas > 0)
                {
                    MessageBox.Show("Hotel agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarHoteles();
                    LimpiarFormulario(); 
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el hotel en la base de datos.", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el hotel: " + ex.Message + (ex.InnerException != null ? "\nDetalle: " + ex.InnerException.Message : ""), "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (idHotelSeleccionado == null)
            {
                MessageBox.Show("Por favor, selecciona un hotel de la lista para editar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Hotel hotel = new Hotel();
            hotel.IdHotel = idHotelSeleccionado.Value;
            hotel.Nombre = txtNombre.Text.Trim();
            hotel.NroHabitaciones = (int)nudNrohabitaciones.Value;
            hotel.NroPisos = (int)nudNropisos.Value;
            hotel.FechaInicioOperaciones = dtpIniciooperaciones.Value;

            Domicilio domicilio = new Domicilio();
            domicilio.IdDomicilio = idDomicilioSeleccionado ?? 0;
            string pais = cbPais.SelectedItem?.ToString();
            string estado = cbEstado.SelectedItem?.ToString();
            string ciudad = cbCiudad.SelectedItem?.ToString();
            string calle = txtCalle.Text.Trim();
            string numero = txtNumero.Text.Trim();
            string cp = txtCp.Text.Trim();

            if (string.IsNullOrEmpty(hotel.Nombre) || hotel.NroHabitaciones <= 0 || hotel.NroPisos < 0)
            {
                MessageBox.Show("Ingrese todos los datos.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int idDomicilioGuardado = DomicilioDAO.GuardarDomicilio(domicilio);

                int filasActualizadas = HotelDAO.ActualizarHotel(hotel, idDomicilioGuardado);

                if (filasActualizadas > 0)
                {
                    MessageBox.Show("Hotel actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarHoteles();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el hotel. Es posible que no se encontrara o no hubo cambios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el hotel: " + ex.Message + (ex.InnerException != null ? "\nDetalle: " + ex.InnerException.Message : ""), "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHoteles_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHoteles.SelectedRows.Count > 0)
            {
                Hotel hotelSeleccionado = (Hotel)dgvHoteles.SelectedRows[0].DataBoundItem;

                txtNombre.Text = hotelSeleccionado.Nombre;

                nudNrohabitaciones.Value = Math.Max(nudNrohabitaciones.Minimum, Math.Min(nudNrohabitaciones.Maximum, hotelSeleccionado.NroHabitaciones));
                nudNropisos.Value = Math.Max(nudNropisos.Minimum, Math.Min(nudNropisos.Maximum, hotelSeleccionado.NroPisos));

                // Asegura de que la fecha no esté fuera del rango del DateTimePicker
                if (hotelSeleccionado.FechaInicioOperaciones >= dtpIniciooperaciones.MinDate &&
                    hotelSeleccionado.FechaInicioOperaciones <= dtpIniciooperaciones.MaxDate)
                {
                    dtpIniciooperaciones.Value = hotelSeleccionado.FechaInicioOperaciones;
                }
                else
                {
                    dtpIniciooperaciones.Value = DateTime.Today;
                }


                if (hotelSeleccionado.oDomicilioH != null)
                {
                    cbPais.SelectedItem = hotelSeleccionado.oDomicilioH.Pais;
                    cbEstado.SelectedItem = hotelSeleccionado.oDomicilioH.Estado;
                    cbCiudad.SelectedItem = hotelSeleccionado.oDomicilioH.Ciudad;
                    txtCalle.Text = hotelSeleccionado.oDomicilioH.Calle;
                    txtNumero.Text = hotelSeleccionado.oDomicilioH.Numero;
                    txtCp.Text = hotelSeleccionado.oDomicilioH.CodigoPostal;

                    // Guarda el ID del domicilio para la edición
                    idDomicilioSeleccionado = hotelSeleccionado.oDomicilioH.IdDomicilio;
                }
                else
                {
                    if (cbPais.Items.Count > 0) cbPais.SelectedIndex = 0;
                    txtCalle.Clear();
                    txtNumero.Clear();
                    txtCp.Clear();
                    idDomicilioSeleccionado = null;
                }

                idHotelSeleccionado = hotelSeleccionado.IdHotel;
            }
        }
    }
}
