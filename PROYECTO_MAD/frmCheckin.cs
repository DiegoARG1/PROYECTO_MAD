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
using System.Text.RegularExpressions;

namespace PROYECTO_MAD
{
    public partial class frmCheckin : Form
    {
        // Variables
        private Usuario usuarioLogueado;
        private Reservacion reservacionActual = null;

        //Funciones
        private void LimpiarFormulario()
        {
            txtCodigoBusqueda.Clear();
            dgvHabitacionesPorAsignar.DataSource = null;
            dgvHabitacionesPorAsignar.Rows.Clear();
            reservacionActual = null;
            btnConfirmarCheckIn.Enabled = false;
            txtCodigoBusqueda.Focus();
        }

        //Elementos Form
        public frmCheckin(Usuario usuarioQueInicioSesion)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioQueInicioSesion;
            LimpiarFormulario();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string codigoTextoOriginal = txtCodigoBusqueda.Text;
            string codigoTextoLimpio = Regex.Replace(codigoTextoOriginal, @"[^a-fA-F0-9-]", "");

            reservacionActual = null;
            btnConfirmarCheckIn.Enabled = false;

            if (string.IsNullOrEmpty(codigoTextoLimpio) || !Guid.TryParse(codigoTextoLimpio, out Guid codigoGuid))
            {
                MessageBox.Show($"El código '{codigoTextoOriginal}' no pudo ser reconocido como un GUID válido.",
                                "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Buscar Reservación Principal
                reservacionActual = ReservacionesDAO.ObtenerReservacionPorCodigo(codigoGuid);

                // Validaciones de la Reserva
                if (reservacionActual == null)
                {
                    MessageBox.Show("No se encontró ninguna reservación con ese código.", "No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (reservacionActual.Estado != "Activa")
                {
                    MessageBox.Show($"El estado de esta reservación es '{reservacionActual.Estado}'. Solo se puede hacer Check-In a reservaciones 'Activas'.", "Estado Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (reservacionActual.FechaEntrada.Date != DateTime.Today)
                {
                    DialogResult Rpta = MessageBox.Show($"La fecha de Check-In para esta reservación es {reservacionActual.FechaEntrada:dd/MM/yyyy}, no hoy ({DateTime.Today:dd/MM/yyyy}).\n\n¿Desea continuar de todas formas?",
                                   "Advertencia de Fecha", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Rpta == DialogResult.No)
                    {
                        LimpiarFormulario();
                        return;
                    }
                }

                // Buscar Detalles (Habitaciones a asignar)
                List<DetalleReservacion> detalles = ReservacionesDAO.ObtenerDetallesSinAsignar(codigoGuid);

                if (detalles.Count == 0)
                {
                    MessageBox.Show("Todas las habitaciones para esta reservacion ya han sido asignadas o la reserva no tiene detalles.", "Check-In Completo o Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Preparar y Llenar el DataGridView
                dgvHabitacionesPorAsignar.Rows.Clear();
                dgvHabitacionesPorAsignar.Columns.Clear();

                dgvHabitacionesPorAsignar.Columns.Add(new DataGridViewTextBoxColumn { Name = "colIdDetalle", Visible = false });
                dgvHabitacionesPorAsignar.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTipoHab", HeaderText = "Tipo de Habitación", ReadOnly = true });
                dgvHabitacionesPorAsignar.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPersonas", HeaderText = "# Personas", ReadOnly = true });

                // La columna ComboBox para asignar
                DataGridViewComboBoxColumn comboColumna = new DataGridViewComboBoxColumn();
                comboColumna.Name = "colAsignarHabitacion";
                comboColumna.HeaderText = "# Habitación Física";
                comboColumna.FlatStyle = FlatStyle.Flat;

                dgvHabitacionesPorAsignar.Columns.Add(comboColumna);


                // Llena las filas y los ComboBoxes
                foreach (var detalle in detalles)
                {
                    // Busca las habitaciones físicas disponibles para ESTE tipo
                    List<Habitacion> fisicasDisponibles = HabitacionDAO.ObtenerHabitacionesFisicasDisponibles(detalle.IdTipoHabitacion);

                    // Crea la nueva fila en el DataGridView
                    int rowIndex = dgvHabitacionesPorAsignar.Rows.Add();
                    DataGridViewRow nuevaFila = dgvHabitacionesPorAsignar.Rows[rowIndex];

                    // Llena los datos basicos
                    nuevaFila.Cells["colIdDetalle"].Value = detalle.IdDetalleReservacion;
                    nuevaFila.Cells["colTipoHab"].Value = detalle.NivelTipoHabitacion;
                    nuevaFila.Cells["colPersonas"].Value = detalle.NroPersonas;

                    // Configura y llena el ComboBox de ESTA fila
                    DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)nuevaFila.Cells["colAsignarHabitacion"];
                    comboCell.DataSource = fisicasDisponibles;
                    comboCell.DisplayMember = "NroHabitacion";
                    comboCell.ValueMember = "IdHabitacion";
                    comboCell.Value = null;
                    if (fisicasDisponibles.Count == 0)
                    {
                        // Si no hay habitaciones disponibles de ese tipo, deshabilita el combo o indica
                        comboCell.ReadOnly = true;
                        var placeholder = new List<Habitacion> { new Habitacion { IdHabitacion = -1, NroHabitacion = "No disponibles" } };
                        comboCell.DataSource = placeholder;
                        comboCell.DisplayMember = "NroHabitacion";
                        comboCell.ValueMember = "IdHabitacion";
                        comboCell.Value = -1;
                    }
                }

                dgvHabitacionesPorAsignar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                btnConfirmarCheckIn.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la reservación para Check-In: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarFormulario();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnConfirmarCheckIn_Click(object sender, EventArgs e)
        {
            if (reservacionActual == null || reservacionActual.Estado != "Activa")
            {
                MessageBox.Show("Primero debe buscar y cargar una reservación 'Activa'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Recolectar las asignaciones del DataGridView
            List<Tuple<int, int>> asignaciones = new List<Tuple<int, int>>();
            bool todasAsignadas = true; // Bandera para verificar

            foreach (DataGridViewRow fila in dgvHabitacionesPorAsignar.Rows)
            {
                // Obtener el ID del Detalle de la reserva (guardado en la celda oculta)
                int idDetalle = Convert.ToInt32(fila.Cells["colIdDetalle"].Value);

                // Obtener el ID de la Habitación fisica seleccionada en el ComboBox
                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)fila.Cells["colAsignarHabitacion"];
                object valorSeleccionado = comboCell.Value; // Obtiene el SelectedValue (IdHabitacion)

                // Validar que se haya seleccionado una habitación
                if (valorSeleccionado == null || !(valorSeleccionado is int) || (int)valorSeleccionado <= 0)
                {
                    // Verifica si la celda esta habilitada (si habia habitaciones disponibles)
                    if (!comboCell.ReadOnly)
                    {
                        MessageBox.Show($"Debe asignar una habitación física para el tipo '{fila.Cells["colTipoHab"].Value}'.", "Asignación Pendiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvHabitacionesPorAsignar.CurrentCell = comboCell;
                        dgvHabitacionesPorAsignar.BeginEdit(true);
                        todasAsignadas = false;
                        break;
                    }
                    else
                    {
                        // Si la celda estaba ReadOnly, significa que no habia disponibles
                        MessageBox.Show($"No hay habitaciones físicas disponibles para asignar al tipo '{fila.Cells["colTipoHab"].Value}'. No se puede completar el Check-In.", "Sin Disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        todasAsignadas = false;
                        break;
                    }
                }
                else
                {
                    // Si hay valor, crea la tupla y añadela a la lista
                    int idHabitacionAsignada = (int)valorSeleccionado;
                    asignaciones.Add(new Tuple<int, int>(idDetalle, idHabitacionAsignada));
                }
            }

            // Si alguna validación fallo dentro del bucle, detiene
            if (!todasAsignadas)
            {
                return;
            }

            // Asegura que si se encontraron asignaciones (por si la tabla estaba vacia)
            if (asignaciones.Count == 0)
            {
                MessageBox.Show("No hay habitaciones para asignar en esta reservación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Confirmacion Final
            DialogResult confirmacion = MessageBox.Show($"Se asignarán {asignaciones.Count} habitación(es) a la reservación.\n¿Desea confirmar el Check-In?",
                                                     "Confirmar Check-In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
            {
                return;
            }

            try
            {
                bool exito = ReservacionesDAO.AsignarHabitacionCheckIn(asignaciones, reservacionActual.IdReservacion);

                if (exito)
                {
                    MessageBox.Show("¡Check-In realizado con éxito! Las habitaciones han sido asignadas y marcadas como ocupadas.", "Check-In Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo completar el Check-In. Es posible que los datos hayan cambiado o hubo un error inesperado.", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico durante el Check-In: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
