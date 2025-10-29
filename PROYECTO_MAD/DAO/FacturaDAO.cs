using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_MAD.Entidad;
using System.Data.SqlClient;

namespace PROYECTO_MAD.DAO
{
    public class FacturaDAO
    {
        public static int InsertarFactura(Factura factura, SqlConnection conexion, SqlTransaction transaction)
        {
            string query = @"
                INSERT INTO FACTURAS
                    (IdReservacion, IdHotel, IdCliente, IdUsuario, TotalHospedaje, MontoAnticipo, MontoPendientePagado, FormaPago, Estatus)
                OUTPUT INSERTED.FacturaID -- Devuelve el ID autogenerado
                VALUES
                    (@IdReservacion, @IdHotel, @IdCliente, @IdUsuario, @TotalHospedaje, @MontoAnticipo, @MontoPendientePagado, @FormaPago, @Estatus);
                 ";
            SqlCommand comando = new SqlCommand(query, conexion, transaction);

            comando.Parameters.AddWithValue("@IdReservacion", factura.IdReservacion);
            comando.Parameters.AddWithValue("@IdHotel", factura.IdHotel);
            comando.Parameters.AddWithValue("@IdCliente", factura.IdCliente);
            comando.Parameters.AddWithValue("@IdUsuario", factura.IdUsuario); 
            comando.Parameters.AddWithValue("@TotalHospedaje", factura.TotalHospedaje);
            comando.Parameters.AddWithValue("@MontoAnticipo", factura.MontoAnticipo);
            comando.Parameters.AddWithValue("@MontoPendientePagado", factura.MontoPendientePagado);
            comando.Parameters.AddWithValue("@FormaPago", factura.FormaPago);
            comando.Parameters.AddWithValue("@Estatus", factura.Estatus);

            return (int)comando.ExecuteScalar();
        }
    }
}
