using System.Data.SqlClient;

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
    }
}
