using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Entity;
using System.Data.SqlClient;
namespace HotelReservationSystem.Model
{
    class LoginModel
    {
        string show = "";
        public bool CheckLogin(Login accountEntry)
        {
            bool result = false;
            try
            {
                string sql = "SELECT * FROM Login WHERE LoginId=@id AND LoginPassword=@password AND Roles=@role";
                SqlConnection conn = DatabaseConfig.OpenConnection();

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = sql;
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@id", accountEntry.LoginId);
                cmd.Parameters.AddWithValue("@password", accountEntry.LoginPassword);
                cmd.Parameters.AddWithValue("@role", accountEntry.Roles);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    result = true;
                }

                dr.Close();

                DatabaseConfig.CloseConnection();
            }
            catch (Exception e)
            {
               
            }
            return result;
        }
    }
}
