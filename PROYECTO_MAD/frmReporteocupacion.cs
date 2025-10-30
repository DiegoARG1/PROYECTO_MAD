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
    public partial class frmReporteocupacion : Form
    {
        // Funciones
        private void CargarAnios()
        {
            // Llena el ComboBox de Año (ej. ultimos 5 años)
            cboAnio.Items.Clear();
            int anioActual = DateTime.Today.Year;
            for (int i = 0; i < 5; i++)
            {
                cboAnio.Items.Add(anioActual - i);
            }
            cboAnio.SelectedIndex = 0;
        }
        private void CargarPaises()
        {
            cboPais.Items.Clear();
            cboPais.Items.Add("Mexico");
            cboPais.SelectedIndex = 0;
        }
        private void CargarHotelesPorCiudad()
        {
            cboHotel.DataSource = null; // Limpia primero
            cboHotel.SelectedIndex = -1;

            if (cboCiudad.SelectedItem != null)
            {
                string ciudadSeleccionada = cboCiudad.SelectedItem.ToString();
                try
                {
                    // usaremos la misma funcion para listar todos los hoteles y lo filtraremos ya en memoria
                    List<Hotel> todosHoteles = HotelDAO.ObtenerHoteles();
                    List<Hotel> hotelesCiudad = todosHoteles
                                               .Where(h => h.oDomicilioH?.Ciudad == ciudadSeleccionada)
                                               .OrderBy(h => h.Nombre)
                                               .ToList();

                    // Añade opcion "Todos"
                    hotelesCiudad.Insert(0, new Hotel { IdHotel = -1, Nombre = "[Todos los hoteles de esta ciudad]" });

                    cboHotel.DataSource = hotelesCiudad;
                    cboHotel.DisplayMember = "Nombre";
                    cboHotel.ValueMember = "IdHotel";
                    cboHotel.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar hoteles para la ciudad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Elementos del Form
        public frmReporteocupacion()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargarAnios();
            CargarPaises();
            dgvReporteOcupacion.DataSource = null;
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboEstado.Items.Clear();
            cboCiudad.Items.Clear();
            cboEstado.SelectedIndex = -1;
            cboCiudad.SelectedIndex = -1;

            if (cboPais.SelectedItem != null && cboPais.SelectedItem.ToString() == "Mexico")
            {
                cboEstado.Items.Add("Quintana Roo");
                cboEstado.Items.Add("Oaxaca");
                cboEstado.Items.Add("Yucatan");
            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCiudad.Items.Clear();
            cboCiudad.SelectedIndex = -1;

            if (cboEstado.SelectedItem != null)
            {
                string estadoSeleccionado = cboEstado.SelectedItem.ToString();

                switch (estadoSeleccionado)
                {
                    case "Quintana Roo":
                        cboCiudad.Items.Add("Cancun");
                        cboCiudad.Items.Add("Playa del Carmen");
                        cboCiudad.Items.Add("Chetumal");
                        break;
                    case "Oaxaca":
                        cboCiudad.Items.Add("Oaxaca de Juarez");
                        cboCiudad.Items.Add("Puerto Escondido");
                        cboCiudad.Items.Add("Salina Cruz");
                        break;
                    case "Yucatan":
                        cboCiudad.Items.Add("Merida");
                        cboCiudad.Items.Add("Valladolid");
                        cboCiudad.Items.Add("Progreso");
                        break;
                }
            }
        }

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarHotelesPorCiudad();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (cboAnio.SelectedItem == null || cboCiudad.SelectedItem == null || cboHotel.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione Año, País, Estado, Ciudad y Hotel.", "Filtros Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int anio = (int)cboAnio.SelectedItem;
            string ciudad = cboCiudad.SelectedItem.ToString();
            int idHotelSeleccionado = (int)cboHotel.SelectedValue;
            int? idHotelParam = (idHotelSeleccionado == -1) ? (int?)null : idHotelSeleccionado; // Si es -1 (Todos), pasa NULL al DAO

            // 2. Llamar al DAO
            try
            {
                List<ReporteOcupacion> reporteData = ReporteDAO.ObtenerReporteOcupacion(anio, idHotelParam, ciudad);

                // 3. Configurar y Llenar DGV
                dgvReporteOcupacion.AutoGenerateColumns = false;
                dgvReporteOcupacion.DataSource = reporteData;

                // Conecta columnas (Usa TUS nombres de columna)
                CiudadReporteOcupacion.DataPropertyName = "Ciudad";
                NombreHotelReporteOcupacion.DataPropertyName = "NombreHotel";
                AnioMesReporteOcupacion.DataPropertyName = "AnioMes";
                TipoHabitacionReporteOcupacion.DataPropertyName = "TipoHabitacion";
                CantidadHabitacionesReporteOcupacion.DataPropertyName = "CantidadHabitacionesTipo";
                PorcentajeOcupacionReporteOcupacion.DataPropertyName = "PorcentajeOcupacion";
                CantidadPersonasReporteOcupacion.DataPropertyName = "CantidadPersonasHospedadas";

                dgvReporteOcupacion.Columns["PorcentajeOcupacionReporteOcupacion"].DefaultCellStyle.Format = "P0"; // "85 %"

                if (reporteData.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos de ocupación para los filtros seleccionados.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte de ocupación: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvReporteOcupacion.DataSource = null;
            }
        }
    }
}
