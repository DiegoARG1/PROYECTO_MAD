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
    public class ReporteDAO
    {
        public static List<ReporteOcupacion> ObtenerReporteOcupacion(int anio, int? idHotel, string ciudad)
        {
            List<ReporteOcupacion> reporte = new List<ReporteOcupacion>();
            SqlConnection conexion = null;
            SqlDataReader reader = null;

            try
            {
                conexion = BDConexion.ObtenerConexion();
                if (conexion == null) throw new Exception("DB Connection failed.");

                string query = @"
                    -- Input Parameters
                    DECLARE @Anio INT = @AnioParam;
                    DECLARE @IdHotel INT = @IdHotelParam; -- Can be NULL for all hotels in city
                    DECLARE @Ciudad NVARCHAR(80) = @CiudadParam;

                    -- 1. Generate all months of the selected year
                    WITH MesesDelAnio AS (
                        SELECT 1 AS Mes UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL SELECT 4 UNION ALL
                        SELECT 5 UNION ALL SELECT 6 UNION ALL SELECT 7 UNION ALL SELECT 8 UNION ALL
                        SELECT 9 UNION ALL SELECT 10 UNION ALL SELECT 11 UNION ALL SELECT 12
                    ),
                    -- 2. Get all room types for the selected hotel(s)/city
                    TiposHabitacionHotel AS (
                        SELECT
                            T.IdTipoHabitacion, T.Nivel, HT.IdHotel, HT.Nombre AS NombreHotel, D.Ciudad,
                            (SELECT COUNT(*) FROM HABITACION H WHERE H.IdTipoHabitacion = T.IdTipoHabitacion) AS TotalHabitacionesFisicas
                        FROM TIPO_HABITACION T
                        INNER JOIN HOTEL HT ON T.IdHotel = HT.IdHotel
                        INNER JOIN DOMICILIO D ON HT.IdDomicilio = D.IdDomicilio
                        WHERE (@IdHotel IS NULL OR T.IdHotel = @IdHotel) -- Filter by Hotel if provided
                          AND D.Ciudad = @Ciudad -- Filter by City
                    ),
                    -- 3. Calculate booked nights per room type per month
                    NochesOcupadas AS (
                        SELECT
                            DR.IdTipoHabitacion,
                            YEAR(R.FechaEntrada) AS AnioReserva,
                            MONTH(R.FechaEntrada) AS MesReserva,
                            SUM(DATEDIFF(day, R.FechaEntrada, R.FechaSalida)) AS TotalNochesOcupadasMes,
                            SUM(DR.NroPersonas) AS TotalPersonasMes -- Sum people for this month/type
                        FROM DETALLE_RESERVACION DR
                        INNER JOIN RESERVACION R ON DR.IdReservacion = R.IdReservacion
                        INNER JOIN TiposHabitacionHotel TH ON DR.IdTipoHabitacion = TH.IdTipoHabitacion -- Join to filter by hotel/city implicitly
                        WHERE R.Estado IN ('Activa', 'En-Curso', 'Completada') -- Consider completed/active stays
                          AND YEAR(R.FechaEntrada) = @Anio -- Filter by Year
                          -- We simplify by attributing nights to the entry month for this report structure
                        GROUP BY DR.IdTipoHabitacion, YEAR(R.FechaEntrada), MONTH(R.FechaEntrada)
                    )
                    -- 4. Final Combination and Calculation
                    SELECT
                        T.Ciudad,
                        T.NombreHotel,
                        FORMAT(DATEFROMPARTS(@Anio, M.Mes, 1), 'yyyy-MM') AS AnioMes, -- Format as YYYY-MM
                        T.Nivel AS TipoHabitacion,
                        T.TotalHabitacionesFisicas AS CantidadHabitacionesTipo,
                        ISNULL(NO.TotalPersonasMes, 0) AS CantidadPersonasHospedadas,
                        -- Occupancy %: (Total Nights Booked / (Total Rooms * Days in Month)) * 100
                        CAST(
                            ISNULL(NO.TotalNochesOcupadasMes, 0) * 100.0 /
                            NULLIF(T.TotalHabitacionesFisicas * DAY(EOMONTH(DATEFROMPARTS(@Anio, M.Mes, 1))), 0) -- Avoid division by zero
                        AS DECIMAL(5, 2)) AS PorcentajeOcupacion
                    FROM TiposHabitacionHotel T
                    CROSS JOIN MesesDelAnio M -- Combine each room type with every month
                    LEFT JOIN NochesOcupadas NO ON T.IdTipoHabitacion = NO.IdTipoHabitacion
                                               AND NO.AnioReserva = @Anio
                                               AND NO.MesReserva = M.Mes -- Match occupancy data for the month
                    ORDER BY T.NombreHotel, AnioMes, T.Nivel;
                ";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@AnioParam", anio);
                // Handle NULLable IdHotel
                if (idHotel.HasValue)
                    comando.Parameters.AddWithValue("@IdHotelParam", idHotel.Value);
                else
                    comando.Parameters.AddWithValue("@IdHotelParam", DBNull.Value);
                comando.Parameters.AddWithValue("@CiudadParam", ciudad);

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ReporteOcupacion item = new ReporteOcupacion();
                    item.Ciudad = reader.GetString(reader.GetOrdinal("Ciudad"));
                    item.NombreHotel = reader.GetString(reader.GetOrdinal("NombreHotel"));
                    item.AnioMes = reader.GetString(reader.GetOrdinal("AnioMes"));
                    item.TipoHabitacion = reader.GetString(reader.GetOrdinal("TipoHabitacion"));
                    item.CantidadHabitacionesTipo = reader.GetInt32(reader.GetOrdinal("CantidadHabitacionesTipo"));
                    item.PorcentajeOcupacion = reader.IsDBNull(reader.GetOrdinal("PorcentajeOcupacion")) ? 0 : reader.GetDecimal(reader.GetOrdinal("PorcentajeOcupacion"));
                    item.CantidadPersonasHospedadas = reader.GetInt32(reader.GetOrdinal("CantidadPersonasHospedadas"));
                    reporte.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ReporteDAO.ObtenerReporteOcupacion: " + ex.ToString());
                throw;
            }
            finally
            {
                reader?.Close();
                conexion?.Close();
            }
            return reporte;
        }
    }
}
