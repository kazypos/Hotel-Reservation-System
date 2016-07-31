using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Staff.Model;
using System.Data;
using HotelReservationSystem.Entity;
using System.Windows.Forms;

namespace HotelReservationSystem.Staff.Control
{
    class MakeNewBookingController
    {
        MakeNewBookingModel model;

        public MakeNewBookingController()
        {
            model = new MakeNewBookingModel();
        }
        public DataTable Hotels { get { return model.Hotels; } }
        public DataTable RoomTypes { get { return model.RoomTypes; } }

        public string CustomerName(string code)
        {
            return model.CustomerName(code);
        }

        public DataTable AvaiableRooms(string hotelCode, string roomType, DateTime inDate, DateTime outDate, DataTable dataTable)
        {
            string sql = "SELECT DISTINCT r.RoomNo, r.Price "
                        + "FROM[HotelReservation].[dbo].[Room] r left join [HotelReservation].[dbo].[BookingDetail] "
                        + "bd on r.RoomNo= bd.RoomNo "
                        + "WHERE (((bd.CheckinDate not between '" + inDate.ToString("yyyy-MM-dd") + "' and '" + outDate.ToString("yyyy-MM-dd") + "') "
                        + "and (bd.CheckoutDate not between '" + inDate.ToString("yyyy-MM-dd") + "' and '" + outDate.ToString("yyyy-MM-dd") + "')";
            sql += " ) or CheckinDate is null)";
            if (dataTable.Rows.Count > 0)
            {
                sql += " and ( ";
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    sql += "(";

                    sql += " (('"
                        + ((DateTime)dataTable.Rows[i]["Check in"]).ToString("yyyy-MM-dd")
                        + "' not between '"
                        + inDate.ToString("yyyy-MM-dd")
                        + "' and '"
                        + outDate.ToString("yyyy-MM-dd")
                        + "') "
                        + "and " +
                        "('"
                        + ((DateTime)dataTable.Rows[i]["Check out"]).ToString("yyyy-MM-dd")
                        + "' not between '"
                        + inDate.ToString("yyyy-MM-dd")
                        + "' and '"
                        + outDate.ToString("yyyy-MM-dd")
                        + "'))";

                    sql += " or ";

                    sql += "('"
                        + dataTable.Rows[i]["HotelCode"].ToString()
                        + "' <> '"
                        + hotelCode
                        + "')";

                    sql += " or ";

                    sql += "("
                        + dataTable.Rows[i]["RoomType"].ToString()
                        + " <> "
                        + roomType
                        + ")";

                    sql += " or ";

                    sql += "('"
                        + dataTable.Rows[i]["RoomNo"].ToString()
                        + "' <> "
                        + " r.RoomNo "
                        + ")";


                    sql += ")";

                    if (i < dataTable.Rows.Count - 1)
                    {
                        sql += " and ";
                    }
                }

                sql += " ) ";
            }
            sql += "and r.HotelCode='" + hotelCode + "' "
            + "and r.TypeCode=" + roomType;

            return model.AvaiableRooms(sql);
        }

        public bool CreateBooking(string customerCode, DataTable dataTable)
        {
            bool result = false;
            Booking b = new Booking();
            b.BookingDate = DateTime.Now;
            b.CustomerCode = customerCode;

            result = model.CreateBooking(b);
            int code = model.GetCodeBooking();

            return (result && CreateBookingDetail(code, dataTable));
        }

        public bool CreateBookingDetail(int code, DataTable dataTable)
        {
            return model.CreateBookingDetail(code, dataTable);
        }
    }
}
