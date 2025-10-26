using PROYECTO_MAD.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.DAO
{
    public class UsuarioDAO
    {
        public static bool ExisteUsuario(string correo, string numeroNomina)
        {
            bool existe = false;
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                // Busca si ya hay un usuario con ese correo O esa nómina
                string query = "SELECT COUNT(*) FROM USUARIO WHERE (Correo = @Correo OR NumeroNomina = @NumeroNomina) AND Estado = 1;";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Correo", correo);
                comando.Parameters.AddWithValue("@NumeroNomina", numeroNomina);

                // ExecuteScalar devuelve el primer valor de la primera fila (el conteo)
                int count = (int)comando.ExecuteScalar();

                if (count > 0)
                {
                    existe = true;
                }
            }
            return existe;
        }
        public static int ActualizarUsuario(Usuario usuario, int? idDomicilio)
        {
            int filasAfectadas = 0;
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = @"
                UPDATE USUARIO SET 
                Nombre = @Nombre, 
                Apellidos = @Apellidos, 
                Correo = @Correo,
                NumeroNomina = @NumeroNomina, 
                FechaNacimiento = @FechaNacimiento, 
                IdDomicilio = @IdDomicilio, 
                Telefono = @Telefono, 
                IdRol = @IdRol
                WHERE IdUsuario = @IdUsuario;
                ";

                SqlCommand comando = new SqlCommand(query, conexion);

                //parametros
                comando.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                comando.Parameters.AddWithValue("@Correo", usuario.Correo);
                comando.Parameters.AddWithValue("@NumeroNomina", usuario.NumeroNomina);
                comando.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);

                
                if (idDomicilio.HasValue)
                {
                    comando.Parameters.AddWithValue("@IdDomicilio", idDomicilio.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@IdDomicilio", DBNull.Value);
                }

                comando.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                comando.Parameters.AddWithValue("@IdRol", usuario.oRol.IdRol);

                filasAfectadas = comando.ExecuteNonQuery();
            }
            return filasAfectadas;
        }
        public static int InsertarUsuario(Usuario usuario, int? idDomicilio, int idUsuarioCreador) 
        {
            int filasAfectadas = 0;
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = @"
                            INSERT INTO USUARIO (Nombre, Apellidos, Correo, Contrasenia, NumeroNomina, FechaNacimiento, IdDomicilio, Telefono, IdRol, UsuarioCreador, Estado) 
                            VALUES (@Nombre, @Apellidos, @Correo, @Contrasenia, @NumeroNomina, @FechaNacimiento, @IdDomicilio, @Telefono, @IdRol, @UsuarioCreador, 1);
                            -- Estado=1 (Activo) por defecto";

                SqlCommand comando = new SqlCommand(query, conexion);

                //parámetros
                comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                comando.Parameters.AddWithValue("@Correo", usuario.Correo);
                comando.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia);
                comando.Parameters.AddWithValue("@NumeroNomina", usuario.NumeroNomina);
                comando.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);

                // Maneja el caso de que el domicilio no se haya ingresado
                if (idDomicilio.HasValue)
                {
                    comando.Parameters.AddWithValue("@IdDomicilio", idDomicilio.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@IdDomicilio", DBNull.Value);
                }

                comando.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                comando.Parameters.AddWithValue("@IdRol", usuario.oRol.IdRol);
                comando.Parameters.AddWithValue("@UsuarioCreador", idUsuarioCreador);

                filasAfectadas = comando.ExecuteNonQuery();
            }

            return filasAfectadas; // Devuelve cuantas filas se insertaron (debería ser 1)

        }
        public static  List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT U.IdUsuario, U.Nombre, U.Apellidos, U.Correo, U.NumeroNomina, " +
                    "U.FechaNacimiento, U.Telefono, U.FechaRegistro, U.UsuarioCreador, " +
                    "U.IdRol, U.IdDomicilio, U.Estado AS EstadoUsuario, D.Pais, D.Estado AS EstadoDomicilio, " +
                    "D.Ciudad, D.Calle, D.Numero, D.CodigoPostal, R.Descripcion FROM USUARIO U LEFT JOIN " +
                    "DOMICILIO D ON U.IdDomicilio = D.IdDomicilio INNER JOIN ROL R ON U.IdRol = R.IdRol WHERE U.Estado = 1";

                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario"));
                    usuario.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                    usuario.Apellidos = reader.GetString(reader.GetOrdinal("Apellidos"));
                    usuario.Correo = reader.GetString(reader.GetOrdinal("Correo"));
                    usuario.NumeroNomina = reader.GetString(reader.GetOrdinal("NumeroNomina"));
                    usuario.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
                    usuario.Telefono = reader.GetString(reader.GetOrdinal("Telefono"));
                    usuario.FechaRegistro = reader.GetDateTime(reader.GetOrdinal("FechaRegistro"));
                    usuario.Estado = reader.GetBoolean(reader.GetOrdinal("EstadoUsuario"));

                    usuario.oRol = new Rol()
                    {
                        IdRol = reader.GetInt32(reader.GetOrdinal("IdRol")),
                        Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"))
                    };

                    if (!reader.IsDBNull(reader.GetOrdinal("IdDomicilio")))
                    {
                        usuario.oDomicilio = new Domicilio();
                        usuario.oDomicilio.IdDomicilio = reader.GetInt32(reader.GetOrdinal("IdDomicilio"));
                        usuario.oDomicilio.Pais = reader.GetString(reader.GetOrdinal("Pais"));
                        usuario.oDomicilio.Estado = reader.GetString(reader.GetOrdinal("EstadoDomicilio"));
                        usuario.oDomicilio.Ciudad = reader.GetString(reader.GetOrdinal("Ciudad"));
                        usuario.oDomicilio.Calle = reader.GetString(reader.GetOrdinal("Calle"));
                        usuario.oDomicilio.Numero = reader.GetString(reader.GetOrdinal("Numero"));
                        usuario.oDomicilio.CodigoPostal = reader.GetString(reader.GetOrdinal("CodigoPostal"));
                    }

                    int ordinal = reader.GetOrdinal("UsuarioCreador");
                    if (!reader.IsDBNull(ordinal))
                    {
                        usuario.UsuarioCreador = reader.GetInt32(ordinal);
                    }
                    else
                    {
                        usuario.UsuarioCreador = null;
                    }
                    lista.Add(usuario);
                }

            }
            return lista;
        }
        public  static Usuario IniciarSesion(string correo, string contrasenia)
        {
            Usuario usuario = null;

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT U.IdUsuario, U.Nombre, U.Apellidos, U.Correo, U.NumeroNomina, U.FechaNacimiento, U.Telefono, U.FechaRegistro, " +
                               "U.UsuarioCreador, U.IdRol, U.IdDomicilio, U.Estado AS EstadoUsuario, D.Pais, D.Estado AS EstadoDomicilio, D.Ciudad, " +
                               "D.Calle, D.Numero, D.CodigoPostal, R.Descripcion FROM USUARIO U LEFT JOIN DOMICILIO D ON U.IdDomicilio = D.IdDomicilio " +
                               "INNER JOIN ROL R ON U.IdRol = R.IdRol WHERE U.Correo = @correo AND U.Contrasenia = @contrasenia AND U.Estado = 1";

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@contrasenia", contrasenia);

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario();
                    usuario.IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario"));
                    usuario.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                    usuario.Apellidos = reader.GetString(reader.GetOrdinal("Apellidos"));
                    usuario.Correo = reader.GetString(reader.GetOrdinal("Correo"));
                    usuario.NumeroNomina = reader.GetString(reader.GetOrdinal("NumeroNomina"));
                    usuario.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
                    usuario.Telefono = reader.GetString(reader.GetOrdinal("Telefono"));
                    usuario.FechaRegistro = reader.GetDateTime(reader.GetOrdinal("FechaRegistro"));
                    usuario.Estado = reader.GetBoolean(reader.GetOrdinal("EstadoUsuario"));

                    usuario.oRol = new Rol()
                    {
                        IdRol = reader.GetInt32(reader.GetOrdinal("IdRol"))

                    };

                    if (!reader.IsDBNull(reader.GetOrdinal("IdDomicilio")))
                    {
                        usuario.oDomicilio = new Domicilio();

                        usuario.oDomicilio.IdDomicilio = reader.GetInt32(reader.GetOrdinal("IdDomicilio"));
                        usuario.oDomicilio.Pais = reader.GetString(reader.GetOrdinal("Pais"));
                        usuario.oDomicilio.Estado = reader.GetString(reader.GetOrdinal("EstadoDomicilio"));
                        usuario.oDomicilio.Ciudad = reader.GetString(reader.GetOrdinal("Ciudad"));
                        usuario.oDomicilio.Calle = reader.GetString(reader.GetOrdinal("Calle"));
                        usuario.oDomicilio.Numero = reader.GetString(reader.GetOrdinal("Numero"));
                        usuario.oDomicilio.CodigoPostal = reader.GetString(reader.GetOrdinal("CodigoPostal"));
                    }
                }
            }

            return usuario;
        }
        public static int EliminarLogicoUsuario(int idUsuario)
        {
            int filasAfectadas = 0;
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "UPDATE USUARIO SET Estado = 0 WHERE IdUsuario = @IdUsuario;";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                filasAfectadas = comando.ExecuteNonQuery();
            }
            return filasAfectadas;
        }

    }
}
