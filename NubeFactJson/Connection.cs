using System.Data.SqlClient;
using System;

namespace NubeFactJson
{
    public class Connection
    {       
        public SqlConnection InitSqlServer()
        {
            SqlConnection conSqlServer = new SqlConnection(
                System.Configuration.ConfigurationManager.ConnectionStrings[
                    "NubeFactJson.Properties.Settings.BDQualityv"]
                       .ConnectionString);
            return conSqlServer;
        }

        public Boolean ProbarSqlServerConnection()
        {
            SqlConnection conSqlServer = new Connection().InitSqlServer();            
            try
            {
                conSqlServer.Open();                
                conSqlServer.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                return false;
            }
        }
    }
}
