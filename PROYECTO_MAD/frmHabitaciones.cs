using PROYECTO_MAD.DAO;
using PROYECTO_MAD.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_MAD
{
    public partial class frmHabitaciones : Form
    {
        // Variables
        private int? idHabitacionSeleccionada = null;
        private Usuario usuarioLogueado;

        // Funciones
        private void CargarHoteles()
        {
            try
            {
                List<Hotel> hoteles = HotelDAO.ObtenerHoteles();

                cbHotel.DataSource = hoteles;
                cbHotel.DisplayMember = "Nombre";
                cbHotel.ValueMember = "IdHotel";
                cbHotel.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de hoteles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarFormulario()
        {
            cbHotel.SelectedIndex = -1;

            cbTipohabitacion.DataSource = null;
            cbTipohabitacion.Items.Clear();
            cbTipohabitacion.SelectedIndex = -1;

            dgvHabitaciones.DataSource = null;

            LimpiarCamposDetalleHabitacion();

            cbHotel.Focus();
        }
        private void LimpiarCamposDetalleHabitacion()
        {
            txtNrohabitacion.Clear();
            nudNropiso.Value = 0;
            cbEstado.SelectedIndex = -1;
            idHabitacionSeleccionada = null;
            if (dgvHabitaciones.SelectedRows.Count > 0) dgvHabitaciones.ClearSelection();
        }
        private void CargarTiposHabitacion(int idHotel)
        {
            try
            {
                List<TipoHabitacion> listaTipos = TipoHabitacionDAO.ObtenerTiposPorHotel(idHotel);

                cbTipohabitacion.DataSource = listaTipos;
                cbTipohabitacion.DisplayMember = "Nivel";
                cbTipohabitacion.ValueMember = "IdTipoHabitacion";
                cbTipohabitacion.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos de habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbTipohabitacion.DataSource = null;
            }
        }
        private void CargarHabitaciones(int idHotel)
        {
            try
            {
                List<Habitacion> listaHabitaciones = HabitacionDAO.ObtenerHabitacionesPorHotel(idHotel);

                dgvHabitaciones.AutoGenerateColumns = false;
                dgvHabitaciones.DataSource = listaHabitaciones;

                NombreHotelHabitaciones.DataPropertyName = "NombreHotel";
                TipoHabitacionHabitacion.DataPropertyName = "NivelTipoHabitacion";
                NroHabitacion.DataPropertyName = "NroHabitacion";
                NroPiso.DataPropertyName = "NroPiso";
                EstadoHabitaciones.DataPropertyName = "Estado";
                FechaRegistroHabitaciones.DataPropertyName = "FechaRegistro";
                UsuarioCreadorHabitaciones.DataPropertyName = "UsuarioCreador";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las habitaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvHabitaciones.DataSource = null;
            }
        }

        //Elementos Form
        public frmHabitaciones(Usuario usuarioQueInicioSesion)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioQueInicioSesion;
        }
        
        private void frmHabitaciones_Load(object sender, EventArgs e)
        {
            CargarHoteles();
        }

        private void btnlimpiartxt_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (idHabitacionSeleccionada != null)
            {
                MessageBox.Show("Ya hay una habitación seleccionada. Use 'Editar' o 'Limpiar'.", "Acción Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Habitacion habitacion = new Habitacion();

            if (cbHotel.SelectedValue == null || !(cbHotel.SelectedValue is int))
            {
                MessageBox.Show("Por favor, seleccione un Hotel.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbHotel.Focus();
                return;
            }

            int idHotelSeleccionado = (int)cbHotel.SelectedValue;

            if (cbTipohabitacion.SelectedValue == null || !(cbTipohabitacion.SelectedValue is int))
            {
                MessageBox.Show("Por favor, seleccione un Tipo de Habitación.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTipohabitacion.Focus();
                return;
            }
            habitacion.IdTipoHabitacion = (int)cbTipohabitacion.SelectedValue;

            habitacion.NroHabitacion = txtNrohabitacion.Text.Trim();
            habitacion.NroPiso = (int)nudNropiso.Value;
            habitacion.Estado = cbEstado.SelectedItem?.ToString();

            // Validaciones
            if (string.IsNullOrEmpty(habitacion.NroHabitacion) || string.IsNullOrEmpty(habitacion.Estado))
            {
                MessageBox.Show("Por favor ingrese todos datos.", "Datos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNrohabitacion.Focus();
                return;
            }

            // Validacion para que el piso de la habitacion concuerde con los pisos del hotel
            Hotel hotelSeleccionado = (Hotel)cbHotel.SelectedItem;
            if (hotelSeleccionado != null && habitacion.NroPiso > hotelSeleccionado.NroPisos)
            {
                MessageBox.Show($"El número de piso ({habitacion.NroPiso}) no puede ser mayor que el número de pisos del hotel ({hotelSeleccionado.NroPisos}).", "Piso Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudNropiso.Focus();
                return;
            }
            if (habitacion.NroPiso <= 0)
            {
                MessageBox.Show("El número de piso debe ser mayor que cero.", "Piso Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudNropiso.Focus();
                return;
            }

            try
            {
                int idUsuarioLogueado = this.usuarioLogueado.IdUsuario;
                int filasInsertadas = HabitacionDAO.InsertarHabitacion(habitacion, idUsuarioLogueado);

                if (filasInsertadas > 0)
                {
                    MessageBox.Show("Habitación agregada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarHabitaciones(idHotelSeleccionado);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la habitación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (ex is SqlException sqlEx && (sqlEx.Number == 2627 || sqlEx.Number == 2601))
                {
                    MessageBox.Show($"Ya existe una habitación con el número '{habitacion.NroHabitacion}' en este hotel.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error al guardar la habitación: " + ex.Message + (ex.InnerException != null ? "\nDetalle: " + ex.InnerException.Message : ""), "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia el combo de Tipos y la tabla de Habitaciones
            cbTipohabitacion.DataSource = null; // Asegúrate que tu combo se llame cboTipoHabitacion
            dgvHabitaciones.DataSource = null;   // Asegúrate que tu DataGridView se llame dgvHabitaciones
            LimpiarCamposDetalleHabitacion(); // Limpia campos como Nro Habitación, Piso, Estado

            // Si hay un hotel seleccionado válidamente...
            if (cbHotel.SelectedValue != null && cbHotel.SelectedValue is int)
            {
                int idHotelSeleccionado = (int)cbHotel.SelectedValue;
                CargarTiposHabitacion(idHotelSeleccionado);
                CargarHabitaciones(idHotelSeleccionado);
            }
        }
    }
}
