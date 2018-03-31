using System;
using System.Data.SqlClient;

namespace NubeFactJson
{
    public class NubeFact
    {
        public String fecha { get; set; }
        public string enviar() {
            var conSqlServer = new Connection().initSqlServer();
            if (fecha == null)
            {
                return "La fecha debe contener un valor";
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
                return "Error al enviar las facturas para enviar " + ex.ToString();
            }
            return "";
        }
        public string verificar() {
            var conSqlServer = new Connection().initSqlServer();
            if (fecha == null)
            {
                return "La fecha debe contener un valor";
            }
            try
            {
                conSqlServer.Open();
                SqlCommand sqlCmd = new SqlCommand("select tipo_comprobante, serie, numero from v_peru_facturas_reporte " +
                                                   "where fecha = @fecha " +
                                                   "and estado = @estado " +
                                                   "order by serie, numero asc",
                                                   conSqlServer);

                sqlCmd.Parameters.AddWithValue("@fecha", this.fecha);
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
