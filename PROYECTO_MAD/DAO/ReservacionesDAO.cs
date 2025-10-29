using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_MAD.Entidad;
using System.Data;
using System.Data.SqlClient;
    
namespace PROYECTO_MAD.DAO
{
    public class ReservacionesDAO
    {
        // --- METODO PRINCIPAL PARA INSERTAR RESERVACION Y SUS DETALLES (CON TRANSACCION) ---
        public static Guid InsertarReservacionCompleta(Reservacion reservacion, List<DetalleReservacion> detalles, int idUsuarioLogueado)
        {
            // Variable para guardar el GUID generado
            Guid nuevoGuid = Guid.Empty;
            SqlConnection conexion = null;
            SqlTransaction transaction = null;

            try
            {
                conexion = BDConexion.ObtenerConexion();
                if (conexion == null) throw new Exception("No se pudo conectar a la BD.");

                // Transaccion
                // IsolationLevel.ReadCommitted es un nivel estandar que evita lecturas "sucias"
                transaction = conexion.BeginTransaction(IsolationLevel.ReadCommitted);

                // Insertar el Encabezado (RESERVACION)
                string queryReservacion = @"
                    INSERT INTO RESERVACION
                        (IdCliente, IdHotel, FechaEntrada, FechaSalida, Anticipo, MetodoPago, Estado, UsuarioCreador)
                    OUTPUT INSERTED.IdReservacion -- Devuelve el GUID generado
                    VALUES
                        (@IdCliente, @IdHotel, @FechaEntrada, @FechaSalida, @Anticipo, @MetodoPago, 'Activa', @UsuarioCreador);
                ";
                SqlCommand cmdReservacion = new SqlCommand(queryReservacion, conexion, transaction); // Asocia con la transaccion

                cmdReservacion.Parameters.AddWithValue("@IdCliente", reservacion.IdCliente);
                cmdReservacion.Parameters.AddWithValue("@IdHotel", reservacion.IdHotel);
                cmdReservacion.Parameters.AddWithValue("@FechaEntrada", reservacion.FechaEntrada);
                cmdReservacion.Parameters.AddWithValue("@FechaSalida", reservacion.FechaSalida);
                cmdReservacion.Parameters.AddWithValue("@Anticipo", reservacion.Anticipo);
                cmdReservacion.Parameters.AddWithValue("@MetodoPago", reservacion.MetodoPago);
                cmdReservacion.Parameters.AddWithValue("@UsuarioCreador", idUsuarioLogueado);

                // Ejecuta y obtiene el GUID devuelto
                nuevoGuid = (Guid)cmdReservacion.ExecuteScalar();

                if (nuevoGuid == Guid.Empty)
                {
                    // Si no se genero el GUID, algo salio mal
                    throw new Exception("No se pudo generar el ID de la reservación.");
                }

                // Insertar los Detalles (en la tabla: DETALLE_RESERVACION)
                string queryDetalle = @"
                    INSERT INTO DETALLE_RESERVACION
                        (IdReservacion, IdTipoHabitacion, NroPersonas, PrecioNoche)
                    VALUES
                        (@IdReservacion, @IdTipoHabitacion, @NroPersonas, @PrecioNoche);
                ";
                foreach (DetalleReservacion detalle in detalles)
                {
                    SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conexion, transaction); // Asocia con la transacción

                    cmdDetalle.Parameters.AddWithValue("@IdReservacion", nuevoGuid); // Usa el GUID recien generado
                    cmdDetalle.Parameters.AddWithValue("@IdTipoHabitacion", detalle.IdTipoHabitacion);
                    cmdDetalle.Parameters.AddWithValue("@NroPersonas", detalle.NroPersonas);
                    cmdDetalle.Parameters.AddWithValue("@PrecioNoche", detalle.PrecioNoche);

                    cmdDetalle.ExecuteNonQuery(); // Ejecuta el INSERT para este detalle
                }

                // Si todo salio bien, confirma la transaccion
                transaction.Commit();

            }
            catch (Exception ex)
            {
                // Si algo falla se revierte la transaccion
                try
                {
                    transaction?.Rollback(); // El '?' evita error si transacccion es null
                }
                catch (Exception rollbackEx)
                {
                    // maneja el error del rollback
                    Console.WriteLine("Error durante el Rollback: " + rollbackEx.Message);
                }

                // Loggear o relanzar la excepcion original
                Console.WriteLine("Error en ReservacionDAO.InsertarReservacionCompleta: " + ex.ToString());
                throw new Exception("Error al guardar la reservación: " + ex.Message, ex);
            }
            finally
            {
                conexion?.Close();
            }

            // Devuelve el GUID generado si todo fue exitoso
            return nuevoGuid;
        }
    }
}
