using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class Usuario
    {

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public string NumeroNomina { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Domicilio oDomicilio { get; set; }
        public string Telefono { get; set; }
        public Rol oRol { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? UsuarioCreador { get; set; }

        public List<Permiso> oPermisos { get; set; }

        public Usuario() { }

    }
}
