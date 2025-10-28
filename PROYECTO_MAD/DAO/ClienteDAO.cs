using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_MAD.Entidad;
using System.Data.SqlClient;

namespace PROYECTO_MAD.DAO
{
    public class ClienteDAO
    {
        public static List<Cliente> ObtenerClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            SqlConnection conexion = null;
            SqlDataReader reader = null;

            try
            {
                conexion = BDConexion.ObtenerConexion();
                if (conexion == null) throw new Exception("No se pudo conectar a la BD.");

                string query = @"
                    SELECT
                        C.IdCliente, C.Nombre, C.Apellidos, C.Rfc, C.Correo AS CorreoCliente,
                        C.Telefono, C.FechaNacimiento, C.EstadoCivil,
                        C.FechaRegistro, C.UsuarioCreador, C.IdDomicilio,
                        D.Pais, D.Estado AS EstadoDomicilio, D.Ciudad, D.Calle, D.Numero, D.CodigoPostal
                    FROM CLIENTE C
                    LEFT JOIN DOMICILIO D ON C.IdDomicilio = D.IdDomicilio
                    ORDER BY C.Apellidos, C.Nombre;
                    ";

                SqlCommand comando = new SqlCommand(query, conexion);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.IdCliente = reader.GetInt32(reader.GetOrdinal("IdCliente"));
                    cliente.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                    cliente.Apellidos = reader.GetString(reader.GetOrdinal("Apellidos"));
                    cliente.RFC = reader.GetString(reader.GetOrdinal("Rfc"));
                    cliente.CorreoElectronico = reader.GetString(reader.GetOrdinal("CorreoCliente"));
                    cliente.Telefono = reader.GetString(reader.GetOrdinal("Telefono"));
                    cliente.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
                    cliente.EstadoCivil = reader.GetString(reader.GetOrdinal("EstadoCivil"));
                    cliente.FechaRegistro = reader.GetDateTime(reader.GetOrdinal("FechaRegistro"));
                    cliente.UsuarioCreador = reader.IsDBNull(reader.GetOrdinal("UsuarioCreador")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("UsuarioCreador"));

                    if (!reader.IsDBNull(reader.GetOrdinal("IdDomicilio")))
                    {
                        cliente.oDomicilio = new Domicilio();
                        cliente.oDomicilio.IdDomicilio = reader.GetInt32(reader.GetOrdinal("IdDomicilio"));
                        cliente.oDomicilio.Pais = reader.GetString(reader.GetOrdinal("Pais"));
                        cliente.oDomicilio.Estado = reader.GetString(reader.GetOrdinal("EstadoDomicilio"));
                        cliente.oDomicilio.Ciudad = reader.GetString(reader.GetOrdinal("Ciudad"));
                        cliente.oDomicilio.Calle = reader.GetString(reader.GetOrdinal("Calle"));
                        cliente.oDomicilio.Numero = reader.GetString(reader.GetOrdinal("Numero"));
                        cliente.oDomicilio.CodigoPostal = reader.GetString(reader.GetOrdinal("CodigoPostal"));
                    }
                    lista.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ClienteDAO.ObtenerClientes: " + ex.ToString());
                throw;
            }
            finally
            {
                reader?.Close();
                conexion?.Close();
            }
            return lista;
        }
        public static int InsertarCliente(Cliente cliente, int idDomicilio, int idUsuarioCreador)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = @"
            INSERT INTO CLIENTE
                (Nombre, Apellidos, Correo, Rfc, EstadoCivil, FechaNacimiento, IdDomicilio, Telefono, UsuarioCreador)
            VALUES
                (@Nombre, @Apellidos, @Correo, @RFC, @EstadoCivil, @FechaNacimiento, @IdDomicilio, @Telefono, @UsuarioCreador);
        ";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                comando.Parameters.AddWithValue("@Correo", cliente.CorreoElectronico);
                comando.Parameters.AddWithValue("@RFC", cliente.RFC);
                comando.Parameters.AddWithValue("@EstadoCivil", cliente.EstadoCivil);
                comando.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                comando.Parameters.AddWithValue("@IdDomicilio", idDomicilio);
                comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("@UsuarioCreador", idUsuarioCreador);

                return comando.ExecuteNonQuery();
            }
        }
        public static bool ExisteCliente(string rfc, string correo)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM CLIENTE WHERE Rfc = @RFC OR Correo = @Correo;";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@RFC", rfc);
                comando.Parameters.AddWithValue("@Correo", correo);

                int count = (int)comando.ExecuteScalar();
                return (count > 0);
            }
        }
        public static int ActualizarCliente(Cliente cliente, int idDomicilio)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = @"
            UPDATE CLIENTE SET
                Nombre = @Nombre,
                Apellidos = @Apellidos,
                Correo = @Correo, -- Usa el alias correcto si lo definiste
                Rfc = @RFC,
                EstadoCivil = @EstadoCivil,
                FechaNacimiento = @FechaNacimiento,
                IdDomicilio = @IdDomicilio, -- Siempre habrá uno
                Telefono = @Telefono
                -- No actualizamos UsuarioCreador ni FechaRegistro
            WHERE IdCliente = @IdCliente;
                ";

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                comando.Parameters.AddWithValue("@Correo", cliente.CorreoElectronico);
                comando.Parameters.AddWithValue("@RFC", cliente.RFC);
                comando.Parameters.AddWithValue("@EstadoCivil", cliente.EstadoCivil);
                comando.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                comando.Parameters.AddWithValue("@IdDomicilio", idDomicilio);
                comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);

                return comando.ExecuteNonQuery();
            }
        }
        public static List<Cliente> BuscarClientes(string criterio, string valor)
        {
            List<Cliente> lista = new List<Cliente>();
            SqlConnection conexion = null;
            SqlDataReader reader = null;

            try
            {
                conexion = BDConexion.ObtenerConexion();
                if (conexion == null) throw new Exception("No se pudo conectar a la BD.");

                string query = @"
            SELECT
                C.IdCliente, C.Nombre, C.Apellidos, C.Rfc, C.Correo AS CorreoCliente,
                C.Telefono, C.FechaNacimiento, C.EstadoCivil,
                C.FechaRegistro, C.UsuarioCreador, C.IdDomicilio,
                D.Pais, D.Estado AS EstadoDomicilio, D.Ciudad, D.Calle, D.Numero, D.CodigoPostal
            FROM CLIENTE C
            LEFT JOIN DOMICILIO D ON C.IdDomicilio = D.IdDomicilio
            WHERE ";

                // Construye el WHERE dinamicamente segun el criterio
                switch (criterio.ToLower())
                {
                    case "apellidos":
                        query += " C.Apellidos LIKE @Valor + '%' ";
                        break;
                    case "rfc":
                        query += " C.Rfc = @Valor ";
                        break;
                    case "correo electronico":
                        query += " C.Correo = @Valor ";
                        break;
                    default:
                        throw new ArgumentException("Criterio de búsqueda no válido.");
                }

                query += " ORDER BY C.Apellidos, C.Nombre;";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Valor", valor);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = reader.GetInt32(reader.GetOrdinal("IdCliente"));
                    cliente.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                    cliente.Apellidos = reader.GetString(reader.GetOrdinal("Apellidos"));
                    cliente.RFC = reader.GetString(reader.GetOrdinal("Rfc"));
                    cliente.CorreoElectronico = reader.GetString(reader.GetOrdinal("CorreoCliente"));
                    cliente.Telefono = reader.GetString(reader.GetOrdinal("Telefono"));
                    cliente.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
                    cliente.EstadoCivil = reader.GetString(reader.GetOrdinal("EstadoCivil"));
                    cliente.FechaRegistro = reader.GetDateTime(reader.GetOrdinal("FechaRegistro"));
                    cliente.UsuarioCreador = reader.IsDBNull(reader.GetOrdinal("UsuarioCreador")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("UsuarioCreador"));
                    if (!reader.IsDBNull(reader.GetOrdinal("IdDomicilio")))

                    if (!reader.IsDBNull(reader.GetOrdinal("IdDomicilio")))
                    {
                        cliente.oDomicilio = new Domicilio();
                        cliente.oDomicilio.IdDomicilio = reader.GetInt32(reader.GetOrdinal("IdDomicilio"));
                        cliente.oDomicilio.Pais = reader.GetString(reader.GetOrdinal("Pais"));
                        cliente.oDomicilio.Estado = reader.GetString(reader.GetOrdinal("EstadoDomicilio"));
                        cliente.oDomicilio.Ciudad = reader.GetString(reader.GetOrdinal("Ciudad"));
                        cliente.oDomicilio.Calle = reader.GetString(reader.GetOrdinal("Calle"));
                        cliente.oDomicilio.Numero = reader.GetString(reader.GetOrdinal("Numero"));
                        cliente.oDomicilio.CodigoPostal = reader.GetString(reader.GetOrdinal("CodigoPostal"));
                    }
                    lista.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ClienteDAO.BuscarClientes: " + ex.ToString());
                throw;
            }
            finally
            {
                reader?.Close();
                conexion?.Close();
            }
            return lista;
        }
    }
}
