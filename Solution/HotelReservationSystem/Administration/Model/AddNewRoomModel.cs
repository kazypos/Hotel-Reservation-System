using HotelReservationSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Administration.Model
{
    class AddNewRoomModel
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
        public bool AddNewRoom(string hotelcode,int type,string roomno,double price,bool busy)
        {
            bool result = false;
            string sql = "insert into Room values(@roomno,@hotelcode,@type,@price,@busy)";
            SqlCommand cmd = new SqlCommand(sql, DatabaseConfig.OpenConnection());

            cmd.Parameters.AddWithValue("@hotelcode", hotelcode);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@roomno", roomno);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@busy", busy);
            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                result = true;
            }

            DatabaseConfig.CloseConnection();

            return result;
        }

        public bool CheckRoomExist(string roomno,string hotelcode)
        {
            bool result = false;
            string sql = "select * from Room where RoomNo='" + roomno 
                         + "' and hotelcode = '" + hotelcode + "'";
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
