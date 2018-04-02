using System;
using System.Data;
using System.Data.SqlClient;

namespace NubeFactJson
{
    public class ReporteFactura
    {
        public const string NO_ENVIADO = "False";
        public const string ENVIADO = "True"; 
        public const string TODOS = "Todos";
        public DateTime Fecha { get; set; }

        public DataTable Reporte(String estado) {
            var conSqlServer = new Connection().initSqlServer();
            var dtReporte = new DataTable("Reporte");

            if (Fecha == null) {
                Console.WriteLine("La fecha debe contener un valor");
                return null;
            }
            try
            {
                conSqlServer.Open();
                SqlCommand sqlCmd = new SqlCommand("select * from v_peru_facturas_reporte " +
                                                   "where cast(fecha as Date) = cast(@fecha as Date) " +
                                                   "and (estado = @estado or 'Todos' = @estado) " +
                                                   "order by serie, numero asc",
                                                   conSqlServer);
                
                sqlCmd.Parameters.AddWithValue("@fecha", this.Fecha);
                sqlCmd.Parameters.AddWithValue("@estado", estado);

                using (SqlDataReader sqlRead = sqlCmd.ExecuteReader())
                {
                    dtReporte.Load(sqlRead);
                    sqlRead.Close();
                }
                
                conSqlServer.Close();
                return dtReporte;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en el reporte de  facturas" + ex.ToString());
                return null;
            }            
        }
    }
}
