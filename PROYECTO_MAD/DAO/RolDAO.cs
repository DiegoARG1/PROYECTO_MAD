using PROYECTO_MAD.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.DAO
{
    public static class RolDAO
    {
        public static List<Rol> ObtenerRoles()
        {
            List<Rol> lista = new List<Rol>();
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT IdRol, Descripcion FROM ROL ORDER BY Descripcion;";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Rol()
                    {
                        IdRol = reader.GetInt32(0),
                        Descripcion = reader.GetString(1)
                    });
                }
            }
            return lista;
        }
    }
}
