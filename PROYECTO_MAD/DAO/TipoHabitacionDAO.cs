using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_MAD.Entidad;
using System.Data.SqlClient;

namespace PROYECTO_MAD.DAO
{
    public class TipoHabitacionDAO
    {
        public static List<TipoHabitacion> ObtenerTiposPorHotel(int idHotel)
        {
            List<TipoHabitacion> lista = new List<TipoHabitacion>();
            SqlConnection conexion = null;
            SqlDataReader reader = null;

            try
            {
                conexion = BDConexion.ObtenerConexion();
                if (conexion == null) throw new Exception("No se pudo conectar a la BD.");

                // Consulta que une TIPO_HABITACION con HOTEL para obtener el nombre del hotel
                string query = @"
                    SELECT
                        T.IdTipoHabitacion, T.IdHotel, T.Nivel, T.NroCamas, T.TipoCamas,
                        T.Capacidad, T.PrecioNoche, T.FechaRegistro, T.UsuarioCreador,
                        H.Nombre AS NombreHotel --Traemos el nombre del hotel
                    FROM TIPO_HABITACION T
                    INNER JOIN HOTEL H ON T.IdHotel = H.IdHotel
                    WHERE T.IdHotel = @IdHotel --Filtramos el hotel seleccionado
                    ORDER BY T.Nivel;
                ";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdHotel", idHotel);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    TipoHabitacion tipo = new TipoHabitacion();
                    tipo.IdTipoHabitacion = reader.GetInt32(reader.GetOrdinal("IdTipoHabitacion"));
                    tipo.IdHotel = reader.GetInt32(reader.GetOrdinal("IdHotel"));
                    tipo.Nivel = reader.GetString(reader.GetOrdinal("Nivel"));
                    tipo.NroCamas = reader.GetInt32(reader.GetOrdinal("NroCamas"));
                    tipo.TipoCamas = reader.GetString(reader.GetOrdinal("TipoCamas"));
                    tipo.Capacidad = reader.GetInt32(reader.GetOrdinal("Capacidad"));
                    tipo.PrecioNoche = reader.GetDecimal(reader.GetOrdinal("PrecioNoche"));
                    tipo.FechaRegistro = reader.GetDateTime(reader.GetOrdinal("FechaRegistro"));
                    tipo.UsuarioCreador = reader.IsDBNull(reader.GetOrdinal("UsuarioCreador")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("UsuarioCreador"));
                    tipo.NombreHotel = reader.GetString(reader.GetOrdinal("NombreHotel"));

                    // Aquí NO cargamos las amenidades todavía para mantener la consulta rápida
                    lista.Add(tipo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en TipoHabitacionDAO.ObtenerTiposPorHotel: " + ex.ToString());
                throw;
            }
            finally
            {
                reader?.Close();
                conexion?.Close();
            }
            return lista;
        }
        public static int InsertarTipoHabitacion(TipoHabitacion tipo, int idUsuarioCreador)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                // El query inserta el tipo de habitacion y retorna el id creado
                string query = @"
                INSERT INTO TIPO_HABITACION
                (IdHotel, Nivel, NroCamas, TipoCamas, Capacidad, PrecioNoche, UsuarioCreador)
                OUTPUT INSERTED.IdTipoHabitacion -- Returns the new ID
                VALUES
                (@IdHotel, @Nivel, @NroCamas, @TipoCamas, @Capacidad, @PrecioNoche, @UsuarioCreador);
                ";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@IdHotel", tipo.IdHotel);
                comando.Parameters.AddWithValue("@Nivel", tipo.Nivel);
                comando.Parameters.AddWithValue("@NroCamas", tipo.NroCamas);
                comando.Parameters.AddWithValue("@TipoCamas", tipo.TipoCamas);
                comando.Parameters.AddWithValue("@Capacidad", tipo.Capacidad);
                comando.Parameters.AddWithValue("@PrecioNoche", tipo.PrecioNoche);
                comando.Parameters.AddWithValue("@UsuarioCreador", idUsuarioCreador);

                // ExecuteScalar toma el id que se retorna
                int nuevoId = (int)comando.ExecuteScalar();
                return nuevoId;
            }
        }
        public static void GuardarAmenidadesParaTipo(int idTipoHabitacion, List<int> idsAmenidades)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                //Borrar amenidades existentes para ese tipo
                string queryDelete = "DELETE FROM TIPO_HABITACION_AMENIDAD WHERE IdTipoHabitacion = @IdTipoHabitacion;";
                SqlCommand cmdDelete = new SqlCommand(queryDelete, conexion);
                cmdDelete.Parameters.AddWithValue("@IdTipoHabitacion", idTipoHabitacion);
                cmdDelete.ExecuteNonQuery();

                //Insertar las nuevas amenidades seleccionadas
                if (idsAmenidades != null && idsAmenidades.Count > 0)
                {
                    string queryInsert = "INSERT INTO TIPO_HABITACION_AMENIDAD (IdTipoHabitacion, IdAmenidad) VALUES (@IdTipoHabitacion, @IdAmenidad);";
                    foreach (int idAmenidad in idsAmenidades)
                    {
                        SqlCommand cmdInsert = new SqlCommand(queryInsert, conexion);
                        cmdInsert.Parameters.AddWithValue("@IdTipoHabitacion", idTipoHabitacion);
                        cmdInsert.Parameters.AddWithValue("@IdAmenidad", idAmenidad);
                        cmdInsert.ExecuteNonQuery();
                    }
                }
            }
        }
        public static int ActualizarTipoHabitacion(TipoHabitacion tipo)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = @"
            UPDATE TIPO_HABITACION SET
                IdHotel = @IdHotel,
                Nivel = @Nivel,
                NroCamas = @NroCamas,
                TipoCamas = @TipoCamas,
                Capacidad = @Capacidad,
                PrecioNoche = @PrecioNoche
                -- We don't update UsuarioCreador or FechaRegistro here
            WHERE IdTipoHabitacion = @IdTipoHabitacion;
        ";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Parameters
                comando.Parameters.AddWithValue("@IdTipoHabitacion", tipo.IdTipoHabitacion);
                comando.Parameters.AddWithValue("@IdHotel", tipo.IdHotel);
                comando.Parameters.AddWithValue("@Nivel", tipo.Nivel);
                comando.Parameters.AddWithValue("@NroCamas", tipo.NroCamas);
                comando.Parameters.AddWithValue("@TipoCamas", tipo.TipoCamas);
                comando.Parameters.AddWithValue("@Capacidad", tipo.Capacidad);
                comando.Parameters.AddWithValue("@PrecioNoche", tipo.PrecioNoche);

                return comando.ExecuteNonQuery();
            }
        }
        public static List<int> ObtenerIdsAmenidadesPorTipo(int idTipoHabitacion)
        {
            List<int> ids = new List<int>();
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT IdAmenidad FROM TIPO_HABITACION_AMENIDAD WHERE IdTipoHabitacion = @IdTipoHabitacion;";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdTipoHabitacion", idTipoHabitacion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    ids.Add(reader.GetInt32(0));
                }
            }
            return ids;
        }
    }
}
