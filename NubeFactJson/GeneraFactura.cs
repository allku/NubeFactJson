using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Collections.Generic;

namespace NubeFactJson
{
    public class GeneraFactura
    {
        String tipoComprobante { get; set; }
        String serie { get; set; }
        String numero { get; set; }
        Invoice invoice;

        public GeneraFactura(string tipoComprobante, string serie, string numero)
        {
            this.tipoComprobante = tipoComprobante;
            this.serie = serie;
            this.numero = numero;
            this.invoice = new Invoice();
        }
        public GeneraFactura()
        {
            this.tipoComprobante = "";
            this.serie = "";
            this.numero = "";
            this.invoice = new Invoice();
        }

        public Invoice genera() {
            loadFactura();
            loadFacturaDetalle();

            return this.invoice;
        }

        void loadFactura() {
            SqlConnection conSqlServer = new Connection().initSqlServer();
            try
            {
                conSqlServer.Open();
                SqlCommand sqlCmd = new SqlCommand("select * from v_peru_facturas " +
                                                   "where tipo_comprobante=@tipoComprobante " +
                                                   "and serie=@serie " +
                                                   "and numero=@numero",
                                                   conSqlServer);
                sqlCmd.Parameters.AddWithValue("@tipoComprobante", this.tipoComprobante);
                sqlCmd.Parameters.AddWithValue("@serie", this.serie);
                sqlCmd.Parameters.AddWithValue("@numero", this.numero);

                SqlDataReader sqlRead = sqlCmd.ExecuteReader();

                while (sqlRead.Read())
                {
                    this.invoice.operacion = "generar_comprobante";
                    this.invoice.tipo_de_comprobante = int.Parse(sqlRead["tipo_comprobante"].ToString());
                    this.invoice.serie = sqlRead["serie"].ToString();
                    this.invoice.numero = int.Parse(sqlRead["numero"].ToString());
                    this.invoice.sunat_transaction = 1;
                    this.invoice.cliente_tipo_de_documento = 6;
                    this.invoice.cliente_numero_de_documento = sqlRead["numero_documento"].ToString();
                    this.invoice.cliente_denominacion = sqlRead["denominacion"].ToString();
                    this.invoice.cliente_direccion = sqlRead["direccion"].ToString();
                    this.invoice.cliente_email = sqlRead["email"].ToString();
                    this.invoice.fecha_de_emision = DateTime.ParseExact(sqlRead["fecha"].ToString(), "dd-mm-yyyy", CultureInfo.InvariantCulture);
                    this.invoice.moneda = 1;
                    this.invoice.porcentaje_de_igv = 18;
                    this.invoice.total_gravada = sqlRead["total_gravada"].ToString();
                    this.invoice.total_igv = double.Parse(sqlRead["total_igv"].ToString());
                    this.invoice.total = double.Parse(sqlRead["total"].ToString());
                    this.invoice.detraccion = false;
                    this.invoice.enviar_automaticamente_a_la_sunat = true;
                    this.invoice.enviar_automaticamente_al_cliente = false;
                }

                sqlRead.Close();
                conSqlServer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de carga de facturas" + ex.ToString());
            }
        }
        void loadFacturaDetalle() {
            SqlConnection conSqlServer = new Connection().initSqlServer();

            try
            {
                conSqlServer.Open();
                SqlCommand sqlCmd = new SqlCommand("select * from v_peru_facturas_detalle " +
                                                   "where tipo_comprobante=@tipoComprobante " +
                                                   "and serie=@serie " +
                                                   "and numero=@numero",
                                                   conSqlServer);
                sqlCmd.Parameters.AddWithValue("@tipoComprobante", this.tipoComprobante);
                sqlCmd.Parameters.AddWithValue("@serie", this.serie);
                sqlCmd.Parameters.AddWithValue("@numero", this.numero);

                SqlDataReader sqlRead = sqlCmd.ExecuteReader();
                var items = new List<Items>();
                while (sqlRead.Read())
                {
                    items.Add(new Items()
                    {
                        unidad_de_medida = "NIU",
                        //codigo = "001",  // codigo interno del producto
                        codigo = sqlRead["codigo_principal"].ToString(),
                        //descripcion = "DETALLE DEL PRODUCTO", // descripcion del producto
                        descripcion = sqlRead["descripcion"].ToString(),
                        //cantidad = 1,
                        cantidad = double.Parse(sqlRead["cantidad"].ToString()),
                        //valor_unitario = 500,   // valor sin iva
                        valor_unitario = double.Parse(sqlRead["valor_unitario"].ToString()),   // valor sin iva 
                        //precio_unitario = 590,  //  valor_unitario+(valor_unitario(18%))
                        precio_unitario = double.Parse(sqlRead["precio_unitario"].ToString()),
                        descuento = "",
                        //subtotal = 500,/// (valor_unitario- descuento)*cantidad
                        subtotal = double.Parse(sqlRead["subtotal"].ToString()),
                        tipo_de_igv = 1,    // es una constante IGV =1
                        //igv = 90,           // (cantidad*valor_unitario)18%  TOTAL DE IGV DE LA LINEA() 
                        igv = double.Parse(sqlRead["igv_linea"].ToString()),
                        //total = 590,      //total de la linea   precio_unitario+(precio_unitario)18% 
                        total = double.Parse(sqlRead["total_linea"].ToString()),
                        anticipo_regularizacion = false,
                        anticipo_comprobante_serie = "",  // opcionales
                        anticipo_comprobante_numero = ""  // opcionales 
                    });
                }

                this.invoice.items = items;

                sqlRead.Close();
                conSqlServer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de carga de facturas detalle" + ex.ToString());
            }
        }
    }
}
