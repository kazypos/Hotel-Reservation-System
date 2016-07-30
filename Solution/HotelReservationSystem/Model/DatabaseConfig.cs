using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace HotelReservationSystem.Model
{
    class DatabaseConfig
    {
        public static readonly string connectionString = ConfigurationManager.
            ConnectionStrings["HotelReservationConnnectionString"].
            ConnectionString.ToString();
        static SqlConnection conn;
        public static SqlConnection OpenConnection()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static void CloseConnection()
        {
            conn.Close();
        }
    }
}
