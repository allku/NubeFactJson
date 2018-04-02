using System;
using System.Data.SqlClient;

namespace NubeFactJson
{
    public class NubeFact
    {
        public DateTime Fecha { get; set; }

        public string Enviar() {
            var conSqlServer = new Connection().initSqlServer();
            if (Fecha == null)
            {
                return "La fecha debe contener un valor";
            }
            try
            {
                conSqlServer.Open();
                SqlCommand sqlCmd = new SqlCommand("select tipo_comprobante, serie, numero from v_peru_facturas_reporte " +
                                                   "where cast(fecha as Date) = cast(@fecha as Date) " +
                                                   "and estado = 'False' " +
                                                   "order by serie, numero asc",
                                                   conSqlServer);

                sqlCmd.Parameters.AddWithValue("@fecha", this.Fecha);

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
                return "Error al enviar las facturas para enviar " + ex.ToString();
            }
            return "";
        }

        public string Verificar() {
            var conSqlServer = new Connection().initSqlServer();
            if (Fecha == null)
            {
                return "La fecha debe contener un valor";
            }
            try
            {
                conSqlServer.Open();
                SqlCommand sqlCmd = new SqlCommand("select tipo_comprobante, serie, numero from v_peru_facturas_reporte " +
                                                   "where cast(fecha as Date) = cast(@fecha as Date) " +
                                                   "and estado = @estado " +
                                                   "order by serie, numero asc",
                                                   conSqlServer);

                sqlCmd.Parameters.AddWithValue("@fecha", this.Fecha);
                sqlCmd.Parameters.AddWithValue("@estado", ReporteFactura.NO_ENVIADO);

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
                return "Error al listar las facturas para verificar" + ex.ToString();
            }        
            return "";
        }
    }
}
