using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Entity;
using HotelReservationSystem.Model;
using System.Data.SqlClient;

namespace HotelReservationSystem
{
    class TestDatabase
    {
        public List<Login> Accounts()
        {
            List<Login> list = new List<Login>();
            string sql = "SELECT * FROM Login WHERE LoginId=@id AND LoginPassword=@password AND Roles=@role";
            SqlConnection conn = DatabaseConfig.OpenConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@id", "admin");
            cmd.Parameters.AddWithValue("@password", "qwe123");
            cmd.Parameters.AddWithValue("@role", true);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Login temp = new Login();
                temp.LoginId = dr[0].ToString();
                temp.LoginPassword = dr[1].ToString();
                temp.Roles = (bool)dr[2];
                list.Add(temp);
            }

            DatabaseConfig.CloseConnection();
            return list;
        }
    }
}
