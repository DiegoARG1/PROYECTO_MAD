using PROYECTO_MAD.DAO;
using PROYECTO_MAD.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Negocio
{
    public class UsuarioN
    {
        public int EliminarLogicoUsuario(int idUsuario)
        {
            return UsuarioDAO.EliminarLogicoUsuario(idUsuario);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return UsuarioDAO.ObtenerUsuarios();
        }

        public Usuario Login(string correo, string contrasenia)
        {
            Usuario usuario = UsuarioDAO.IniciarSesion(correo, contrasenia);

            // Si el usuario es valido carga sus permisos aquí.
            if (usuario != null)
            {
                PermisoDAO oPermisoDAO = new PermisoDAO();
                usuario.oPermisos = oPermisoDAO.ObtenerPermisosPorRol(usuario.oRol.IdRol);
            }

            return usuario;
        }

        public bool ExisteUsuario(string correo, string numeroNomina)
        {
            return UsuarioDAO.ExisteUsuario(correo, numeroNomina);
        }

        public int InsertarUsuario(Usuario usuario, int? idDomicilio, int idUsuarioCreador)
        {
            return UsuarioDAO.InsertarUsuario(usuario, idDomicilio, idUsuarioCreador);
        }

        public int ActualizarUsuario(Usuario usuario, int? idDomicilio)
        {
            return UsuarioDAO.ActualizarUsuario(usuario, idDomicilio);
        }
    }
}
