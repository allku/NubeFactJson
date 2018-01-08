using System.Data.SqlClient;
using System;

namespace NubeFactJson
{
    public class Connection
    {       
        public SqlConnection initSqlServer()
        {
            SqlConnection conSqlServer = new SqlConnection(
                System.Configuration.ConfigurationManager.ConnectionStrings[
                    "NubeFactJson.Properties.Settings.BDQualityv"]
                       .ConnectionString);
            return conSqlServer;
        }

        public void probarSqlServerConnection()
        {

            SqlConnection conSqlServer = new Connection().initSqlServer();

            //Console.WriteLine(System.Configuration.ConfigurationManager.ConnectionStrings[
                //"NubeFactJson.Properties.Settings.BDQualityv"].ConnectionString);

            try
            {
                conSqlServer.Open();
                Console.WriteLine("Conexión Sql Server correcta");
                conSqlServer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de Conexión " + ex.ToString());
            }
        }
    }
}
