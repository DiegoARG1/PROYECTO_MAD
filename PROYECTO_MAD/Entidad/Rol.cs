using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class Rol
    {
        public int IdRol { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaReistro { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
