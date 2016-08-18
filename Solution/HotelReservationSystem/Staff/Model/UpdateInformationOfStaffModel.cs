using HotelReservationSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Staff.Model
{
    class UpdateInformationOfStaffModel
    {
        public bool UpdatePassword(string username, string old, string new1)
        {
            SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString);
            conn.Open();
            SqlCommand cmd;

            string sql;

            sql = " update Login set LoginPassword='" + new1 + "' where LoginId='" + username + "' and LoginPassword='" + old + "' ";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            return true;


        }
        public bool CheckExist(string UserName, string PassWord)
        {
            bool result = false;

            string sql = "SELECT * FROM Login WHERE LoginId='" + UserName + "' AND LoginPassword='" + PassWord + "'";
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
