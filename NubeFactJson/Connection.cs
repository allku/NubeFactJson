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

        public Boolean probarSqlServerConnection()
        {
            SqlConnection conSqlServer = new Connection().initSqlServer();            
            try
            {
                conSqlServer.Open();                
                conSqlServer.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
