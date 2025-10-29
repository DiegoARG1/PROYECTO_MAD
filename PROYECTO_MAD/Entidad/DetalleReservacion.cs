using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class DetalleReservacion
    {
        public int IdDetalleReservacion { get; set; }
        public Guid IdReservacion { get; set; }
        public int IdTipoHabitacion { get; set; }
        public int? IdHabitacion { get; set; }// puede ser null por que se asigna en el check in
        public int NroPersonas { get; set; }
        public decimal PrecioNoche { get; set; }

        // Propiedades Adicionales
        public string NivelTipoHabitacion { get; set; } // Ej: "Suite Presidencial"
        public string NroHabitacionFisica { get; set; } // Ej: "101" (despues del Check-In)

        // Constructor
        public DetalleReservacion() { }
    }
}
