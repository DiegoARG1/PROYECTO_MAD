using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_MAD.DAO;
using PROYECTO_MAD.Entidad;

namespace PROYECTO_MAD
{
    public partial class frmTipohabitaciones : Form
    {
        // Funciones
        private void CargarHotelesCombo()
        {
            try
            {
                List<Hotel> hoteles = HotelDAO.ObtenerHoteles();

                //Asigna la lista como fuente de datos
                cbHotel.DataSource = hoteles;

                //Dile qué propiedad mostrar al usuario
                cbHotel.DisplayMember = "Nombre";

                //Dile qué propiedad usar como valor interno
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
            txtNivel.Clear();
            nudCamas.Value = 0;
            txtTipocama.Clear();
            nudCapacidad.Value = 1;
            nudPrecionoche.Value = 0;

            cAire.Checked = false;
            cTv.Checked = false;
            cWifi.Checked = false;
            cToallas.Checked = false;
            cAseopersonal.Checked = false;
            cMinibar.Checked = false;
            cTerraza.Checked = false;

            idTipoHabitacionSeleccionado = null;
            dgvTipohabitacion.ClearSelection();
            cbHotel.Enabled = true;
        }
        private void CargarTiposHabitacion(int idHotel)
        {
            try
            {
                // 1. Obtiene la lista filtrada desde el DAO
                List<TipoHabitacion> listaTipos = TipoHabitacionDAO.ObtenerTiposPorHotel(idHotel);

                // 2. Configura y enlaza el DataGridView
                dgvTipohabitacion.AutoGenerateColumns = false;
                dgvTipohabitacion.DataSource = listaTipos;

                NombreHotelTipoHabitacion.DataPropertyName = "NombreHotel"; // Muestra el nombre, no el ID
                Nivel.DataPropertyName = "Nivel";
                NroCamas.DataPropertyName = "NroCamas";
                TipoCamas.DataPropertyName = "TipoCamas";
                Capacidad.DataPropertyName = "Capacidad";
                PrecioNoche.DataPropertyName = "PrecioNoche";
                FechaRegistroTipoHabitacion.DataPropertyName = "FechaRegistro";
                UsuarioCreadorTiposHabitacion.DataPropertyName = "UsuarioCreador";

                // Formato para la columna de precio
                dgvTipohabitacion.Columns["PrecioNoche"].DefaultCellStyle.Format = "C2"; // Formato de moneda

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos de habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvTipohabitacion.DataSource = null;
            }
        }

        // Variables
        private int? idTipoHabitacionSeleccionado = null;
        private Usuario usuarioLogueado = null;

        public frmTipohabitaciones(Usuario usuarioQueInicioSesion)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioQueInicioSesion;
        }

        private void frmTipohabitaciones_Load(object sender, EventArgs e)
        {
            CargarHotelesCombo();
        }

        private void cbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia la tabla y los campos de detalle primero
            dgvTipohabitacion.DataSource = null; // Asegúrate que tu DataGridView se llame así
            LimpiarFormulario(); // Necesitarás crear este método auxiliar

            // Si hay un hotel seleccionado válidamente...
            if (cbHotel.SelectedValue != null && cbHotel.SelectedValue is int)
            {
                int idHotelSeleccionado = (int)cbHotel.SelectedValue;
                CargarTiposHabitacion(idHotelSeleccionado); // Llama al método que carga la tabla
            }
        }

        private void btnlimpiartxt_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (idTipoHabitacionSeleccionado != null)
            {
                MessageBox.Show("Ya hay un tipo seleccionado. Use 'Editar' o 'Limpiar'.", "Acción Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Leer Datos del Formulario
            TipoHabitacion tipo = new TipoHabitacion();

            // Verifica si hay un hotel seleccionado
            if (cbHotel.SelectedValue == null || !(cbHotel.SelectedValue is int))
            {
                MessageBox.Show("Por favor, seleccione un Hotel.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbHotel.Focus();
                return;
            }
            tipo.IdHotel = (int)cbHotel.SelectedValue;
            tipo.Nivel = txtNivel.Text.Trim();
            tipo.NroCamas = (int)nudCamas.Value;
            tipo.TipoCamas = txtTipocama.Text.Trim();
            tipo.Capacidad = (int)nudCapacidad.Value;
            tipo.PrecioNoche = nudPrecionoche.Value;

            //Leer Amenidades Seleccionadas
            List<int> idsAmenidadesSeleccionadas = new List<int>();

            if (cAire.Checked) idsAmenidadesSeleccionadas.Add(1);
            if (cTv.Checked) idsAmenidadesSeleccionadas.Add(2);
            if (cWifi.Checked) idsAmenidadesSeleccionadas.Add(3);
            if (cToallas.Checked) idsAmenidadesSeleccionadas.Add(4);
            if (cAseopersonal.Checked) idsAmenidadesSeleccionadas.Add(5);
            if (cMinibar.Checked) idsAmenidadesSeleccionadas.Add(6);
            if (cTerraza.Checked) idsAmenidadesSeleccionadas.Add(7);

            //Validaciones
            if (string.IsNullOrEmpty(tipo.Nivel) || string.IsNullOrEmpty(tipo.TipoCamas) || tipo.NroCamas <= 0 || tipo.Capacidad <= 0 || tipo.PrecioNoche < 0)
            {
                MessageBox.Show("Porfavor ingrese todos los datos.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Intentar Guardar
            try
            {
                //Guardar el Tipo de Habitación principal y obtener el nuevo ID
                int idUsuarioLogueado = this.usuarioLogueado.IdUsuario;
                int nuevoTipoHabitacionId = TipoHabitacionDAO.InsertarTipoHabitacion(tipo, idUsuarioLogueado);

                //Guardar las amenidades asociadas
                TipoHabitacionDAO.GuardarAmenidadesParaTipo(nuevoTipoHabitacionId, idsAmenidadesSeleccionadas);

                MessageBox.Show("Tipo de habitación agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTiposHabitacion(tipo.IdHotel);
                LimpiarFormulario();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el tipo de habitación: " + ex.Message + (ex.InnerException != null ? "\nDetalle: " + ex.InnerException.Message : ""), "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTipohabitacion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTipohabitacion.SelectedRows.Count > 0)
            {
                TipoHabitacion tipoSeleccionado = (TipoHabitacion)dgvTipohabitacion.SelectedRows[0].DataBoundItem;

                cbHotel.SelectedValue = tipoSeleccionado.IdHotel;
                txtNivel.Text = tipoSeleccionado.Nivel;
                nudCamas.Value = tipoSeleccionado.NroCamas;
                txtTipocama.Text = tipoSeleccionado.TipoCamas;
                nudCapacidad.Value = tipoSeleccionado.Capacidad;
                nudPrecionoche.Value = tipoSeleccionado.PrecioNoche;

                // aqui cargamos las amenidades asociadas con el id del tipo de habitacion
                List<int> idsAmenidadesActuales = TipoHabitacionDAO.ObtenerIdsAmenidadesPorTipo(tipoSeleccionado.IdTipoHabitacion);

                cAire.Checked = false;
                cTv.Checked = false;
                cWifi.Checked = false;
                cToallas.Checked = false;
                cAseopersonal.Checked = false;
                cMinibar.Checked = false;
                cTerraza.Checked = false;

                if (idsAmenidadesActuales.Contains(1)) cAire.Checked = true;
                if (idsAmenidadesActuales.Contains(2)) cTv.Checked = true;
                if (idsAmenidadesActuales.Contains(3)) cWifi.Checked = true;
                if (idsAmenidadesActuales.Contains(4)) cToallas.Checked = true;
                if (idsAmenidadesActuales.Contains(5)) cAseopersonal.Checked = true;
                if (idsAmenidadesActuales.Contains(6)) cMinibar.Checked = true;
                if (idsAmenidadesActuales.Contains(7)) cTerraza.Checked = true;

                idTipoHabitacionSeleccionado = tipoSeleccionado.IdTipoHabitacion;

                cbHotel.Enabled = false;
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (idTipoHabitacionSeleccionado == null)
            {
                MessageBox.Show("Por favor, selecciona un tipo de habitación de la lista para editar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TipoHabitacion tipo = new TipoHabitacion();
            tipo.IdTipoHabitacion = idTipoHabitacionSeleccionado.Value;

            if (cbHotel.SelectedValue == null || !(cbHotel.SelectedValue is int))
            {
                MessageBox.Show("Debe haber un hotel seleccionado.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbHotel.Focus();
                return;
            }
            tipo.IdHotel = (int)cbHotel.SelectedValue;
            tipo.Nivel = txtNivel.Text.Trim();
            tipo.NroCamas = (int)nudCamas.Value;
            tipo.TipoCamas = txtTipocama.Text.Trim();
            tipo.Capacidad = (int)nudCapacidad.Value;
            tipo.PrecioNoche = nudPrecionoche.Value;

            List<int> idsAmenidadesSeleccionadas = new List<int>();
            if (cAire.Checked) idsAmenidadesSeleccionadas.Add(1);
            if (cTv.Checked) idsAmenidadesSeleccionadas.Add(2);
            if (cWifi.Checked) idsAmenidadesSeleccionadas.Add(3);
            if (cToallas.Checked) idsAmenidadesSeleccionadas.Add(4);
            if (cAseopersonal.Checked) idsAmenidadesSeleccionadas.Add(5);
            if (cMinibar.Checked) idsAmenidadesSeleccionadas.Add(6);
            if (cTerraza.Checked) idsAmenidadesSeleccionadas.Add(7);

            if (string.IsNullOrEmpty(tipo.Nivel) || string.IsNullOrEmpty(tipo.TipoCamas) || tipo.NroCamas <= 0 || tipo.Capacidad <= 0 || tipo.PrecioNoche < 0)
            {
                MessageBox.Show("Porfavor ingrese todos los datos.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int filasActualizadas = TipoHabitacionDAO.ActualizarTipoHabitacion(tipo);

                TipoHabitacionDAO.GuardarAmenidadesParaTipo(tipo.IdTipoHabitacion, idsAmenidadesSeleccionadas);

                if (filasActualizadas > 0)
                {
                    MessageBox.Show("Tipo de habitación actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the grid only if a hotel is selected
                    if (cbHotel.SelectedValue != null && cbHotel.SelectedValue is int)
                    {
                        CargarTiposHabitacion((int)cbHotel.SelectedValue);
                    }
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el tipo de habitación. Es posible que no se encontrara.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el tipo de habitación: " + ex.Message + (ex.InnerException != null ? "\nDetalle: " + ex.InnerException.Message : ""), "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
