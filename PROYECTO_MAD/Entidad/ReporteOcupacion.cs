using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class ReporteOcupacion
    {
        public string Ciudad { get; set; }
        public string NombreHotel { get; set; }
        public string AnioMes { get; set; }
        public string TipoHabitacion { get; set; }
        public int CantidadHabitacionesTipo { get; set; }
        public decimal PorcentajeOcupacion { get; set; }
        public int CantidadPersonasHospedadas { get; set; }

        public ReporteOcupacion() { }
    }
}
