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
        public static List<TipoHabitacion> BuscarDisponibilidad(string ciudad, DateTime fechaEntrada, DateTime fechaSalida)
        {
            List<TipoHabitacion> listaDisponibles = new List<TipoHabitacion>();
            SqlConnection conexion = null;
            SqlDataReader reader = null;

            try
            {
                conexion = BDConexion.ObtenerConexion();
                if (conexion == null) throw new Exception("No se pudo conectar a la BD.");

                // Consulta SQL para calcular disponibilidad
                // CTEs (Common Table Expressions) para organizar la lógica
                string query = @"
                -- Parámetros de entrada
                DECLARE @CiudadParam NVARCHAR(80) = @Ciudad;
                DECLARE @FechaEntradaParam DATE = @FechaEntrada;
                DECLARE @FechaSalidaParam DATE = @FechaSalida;

                -- CTE 1: Todas las habitaciones físicas del hotel/ciudad con su tipo
                WITH HabitacionesHotel AS (
                    SELECT
                        H.IdHabitacion,
                        T.IdTipoHabitacion,
                        T.Nivel,
                        T.Capacidad,
                        T.PrecioNoche,
                        HT.Nombre AS NombreHotel
                    FROM HABITACION H
                    INNER JOIN TIPO_HABITACION T ON H.IdTipoHabitacion = T.IdTipoHabitacion
                    INNER JOIN HOTEL HT ON T.IdHotel = HT.IdHotel
                    INNER JOIN DOMICILIO D ON HT.IdDomicilio = D.IdDomicilio
                    WHERE D.Ciudad = @CiudadParam AND H.Estado = 'Disponible' -- Considera habitaciones fisicas disponibles
                ),
                -- CTE 2: Habitaciones OCUPADAS en el rango de fechas
                HabitacionesOcupadas AS (
                    SELECT
                        DR.IdHabitacion -- La habitación física ocupada
                    FROM DETALLE_RESERVACION DR
                    INNER JOIN RESERVACION R ON DR.IdReservacion = R.IdReservacion
                    WHERE
                        DR.IdHabitacion IS NOT NULL -- Solo si ya se asignó una física
                        AND R.Estado = 'Activa' -- Solo reservas activas
                        -- Condición de cruce de fechas: NuevaEntrada < ViejaSalida Y NuevaSalida > ViejaEntrada
                        AND R.FechaEntrada < @FechaSalidaParam
                        AND R.FechaSalida > @FechaEntradaParam
                )
                -- Consulta Final: Agrupa por tipo, cuenta total vs ocupadas y filtra
                SELECT
                    TH.IdTipoHabitacion,
                    TH.Nivel,
                    TH.Capacidad,
                    TH.PrecioNoche,
                    TH.NombreHotel,
                    COUNT(TH.IdHabitacion) AS TotalHabitacionesTipo,
                    COUNT(HO.IdHabitacion) AS OcupadasEnFechas,
                    (COUNT(TH.IdHabitacion) - COUNT(HO.IdHabitacion)) AS Disponibles
                FROM HabitacionesHotel TH
                LEFT JOIN HabitacionesOcupadas HO ON TH.IdHabitacion = HO.IdHabitacion
                GROUP BY
                    TH.IdTipoHabitacion, TH.Nivel, TH.Capacidad, TH.PrecioNoche, TH.NombreHotel
                HAVING
                    (COUNT(TH.IdHabitacion) - COUNT(HO.IdHabitacion)) > 0 -- Solo muestra si hay al menos 1 disponible
                ORDER BY
                    TH.NombreHotel, TH.Nivel;
            ";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Ciudad", ciudad);
                comando.Parameters.AddWithValue("@FechaEntrada", fechaEntrada.Date); // Usa solo la fecha
                comando.Parameters.AddWithValue("@FechaSalida", fechaSalida.Date);   // Usa solo la fecha

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    TipoHabitacion tipo = new TipoHabitacion();
                    tipo.IdTipoHabitacion = reader.GetInt32(reader.GetOrdinal("IdTipoHabitacion"));
                    tipo.Nivel = reader.GetString(reader.GetOrdinal("Nivel"));
                    tipo.Capacidad = reader.GetInt32(reader.GetOrdinal("Capacidad"));
                    tipo.PrecioNoche = reader.GetDecimal(reader.GetOrdinal("PrecioNoche"));
                    tipo.NombreHotel = reader.GetString(reader.GetOrdinal("NombreHotel"));
                    tipo.Disponibles = reader.GetInt32(reader.GetOrdinal("Disponibles")); // Lee el conteo calculado

                    listaDisponibles.Add(tipo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en TipoHabitacionDAO.BuscarDisponibilidad: " + ex.ToString());
                throw; // Relanza para que el formulario lo capture
            }
            finally
            {
                reader?.Close();
                conexion?.Close();
            }
            return listaDisponibles;
        }
    }
}
