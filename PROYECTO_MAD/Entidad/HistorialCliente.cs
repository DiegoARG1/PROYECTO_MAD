using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class HistorialCliente
    {
        public string NombreCliente { get; set; }
        public string Ciudad { get; set; }
        public string Hotel { get; set; }
        public int NumeroPersonasHospedadas { get; set; } // Suma de personas por reserva
        public Guid CodigoReservacion { get; set; }
        public DateTime FechaReservacion { get; set; }
        public DateTime? FechaCheckIn { get; set; } // Nullable DateTime
        public DateTime? FechaCheckOut { get; set; } // Nullable DateTime (de la factura o reserva)
        public string EstatusReservacion { get; set; }
        public decimal Anticipo { get; set; }
        public decimal? MontoHospedaje { get; set; } // Nullable (de la factura)
        public decimal? TotalFactura { get; set; } // Nullable (de la factura)

        public HistorialCliente() { }
    }
}
