using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using HotelReservationSystem.Model;

namespace HotelReservationSystem.Staff.Model
{
    class AddNewCustomerModel
    {
        public bool AddNewCustomer(string customerCode,string customerName, string customerAddress)
        {
            bool result = false;

            string sql = "INSERT INTO Customer(Code,Name,Address) VALUES(@code,@name,@address)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DatabaseConfig.OpenConnection();
            cmd.Parameters.AddWithValue("@code", customerCode);
            cmd.Parameters.AddWithValue("@name", customerName);
            cmd.Parameters.AddWithValue("@address", customerAddress);

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                result = true;
            }

            DatabaseConfig.CloseConnection();

            return result;
        }

        public bool CheckExist(string customerCode)
        {
            bool result = false;

            string sql = "SELECT * FROM Customer WHERE Code='" + customerCode + "'";
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
