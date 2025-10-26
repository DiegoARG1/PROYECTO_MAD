using PROYECTO_MAD.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.DAO
{
    internal class DomicilioDAO
    {
        public static int GuardarDomicilio(Domicilio domicilio) //Esta funcion puede usarse tanto en el caso de estar editando un usuario asi como cuando creamos un usuario nuevo
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                SqlCommand comando;

                // Decide si es INSERT (IdDomicilio <= 0) o UPDATE (IdDomicilio > 0)
                if (domicilio.IdDomicilio <= 0)
                {
                    // --- INSERT ---
                    string queryInsert = @"
                        INSERT INTO DOMICILIO (Pais, Estado, Ciudad, Calle, Numero, CodigoPostal)
                        OUTPUT INSERTED.IdDomicilio -- ¡Devuelve el ID recién creado!
                        VALUES (@Pais, @Estado, @Ciudad, @Calle, @Numero, @CodigoPostal);
                    ";
                    comando = new SqlCommand(queryInsert, conexion);
                }
                else
                {
                    // --- UPDATE ---
                    string queryUpdate = @"
                        UPDATE DOMICILIO SET
                            Pais = @Pais, Estado = @Estado, Ciudad = @Ciudad,
                            Calle = @Calle, Numero = @Numero, CodigoPostal = @CodigoPostal
                        WHERE IdDomicilio = @IdDomicilio;
                    ";
                    comando = new SqlCommand(queryUpdate, conexion);
                    comando.Parameters.AddWithValue("@IdDomicilio", domicilio.IdDomicilio);
                }

                // Parametros
                comando.Parameters.AddWithValue("@Pais", domicilio.Pais);
                comando.Parameters.AddWithValue("@Estado", domicilio.Estado);
                comando.Parameters.AddWithValue("@Ciudad", domicilio.Ciudad);
                comando.Parameters.AddWithValue("@Calle", domicilio.Calle);
                comando.Parameters.AddWithValue("@Numero", domicilio.Numero);
                comando.Parameters.AddWithValue("@CodigoPostal", domicilio.CodigoPostal);

                if (domicilio.IdDomicilio <= 0)
                {
                    // ExecuteScalar devuelve el OUTPUT INSERTED.IdDomicilio
                    return (int)comando.ExecuteScalar();
                }
                else
                {
                    comando.ExecuteNonQuery();
                    return domicilio.IdDomicilio; // Devuelve el mismo ID que se actualizó
                }
            }
        }
    }
}
