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
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public String Error { get; set; }

        public DataTable Reporte(String estado) {
            var conSqlServer = new Connection().initSqlServer();
            var dtReporte = new DataTable("Reporte");

            if (FechaInicio == null) {
                Error = "La fecha inicial debe contener un valor";
                return null;
            }
            if (FechaFin == null)
            {
                Error = "La fecha final debe contener un valor";
                return null;
            }
            try
            {
                conSqlServer.Open();
                SqlCommand sqlCmd = new SqlCommand("select * from v_peru_facturas_reporte " +
                                                   "where cast(fecha as Date) " +
                                                   "between cast(@fechaInicio as Date) and cast(@fechaFin as Date) " +
                                                   "and (estado = @estado or 'Todos' = @estado) " +
                                                   "order by serie, numero asc",
                                                   conSqlServer);
                
                sqlCmd.Parameters.AddWithValue("@fechaInicio", this.FechaInicio);
                sqlCmd.Parameters.AddWithValue("@fechaFin", this.FechaFin);
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
                Error = "Error en el reporte de  facturas " + ex.ToString();
                return null;
            }            
        }
    }
}
