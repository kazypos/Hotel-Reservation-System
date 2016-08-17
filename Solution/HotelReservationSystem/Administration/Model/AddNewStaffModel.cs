using HotelReservationSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Administration.Model
{
    class AddNewStaffModel
    {
        public bool AddNewStaff(string username, string password,bool role)
        {
            bool result = false;
            
            string sql = "insert into Login values(@username,@password,@role)";
            SqlCommand cmd = new SqlCommand(sql,DatabaseConfig.OpenConnection());
            
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@role", role);
            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                result = true;
            }

            DatabaseConfig.CloseConnection();

            return result;
        }

        public bool CheckUserExist(string username)
        {
            bool result = false;
            string sql = "SELECT * FROM Login WHERE loginID ='" + username + "'";
            SqlCommand cmd = new SqlCommand(sql, DatabaseConfig.OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                result = true;
            }
            DatabaseConfig.CloseConnection();
            return result;
        }
    }
}
