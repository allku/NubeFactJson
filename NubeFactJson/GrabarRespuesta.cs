using System;
using System.Data.SqlClient;

namespace NubeFactJson
{
    public class GrabarRespuesta
    {
        String tipoComprobante;
        String serie;
        String numero;
        dynamic respuesta;

        public GrabarRespuesta(string tipoComprobante, string serie, string numero, dynamic respuesta)
        {
            this.respuesta = respuesta;
            this.tipoComprobante = tipoComprobante;
            this.serie = serie;
            this.numero = numero;
        }



        public void borrarGrabar () {
            SqlConnection conSqlServer = new Connection().initSqlServer();
            try
            {
                conSqlServer.Open();

                SqlCommand sqlCmdDelete = new SqlCommand("delete peru_respuesta " +
                                                         "where tipo = @tipo " +
                                                         "and serie = @serie " +
                                                         "and numero = @numero", conSqlServer);

                sqlCmdDelete.Parameters.AddWithValue("@tipo", this.tipoComprobante);
                sqlCmdDelete.Parameters.AddWithValue("@serie", this.serie);
                sqlCmdDelete.Parameters.AddWithValue("@numero", this.numero);

                sqlCmdDelete.ExecuteNonQuery();

                SqlCommand sqlCmdInsert = new SqlCommand("select * from v_peru_facturas " +
                                                   "where tipo_comprobante=@tipoComprobante " +
                                                   "and serie=@serie " +
                                                   "and numero=@numero",
                                                   conSqlServer);
                sqlCmdInsert.Parameters.AddWithValue("@tipoComprobante", this.tipoComprobante);
                sqlCmdInsert.Parameters.AddWithValue("@serie", this.serie);
                sqlCmdInsert.Parameters.AddWithValue("@numero", this.numero);

                SqlDataReader sqlRead = sqlCmdInsert.ExecuteReader();

                while (sqlRead.Read())
                {

                }

                sqlRead.Close();
                conSqlServer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al grabar la Respuesta" + ex.ToString());
            }
        }

        Boolean existe() {
            SqlConnection conSqlServer = new Connection().initSqlServer();
            int count = 0;
            try
            {
                conSqlServer.Open();
                SqlCommand sqlCmd = new SqlCommand("select count(*) as count from peru_respuesta " +
                                                   "where tipo = @tipo " +
                                                   "and serie = @serie " +
                                                   "and numero = @numero", conSqlServer);
                
                sqlCmd.Parameters.AddWithValue("@tipoComprobante", this.tipoComprobante);
                sqlCmd.Parameters.AddWithValue("@serie", this.serie);
                sqlCmd.Parameters.AddWithValue("@numero", this.numero);

                SqlDataReader sqlRead = sqlCmd.ExecuteReader();

                while (sqlRead.Read())
                {
                    count = int.Parse(sqlRead["count"].ToString());
                }
                if (count > 0) {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar la Respuesta" + ex.ToString());
            }
            return false;
        }
    }
}
