using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class Reservacion
    {
        public Guid IdReservacion { get; set; } // Llave Primaria (GUID)
        public int IdCliente { get; set; }
        public int IdHotel { get; set; }
        public int IdUsuario { get; set; } // el usuario que hizo la reservacion
        public DateTime FechaReservacion { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public decimal Anticipo { get; set; }
        public string MetodoPago { get; set; } // Del anticipo
        public string Estado { get; set; } // "Activa", "Cancelada", etc.

        // Propiedad de Navegacion (Relacion Uno a Muchos)
        // Guarda la lista de habitaciones de esta reserva
        public List<DetalleReservacion> Detalles { get; set; }

        // Propiedades Adicionales
        public string NombreCliente { get; set; }
        public string NombreHotel { get; set; }

        public Reservacion()
        {
            Detalles = new List<DetalleReservacion>();
        }
    }
}
