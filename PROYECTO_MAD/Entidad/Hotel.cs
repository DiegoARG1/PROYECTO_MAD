using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    internal class Hotel
    {
        public int IdHotel { get; set; }
        public string Nombre { get; set; }
        public Domicilio oDomicilioH { get; set; }
        public int NroHabitaciones { get; set; }
        public int NroPisos { get; set; }
        public DateTime FechaInicioOperaciones { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? UsuarioCreador { get; set; }

        public Hotel() { }

    }
}
