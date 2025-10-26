using PROYECTO_MAD.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.DAO
{
    public class PermisoDAO
    {
        public List<Permiso> ObtenerPermisosPorRol(int idRol)
        {
            List<Permiso> lista = new List<Permiso>();
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT NombreMenu FROM PERMISO WHERE IdRol = @idRol;";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idRol", idRol);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Permiso()
                    {
                        NombreMenu = reader["NombreMenu"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}
