using System.Data.SqlClient;
using System;
using ConsoleTables;

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
            var table = new ConsoleTable("Conexión Sql Server");

            try
            {
                conSqlServer.Open();
                table.AddRow("Correcta");
                conSqlServer.Close();
            }
            catch (Exception ex)
            {
                table.AddRow("Error " + ex.ToString());
            }

            table.Write();
        }
    }
}
