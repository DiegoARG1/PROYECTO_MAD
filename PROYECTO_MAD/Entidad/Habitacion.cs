using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class Habitacion
    {
        public int IdHabitacion { get; set; }
        public int IdTipoHabitacion { get; set; }
        public string NroHabitacion { get; set; }
        public int NroPiso { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? UsuarioCreador { get; set; }

        public string NivelTipoHabitacion { get; set; } // propiedad extra para poder mostrar el nivel de la habitacion
        public string NombreHotel { get; set; } // propiedad extra para poder mostrar el nombre del hotel al que pertenece la habitacion

        public Habitacion() { } 
    }
}
