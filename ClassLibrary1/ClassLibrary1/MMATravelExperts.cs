﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public class MMATravelExperts
    {
        public static SqlConnection GetConnection()
        // creates the connection to Travel Experts Database
        // return instance of SqlConnection
        {
            //Warning Warning Connection String Chaanged .. Added Password!
            string connectionString = "Data Source=localhost\\sait;Initial Catalog=TravelExperts;User ID=sa;Password=sa";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}