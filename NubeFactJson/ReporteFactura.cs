using System;
using System.Data.SqlClient;
using ConsoleTables;

namespace NubeFactJson
{
    public class ReporteFactura
    {
        public const string NO_ENVIADO = "False";
        public const string ENVIADO = "True"; 
        public const string TODOS = "Todos";
        public String fecha { get; set; }

        public void reporte(String estado) {
            SqlConnection conSqlServer = new Connection().initSqlServer();
            if (fecha == null) {
                Console.WriteLine("La fecha debe contener un valor");
                return;
            }
            try
            {
                conSqlServer.Open();
                SqlCommand sqlCmd = new SqlCommand("select * from v_peru_facturas_reporte " +
                                                   "where fecha = @fecha " +
                                                   "and (estado = @estado or 'Todos' = @estado) " +
                                                   "order by serie, numero asc",
                                                   conSqlServer);
                
                sqlCmd.Parameters.AddWithValue("@fecha", this.fecha);
                sqlCmd.Parameters.AddWithValue("@estado", estado);

                SqlDataReader sqlRead = sqlCmd.ExecuteReader();

                var table = new ConsoleTable("Comprobante", 
                                             "Serie", 
                                             "#", 
                                             //"Documento", 
                                             //"Denominación",
                                             "Subtotal",
                                             "IGV",
                                             "Total",
                                             "Estado", 
                                             "Observación");

                while (sqlRead.Read())
                {
                    table.AddRow(sqlRead["tipo"], 
                                 sqlRead["serie"],
                                 sqlRead["numero"],
                                 //sqlRead["numero_documento"],
                                 //sqlRead["denominacion"],
                                 sqlRead["total_gravada"],
                                 sqlRead["total_igv"],
                                 sqlRead["total"],
                                 sqlRead["estado"],
                                 sqlRead["observacion"]);
                }

                table.Write();

                sqlRead.Close();
                conSqlServer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en el reporte de  facturas" + ex.ToString());
            }
        }
    }
}
