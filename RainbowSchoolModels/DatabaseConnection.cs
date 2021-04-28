using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace RainbowSchoolModels
{
    public class DatabaseConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Server = YASHASVI;Database=nunitTestSchoolDB; Trusted_Connection=True";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
       
    }
}
