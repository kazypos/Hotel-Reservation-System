using HotelReservationSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Staff.Model
{
    class PrintSummaryStaffModel
    {
        public DataTable GetBookingWithDate(string customerName, DateTime Date)
        {
            string sql = "Select "
                          + " c.Name 'Customer Name',"
                          + " b.BookingDate 'Booking Date',"
                          + " bd.RoomNo 'Room No',"
                          + " CONVERT(VARCHAR(15), bd.CheckinDate, 101)  'CheckinDate',"
                          + " CONVERT(VARCHAR(15), bd.CheckoutDate, 101) 'CheckoutDate',"
                          + " bd.Price 'Price per night'"
                          + " From Customer c join Booking b on c.Code = b.CustomerCode join BookingDetail bd on b.Code = bd.Code"
                          + " where c.Name like '%"+customerName+"%' or b.BookingDate = convert(smalldatetime, '" + Date.ToString("yyyy-MM-dd") + "', 120) ";
            SqlDataAdapter sda = new SqlDataAdapter(sql, DatabaseConfig.connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
