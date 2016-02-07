using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// coding Doug Sraega edit Emile Leger
/// </summary>
namespace TravelExpertsDB
{
    public class MMATravelExperts
    {
        public static SqlConnection GetConnection()
        // creates the connection to Travel Experts Database
        // return instance of SqlConnection
        {
            //Warning Warning Connection String Chaanged .. Added Password!
            string connectionString = "Data Source=localhost\\sait;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
