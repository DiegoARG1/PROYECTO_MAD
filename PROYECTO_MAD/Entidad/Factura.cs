using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class Factura
    {
        public int FacturaID { get; set; }
        public Guid IdReservacion { get; set; }
        public int IdHotel { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal TotalHospedaje { get; set; }
        public decimal MontoAnticipo { get; set; }
        public decimal MontoPendientePagado { get; set; }
        public string FormaPago { get; set; }
        public string Estatus { get; set; } // "Pagada", "Cancelada"

        public Factura() { }
    }
}
