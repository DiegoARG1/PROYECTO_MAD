using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class ReporteVentas
    {
        public string Ciudad { get; set; }
        public string NombreHotel { get; set; }
        public string AnioMes { get; set; }
        public decimal IngresosHospedaje { get; set; }
        public decimal IngresosTotales { get; set; }

        public ReporteVentas() { }
    }
}
