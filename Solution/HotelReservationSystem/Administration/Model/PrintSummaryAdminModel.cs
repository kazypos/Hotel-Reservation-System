using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HotelReservationSystem.Model;
using System.Data;

namespace HotelReservationSystem.Administration.Model
{
    class PrintSummaryAdminModel
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

        public DataTable Statistic(string hoteCode, string roomType, DateTime inDate, DateTime outDate)
        {
            string sql = "SELECT "
                    + "bd.RoomNo,"
                    + "CONVERT(VARCHAR(15), [CheckinDate], 101) AS[Checkin Date] ,"
                    + "CONVERT(VARCHAR(15), [CheckoutDate], 101) AS[Checkout Date] ,"
                    + "[Number of night(s)]=Day([CheckoutDate]-[CheckinDate])-1,"
                    + "bd.Price as[Price per night],"
                    + "[Total amount]=bd.Price* (Day([CheckoutDate]-[CheckinDate])-1),"
                    + "b.Code as [Booking id],"
                    + "CONVERT(VARCHAR(15), b.BookingDate, 101) AS 'Booking Date'"

                    + "FROM(BookingDetail bd inner join Booking b on bd.Code= b.Code inner join Room r on (bd.RoomNo = r.RoomNo))"

                    + "where HotelCode='" + hoteCode + "' and TypeCode=" + roomType + " and "
                    + "bd.[CheckinDate] between convert(smalldatetime, '" + inDate.ToString("yyyy-MM-dd") + "', 120) and convert(smalldatetime, '" + outDate.ToString("yyyy-MM-dd") + "', 120)";

            SqlDataAdapter sda = new SqlDataAdapter(sql, DatabaseConfig.connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
