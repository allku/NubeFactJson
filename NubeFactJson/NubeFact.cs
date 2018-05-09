using System;
using System.Data.SqlClient;

namespace NubeFactJson
{
    public class NubeFact
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public string Enviar() {
            var conSqlServer = new Connection().InitSqlServer();
            if (FechaInicio == null)
            {
                return "La fecha inicial debe contener un valor";
            }
            if (FechaFin == null)
            {
                return "La fecha final debe contener un valor";
            }
            try
            {
                conSqlServer.Open();
                SqlCommand sqlCmd = new SqlCommand("select tipo_comprobante, serie, numero from v_peru_facturas_reporte " +
                                                   "where cast(fecha as Date) " +
                                                   "between cast(@fechaInicio as Date) and cast(@fechaFin as Date) " +
                                                   "order by fecha, serie, numero asc",
                                                   conSqlServer);

                sqlCmd.Parameters.AddWithValue("@fechaInicio", this.FechaInicio);
                sqlCmd.Parameters.AddWithValue("@fechaFin", this.FechaFin);

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
                return "";
            }
            catch (Exception ex)
            {
                return "Error al enviar las facturas " + ex.ToString();
            }            
        }

        public string Verificar() {
            var conSqlServer = new Connection().InitSqlServer();
            if (FechaInicio == null)
            {
                return "La fecha debe contener un valor";
            }
            if (FechaFin == null)
            {
                return "La fecha debe contener un valor";
            }
            try
            {
                conSqlServer.Open();
                SqlCommand sqlCmd = new SqlCommand("select tipo_comprobante, serie, numero from v_peru_facturas_reporte " +
                                                   "where cast(fecha as Date) " +
                                                   "between cast(@fechaInicio as Date) and cast(@fechaFin as Date) " +
                                                   "and estado = @estado " +
                                                   "order by fecha, serie, numero asc",
                                                   conSqlServer);

                sqlCmd.Parameters.AddWithValue("@fechaInicio", this.FechaInicio);
                sqlCmd.Parameters.AddWithValue("@fechaFin", this.FechaFin);
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
                return "";
            }
            catch (Exception ex)
            {
                return "Error al verificar las facturas " + ex.ToString();
            }        
        }
    }
}
