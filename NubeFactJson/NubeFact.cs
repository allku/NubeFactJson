using System;
using System.Data.SqlClient;

namespace NubeFactJson
{
    public class NubeFact
    {
        public String fecha { get; set; }

        public void enviar() {
            var conSqlServer = new Connection().initSqlServer();
            if (fecha == null)
            {
                Console.WriteLine("La fecha debe contener un valor");
                return;
            }
            try
            {
                conSqlServer.Open();
                SqlCommand sqlCmd = new SqlCommand("select tipo_comprobante, serie, numero from v_peru_facturas_reporte " +
                                                   "where fecha = @fecha " +
                                                   "and estado = 'False' " +
                                                   "order by serie, numero asc",
                                                   conSqlServer);

                sqlCmd.Parameters.AddWithValue("@fecha", this.fecha);

                SqlDataReader sqlRead = sqlCmd.ExecuteReader();

                var enviarFactura = new Enviar();

                while (sqlRead.Read())
                {

                    var generaFactura = new GeneraFactura(sqlRead["tipo_comprobante"].ToString(),
                                                          sqlRead["serie"].ToString(),
                                                          sqlRead["numero"].ToString());
                    
                    var factura = generaFactura.generaEnvio();
                    enviarFactura.factura(factura);

                }



                sqlRead.Close();
                conSqlServer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar las facturas para enviar" + ex.ToString());
            }
        }

        public void verificar() {
            var conSqlServer = new Connection().initSqlServer();
            if (fecha == null)
            {
                Console.WriteLine("La fecha debe contener un valor");
                return;
            }
            try
            {
                conSqlServer.Open();
                SqlCommand sqlCmd = new SqlCommand("select tipo_comprobante, serie, numero from v_peru_facturas_reporte " +
                                                   "where fecha = @fecha " +
                                                   "and estado = 'False' " +
                                                   "order by serie, numero asc",
                                                   conSqlServer);

                sqlCmd.Parameters.AddWithValue("@fecha", this.fecha);

                SqlDataReader sqlRead = sqlCmd.ExecuteReader();

                var enviarFactura = new Enviar();

                while (sqlRead.Read())
                {

                    var generaFacturaVerificacion = new GeneraFactura(sqlRead["tipo_comprobante"].ToString(),
                                                          sqlRead["serie"].ToString(),
                                                          sqlRead["numero"].ToString());

                    var factura = generaFacturaVerificacion.generaVerificar();
                    enviarFactura.facturaVerificacion(factura);

                }

                sqlRead.Close();
                conSqlServer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar las facturas para verificar" + ex.ToString());
            }        
        }
    }
}
