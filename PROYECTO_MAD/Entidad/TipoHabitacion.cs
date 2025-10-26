using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class TipoHabitacion
    {
        public int IdTipoHabitacion { get; set; }
        public int IdHotel { get; set; } // Para saber a qué hotel pertenece
        public string Nivel { get; set; }
        public int NroCamas { get; set; }
        public string TipoCamas { get; set; }
        public int Capacidad { get; set; }
        public decimal PrecioNoche { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? UsuarioCreador { get; set; }

        // Propiedad para guardar las amenidades
        public List<Amenidad> Amenidades { get; set; }

        // Propiedad extra para mostrar el nombre del hotel en el DataGridView
        public string NombreHotel { get; set; }

        public TipoHabitacion()
        {
            Amenidades = new List<Amenidad>(); // Inicializa la lista
        }
    }
    public class Amenidad
    {
        public int IdAmenidad { get; set; }
        public string Nombre { get; set; }
    }
}
