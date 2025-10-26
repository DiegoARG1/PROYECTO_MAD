using PROYECTO_MAD.Entidad;
using PROYECTO_MAD.Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.DAO
{
    internal class HotelDAO
    {
        //public static List<Hotel> ObtenerHoteles()
        //{
        //    List<Hotel> lista = new List<Hotel>();
        //    using (SqlConnection conexion = BDConexion.ObtenerConexion())
        //    {
        //        // Query con JOIN para traer el domicilio también
        //        string query = @"
        //        SELECT * FROM HOTEL H
        //        LEFT JOIN DOMICILIO D ON H.IdDomicilio = D.IdDomicilio";

        //        SqlCommand comando = new SqlCommand(query, conexion);
        //        SqlDataReader reader = comando.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Hotel hotel = new Hotel();
        //            hotel.IdHotel = reader.GetInt32(reader.GetOrdinal("IdHotel"));
        //            hotel.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
        //            hotel.NroHabitaciones = reader.GetInt32(reader.GetOrdinal("NroHabitaciones"));
        //            hotel.NroPisos = reader.GetInt32(reader.GetOrdinal("NroPisos"));
        //            hotel.FechaInicioOperaciones = reader.GetDateTime(reader.GetOrdinal("FechaInicioOperaciones"));
        //            hotel.FechaRegistro = reader.GetDateTime(reader.GetOrdinal("FechaRegistro"));
        //            hotel.UsuarioCreador = reader.IsDBNull(reader.GetOrdinal("UsuarioCreador")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("UsuarioCreador"));

        //            // Carga el Domicilio (igual que en UsuarioDAO)
        //            if (!reader.IsDBNull(reader.GetOrdinal("IdDomicilio")))
        //            {
        //                hotel.oDomicilio = new Domicilio();
        //                hotel.oDomicilio.IdDomicilio = reader.GetInt32(reader.GetOrdinal("IdDomicilio"));
        //                hotel.oDomicilio.Pais = reader.GetString(reader.GetOrdinal("Pais"));
        //                hotel.oDomicilio.Estado = reader.GetString(reader.GetOrdinal("Estado"));
        //                hotel.oDomicilio.Ciudad = reader.GetString(reader.GetOrdinal("Ciudad"));
        //                hotel.oDomicilio.Calle = reader.GetString(reader.GetOrdinal("Calle"));
        //                hotel.oDomicilio.Numero = reader.GetString(reader.GetOrdinal("Numero"));
        //                hotel.oDomicilio.CodigoPostal = reader.GetString(reader.GetOrdinal("CodigoPostal"));
        //            }
        //            lista.Add(hotel);
        //        }
        //    }
        //    return lista;
        //}
        public static List<Hotel> ObtenerHoteles()
        {
            List<Hotel> lista = new List<Hotel>();
            SqlConnection conexion = null;
            SqlDataReader reader = null;

            try
            {
                conexion = BDConexion.ObtenerConexion();
                if (conexion == null)
                {
                    throw new Exception("No se pudo establecer la conexión a la base de datos.");
                }

                string query = @"
            SELECT
                H.IdHotel,
                H.Nombre,
                H.NroHabitaciones,
                H.NroPisos,
                H.FechaInicioOperaciones,
                H.FechaRegistro,
                H.UsuarioCreador,
                H.IdDomicilio,
                D.Pais,
                D.Estado AS EstadoDomicilio, -- Mantenemos el alias para evitar conflicto
                D.Ciudad,
                D.Calle,
                D.Numero,
                D.CodigoPostal
            FROM HOTEL H
            LEFT JOIN DOMICILIO D ON H.IdDomicilio = D.IdDomicilio
            -- WHERE H.Estado = 1; // Descomenta si añades borrado lógico
        ";

                SqlCommand comando = new SqlCommand(query, conexion);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Hotel hotel = new Hotel();
                    hotel.IdHotel = reader.GetInt32(reader.GetOrdinal("IdHotel"));
                    hotel.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                    hotel.NroHabitaciones = reader.GetInt32(reader.GetOrdinal("NroHabitaciones"));
                    hotel.NroPisos = reader.GetInt32(reader.GetOrdinal("NroPisos"));
                    hotel.FechaInicioOperaciones = reader.GetDateTime(reader.GetOrdinal("FechaInicioOperaciones"));
                    hotel.FechaRegistro = reader.GetDateTime(reader.GetOrdinal("FechaRegistro"));
                    hotel.UsuarioCreador = reader.IsDBNull(reader.GetOrdinal("UsuarioCreador")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("UsuarioCreador"));

                    if (!reader.IsDBNull(reader.GetOrdinal("IdDomicilio")))
                    {
                        hotel.oDomicilioH = new Domicilio();
                        hotel.oDomicilioH.IdDomicilio = reader.GetInt32(reader.GetOrdinal("IdDomicilio"));

                        int colPais = reader.GetOrdinal("Pais");
                        hotel.oDomicilioH.Pais = reader.IsDBNull(colPais) ? null : reader.GetString(colPais);

                        int colEstado = reader.GetOrdinal("EstadoDomicilio"); // Usamos el alias
                        hotel.oDomicilioH.Estado = reader.IsDBNull(colEstado) ? null : reader.GetString(colEstado);

                        int colCiudad = reader.GetOrdinal("Ciudad");
                        hotel.oDomicilioH.Ciudad = reader.IsDBNull(colCiudad) ? null : reader.GetString(colCiudad);

                        int colCalle = reader.GetOrdinal("Calle");
                        hotel.oDomicilioH.Calle = reader.IsDBNull(colCalle) ? null : reader.GetString(colCalle);

                        int colNumero = reader.GetOrdinal("Numero");
                        hotel.oDomicilioH.Numero = reader.IsDBNull(colNumero) ? null : reader.GetString(colNumero);

                        int colCP = reader.GetOrdinal("CodigoPostal");
                        hotel.oDomicilioH.CodigoPostal = reader.IsDBNull(colCP) ? null : reader.GetString(colCP);
                    }
                    lista.Add(hotel);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error en HotelDAO.ObtenerHoteles: " + ex.ToString());
                throw;
            }
            finally
            {
                //cerrar el reader y la conexión SIEMPRE
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return lista;
        }
        public static int InsertarHotel(Hotel hotel, int? idDomicilio, int idUsuarioCreador)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = @"
                INSERT INTO HOTEL (Nombre, IdDomicilio, NroHabitaciones, NroPisos, FechaInicioOperaciones, UsuarioCreador)
                VALUES (@Nombre, @IdDomicilio, @NroHabitaciones, @NroPisos, @FechaInicioOperaciones, @UsuarioCreador);
            ";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Nombre", hotel.Nombre);

                // Maneja el IdDomicilio (puede ser null)
                if (idDomicilio.HasValue)
                {
                    comando.Parameters.AddWithValue("@IdDomicilio", idDomicilio.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@IdDomicilio", DBNull.Value);
                }

                comando.Parameters.AddWithValue("@NroHabitaciones", hotel.NroHabitaciones);
                comando.Parameters.AddWithValue("@NroPisos", hotel.NroPisos);
                comando.Parameters.AddWithValue("@FechaInicioOperaciones", hotel.FechaInicioOperaciones);
                comando.Parameters.AddWithValue("@UsuarioCreador", idUsuarioCreador);

                return comando.ExecuteNonQuery();
            }
        }
        public static int ActualizarHotel(Hotel hotel, int? idDomicilio)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = @"
                UPDATE HOTEL SET
                    Nombre = @Nombre,
                    IdDomicilio = @IdDomicilio,
                    NroHabitaciones = @NroHabitaciones,
                    NroPisos = @NroPisos,
                    FechaInicioOperaciones = @FechaInicioOperaciones
                WHERE IdHotel = @IdHotel;
            ";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@IdHotel", hotel.IdHotel);
                comando.Parameters.AddWithValue("@Nombre", hotel.Nombre);

                if (idDomicilio.HasValue)
                {
                    comando.Parameters.AddWithValue("@IdDomicilio", idDomicilio.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@IdDomicilio", DBNull.Value);
                }

                comando.Parameters.AddWithValue("@NroHabitaciones", hotel.NroHabitaciones);
                comando.Parameters.AddWithValue("@NroPisos", hotel.NroPisos);
                comando.Parameters.AddWithValue("@FechaInicioOperaciones", hotel.FechaInicioOperaciones);

                return comando.ExecuteNonQuery();
            }
        }
    }
}
