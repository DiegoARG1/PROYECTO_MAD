using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string RFC { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public Domicilio oDomicilio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? UsuarioCreador { get; set; }

        public Cliente() { }
    }
}
