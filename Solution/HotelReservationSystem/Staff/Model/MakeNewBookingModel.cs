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

        public bool CreateBooking(Booking booking)
        {
            bool result = false;
            string sql = "INSERT INTO Booking(CustomerCode,BookingDate) VALUES(@customerCode,@bookingDate)";

            SqlCommand cmd = new SqlCommand(sql, DatabaseConfig.OpenConnection());

            cmd.Parameters.AddWithValue("@customerCode", booking.CustomerCode);
            cmd.Parameters.AddWithValue("@bookingDate", booking.BookingDate.ToString());

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                result = true;
            }

            DatabaseConfig.CloseConnection();

            return result;
        }

        public int GetCodeBooking()
        {
            int result = -1;
            string sql = "SELECT TOP 1 * FROM Booking ORDER BY Code DESC";
            SqlCommand cmd = new SqlCommand(sql, DatabaseConfig.OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                result = dr.GetInt32(0);
            }

            DatabaseConfig.CloseConnection();
            return result;

        }

        public bool CreateBookingDetail(int code, DataTable dataTable)
        {
            bool result = true;
            string sql = "INSERT INTO BookingDetail VALUES(@code,@roomNo,@CheckinDate,@CheckoutDate,@Price)";
            SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString);
            conn.Open();


            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@roomNo", dataTable.Rows[i]["RoomNo"].ToString());
                cmd.Parameters.AddWithValue("@CheckinDate", ((DateTime)dataTable.Rows[i]["Check in"]).ToString());
                cmd.Parameters.AddWithValue("@CheckoutDate", ((DateTime)dataTable.Rows[i]["Check out"]).ToString());
                cmd.Parameters.AddWithValue("@Price", dataTable.Rows[i]["Total price"].ToString());

                int check = cmd.ExecuteNonQuery();
                result = (result && check > 0);

                cmd.Dispose();
            }

            conn.Close();
            return result;
        }
    }
}
