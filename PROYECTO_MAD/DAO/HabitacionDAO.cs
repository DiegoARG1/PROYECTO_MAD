using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_MAD.Entidad;
using System.Data.SqlClient;

namespace PROYECTO_MAD.DAO
{
    public class HabitacionDAO
    {
        public static List<Habitacion> ObtenerHabitacionesPorHotel(int idHotel)
        {
            List<Habitacion> lista = new List<Habitacion>();
            SqlConnection conexion = null;
            SqlDataReader reader = null;

            try
            {
                conexion = BDConexion.ObtenerConexion();
                if (conexion == null) throw new Exception("No se pudo conectar a la BD.");

                // Consulta que une HABITACION con TIPO_HABITACION y HOTEL
                string query = @"
                    SELECT
                        H.IdHabitacion, H.NroHabitacion, H.NroPiso, H.Estado,
                        H.IdTipoHabitacion,H.FechaRegistro,H.UsuarioCreador,T.Nivel AS NivelTipoHabitacion, -- Trae el Nivel del tipo
                        HT.Nombre AS NombreHotel -- Trae el nombre del Hotel
                    FROM HABITACION H
                    INNER JOIN TIPO_HABITACION T ON H.IdTipoHabitacion = T.IdTipoHabitacion
                    INNER JOIN HOTEL HT ON T.IdHotel = HT.IdHotel
                    WHERE T.IdHotel = @IdHotel -- Filtra por el hotel seleccionado
                    ORDER BY H.NroHabitacion;
                ";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdHotel", idHotel);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Habitacion habitacion = new Habitacion();
                    habitacion.IdHabitacion = reader.GetInt32(reader.GetOrdinal("IdHabitacion"));
                    habitacion.IdTipoHabitacion = reader.GetInt32(reader.GetOrdinal("IdTipoHabitacion"));
                    habitacion.NroHabitacion = reader.GetString(reader.GetOrdinal("NroHabitacion"));
                    habitacion.NroPiso = reader.GetInt32(reader.GetOrdinal("NroPiso"));
                    habitacion.Estado = reader.GetString(reader.GetOrdinal("Estado"));
                    habitacion.FechaRegistro = reader.GetDateTime(reader.GetOrdinal("FechaRegistro"));
                    habitacion.UsuarioCreador = reader.IsDBNull(reader.GetOrdinal("UsuarioCreador")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("UsuarioCreador"));

                    // Propiedades extra para mostrar en el DataGridView
                    habitacion.NivelTipoHabitacion = reader.GetString(reader.GetOrdinal("NivelTipoHabitacion"));
                    habitacion.NombreHotel = reader.GetString(reader.GetOrdinal("NombreHotel"));

                    lista.Add(habitacion);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en HabitacionDAO.ObtenerHabitacionesPorHotel: " + ex.ToString());
                throw;
            }
            finally
            {
                reader?.Close();
                conexion?.Close();
            }
            return lista;
        }
        public static int InsertarHabitacion(Habitacion habitacion, int idUsuarioCreador)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = @"
            INSERT INTO HABITACION
                (IdTipoHabitacion, NroHabitacion, NroPiso, Estado, UsuarioCreador)
            VALUES
                (@IdTipoHabitacion, @NroHabitacion, @NroPiso, @Estado, @UsuarioCreador);
                ";

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@IdTipoHabitacion", habitacion.IdTipoHabitacion);
                comando.Parameters.AddWithValue("@NroHabitacion", habitacion.NroHabitacion);
                comando.Parameters.AddWithValue("@NroPiso", habitacion.NroPiso);
                comando.Parameters.AddWithValue("@Estado", habitacion.Estado);
                comando.Parameters.AddWithValue("@UsuarioCreador", idUsuarioCreador);

                return comando.ExecuteNonQuery();
            }
        }
        public static int ActualizarHabitacion(Habitacion habitacion)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = @"
            UPDATE HABITACION SET
                IdTipoHabitacion = @IdTipoHabitacion,
                NroHabitacion = @NroHabitacion,
                NroPiso = @NroPiso,
                Estado = @Estado
                -- No actualizamos UsuarioCreador ni FechaRegistro
            WHERE IdHabitacion = @IdHabitacion;
                ";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@IdHabitacion", habitacion.IdHabitacion); // Para el WHERE
                comando.Parameters.AddWithValue("@IdTipoHabitacion", habitacion.IdTipoHabitacion);
                comando.Parameters.AddWithValue("@NroHabitacion", habitacion.NroHabitacion);
                comando.Parameters.AddWithValue("@NroPiso", habitacion.NroPiso);
                comando.Parameters.AddWithValue("@Estado", habitacion.Estado);

                return comando.ExecuteNonQuery();
            }
        }
    }
}
