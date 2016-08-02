using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HotelReservationSystem.Model;
using System.Data;
using HotelReservationSystem.Entity;

namespace HotelReservationSystem.Staff.Model
{
    class MakeNewBookingModel
    {
        public DataTable Hotels
        {
            get
            {
                string sql = "SELECT * FROM Hotel";
                SqlDataAdapter sda = new SqlDataAdapter(sql, DatabaseConfig.connectionString);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }

        public DataTable RoomTypes
        {
            get
            {
                string sql = "SELECT * FROM RoomType";
                SqlDataAdapter sda = new SqlDataAdapter(sql, DatabaseConfig.connectionString);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }

        public string CustomerName(string code)
        {
            string result = "";
            string sql = "SELECT * FROM Customer WHERE Code = '" + code + "'";
            SqlCommand cmd = new SqlCommand(sql, DatabaseConfig.OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                result = dr.GetString(1);
            }
            DatabaseConfig.CloseConnection();
            return result;
        }

        public DataTable AvaiableRooms(string sql)
        {
            List<string> list = new List<string>();


            SqlDataAdapter sda = new SqlDataAdapter(sql, DatabaseConfig.connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public bool CreateBooking(string customerCode, DataTable dataTable)
        {
            SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString);
            conn.Open();
            SqlCommand cmd;
            string sql = "";

            bool result = true;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                /// insert into booking
                sql = "INSERT INTO Booking(CustomerCode,BookingDate) VALUES(@customerCode,@bookingDate)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@customerCode", customerCode);
                cmd.Parameters.AddWithValue("@bookingDate", DateTime.Now.ToString());

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                //////////////////////////////

                /// get code of newest booking
                sql = "SELECT TOP 1 * FROM Booking ORDER BY Code DESC";
                cmd = new SqlCommand(sql, DatabaseConfig.OpenConnection());
                int code = (int)cmd.ExecuteScalar();
                cmd.Dispose();
                /////////////////////////////////

                /// insert into BookingDetail
                sql = "INSERT INTO BookingDetail VALUES(@code,@roomNo,@CheckinDate,@CheckoutDate,@Price)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@roomNo", dataTable.Rows[i]["RoomNo"].ToString());
                cmd.Parameters.AddWithValue("@CheckinDate", ((DateTime)dataTable.Rows[i]["Check in"]).ToString());
                cmd.Parameters.AddWithValue("@CheckoutDate", ((DateTime)dataTable.Rows[i]["Check out"]).ToString());
                cmd.Parameters.AddWithValue("@Price", dataTable.Rows[i]["Price per night"].ToString());

                int check = cmd.ExecuteNonQuery();
                result = (result && check > 0);

                cmd.Dispose();
                //////////////////////////
            }

            conn.Close();
            return result;
        }
    }
}
