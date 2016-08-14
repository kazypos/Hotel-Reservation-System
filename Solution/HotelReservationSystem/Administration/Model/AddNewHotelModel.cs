using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Model;
using System.Data.SqlClient;

namespace HotelReservationSystem.Administration.Model
{
    class AddNewHotelModel
    {
        public bool AddNewHotel(string code,string name, string address)
        {
            bool result = false;

            string sql = "insert into Hotel(Code,Name,Address) values(@code,@name,@address)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DatabaseConfig.OpenConnection();
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                result = true;
            }

            DatabaseConfig.CloseConnection();

            return result;
        }
        //public bool CheckExistName(string name)
        //{
        //    bool result = false;
        //    string sql = "SELECT * FROM Hotel WHERE Name='" + name + "'";
        //    SqlCommand cmd = new SqlCommand(sql, DatabaseConfig.OpenConnection());
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        result = true;
        //    }
        //    DatabaseConfig.CloseConnection();
        //    return result;
        //}
        public bool CheckExistCode(string code)
        {
            bool result = false;
            string sql = "SELECT * FROM Hotel WHERE Code='" + code + "'";
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
