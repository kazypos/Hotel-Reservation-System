using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Entity;
using System.Data.SqlClient;
using HotelReservationSystem.Model;
using System.Data;

namespace HotelReservationSystem.Administration.Model
{
    class UpdateRoomPriceModel
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

        public DataTable Rooms(int roomTypeCode, string hotelCode)
        {
            string sql = "SELECT * FROM Room WHERE HotelCode='" + hotelCode + "' AND TypeCode=" + roomTypeCode;
            SqlDataAdapter sda = new SqlDataAdapter(sql, DatabaseConfig.connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public bool UpdateNewPrice(string roomNo, string hotelCode, double newPrice)
        {
            bool result = false;

            string sql = "UPDATE Room SET Price=" + newPrice + " WHERE HotelCode='" + hotelCode + "' AND RoomNo='" + roomNo + "'";
            SqlCommand cmd = new SqlCommand(sql, DatabaseConfig.OpenConnection());
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                result = true;
            }
            DatabaseConfig.CloseConnection();
            return result;
        }
    }
}
