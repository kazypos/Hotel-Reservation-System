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
            string sql = "SELECT DISTINCT r.RoomNo,r.Price,bd.CheckinDate,bd.CheckoutDate "
                        + " FROM [HotelReservation].[dbo].[Room] r left join [HotelReservation].[dbo].[BookingDetail] "
                        + "bd on r.RoomNo= bd.RoomNo "
                        + "WHERE ";
            sql += " r.HotelCode='" + hotelCode + "' "
            + "and r.TypeCode=" + roomType;

            DataTable dtSelect = model.AvaiableRooms(sql);

            DataTable result = new DataTable();
            result.Columns.Add("RoomNo");
            result.Columns.Add("Price");

            Dictionary<string, bool> marksBusy = new Dictionary<string, bool>();

            for (int i = 0; i < dtSelect.Rows.Count; i++)
            {
                if (dtSelect.Rows[i]["CheckinDate"].ToString().Equals(""))
                {
                    DataRow dr = result.NewRow();
                    dr[0] = dtSelect.Rows[i][0];
                    dr[1] = dtSelect.Rows[i][1];
                    result.Rows.Add(dr);
                    MessageBox.Show("Add " + dtSelect.Rows[i][0].ToString());
                    marksBusy.Add(dtSelect.Rows[i][0].ToString(), true);
                }
                else
                {
                    //MessageBox.Show(dtSelect.Rows[i]["CheckinDate"].ToString());

                    DateTime checkinDate = (DateTime)dtSelect.Rows[i]["CheckinDate"];
                    DateTime checkoutDate = (DateTime)dtSelect.Rows[i]["CheckoutDate"];

                    MessageBox.Show(checkinDate + "\n" + checkoutDate);
                    MessageBox.Show(inDate + "\n" + outDate);

                    bool checkTemp = false;
                    if (checkinDate >= inDate && checkinDate <= outDate)
                    {
                        checkTemp = true;
                    }
                    if (checkoutDate >= inDate && checkoutDate <= outDate)
                    {
                        checkTemp = true;
                    }

                    if (dataTable.Rows.Count > 0)
                    {
                        for (int j = 0; j < dataTable.Rows.Count; j++)
                        {
                            if (dataTable.Rows[j]["RoomNo"].ToString().Equals(dtSelect.Rows[i]["RoomNo"].ToString())
                                && hotelCode.Equals(dataTable.Rows[j]["HotelCode"].ToString())
                                && roomType.Equals(dataTable.Rows[j]["RoomType"].ToString())
                                )
                            {
                                DateTime inDateBooking = (DateTime)dataTable.Rows[j]["Check in"];
                                DateTime outDateBooking = (DateTime)dataTable.Rows[j]["Check out"];
                                if (checkinDate > inDateBooking && checkinDate <= outDateBooking)
                                {
                                    checkTemp = true;
                                    break;
                                }
                                if (checkoutDate > inDateBooking && checkoutDate <= outDateBooking)
                                {
                                    checkTemp = true;
                                    break;
                                }
                            }

                        }
                    }

                    if (checkTemp)
                    {
                        MessageBox.Show("Add " + dtSelect.Rows[i][0].ToString());
                        if (!marksBusy.ContainsKey(dtSelect.Rows[i][0].ToString()))
                        {
                            marksBusy.Add(dtSelect.Rows[i][0].ToString(), true);
                        }
                    }
                }
            }
            for (int i = 0; i < dtSelect.Rows.Count; i++)
            {
                if (!marksBusy.ContainsKey(dtSelect.Rows[i]["RoomNo"].ToString()))
                {
                    DataRow dr = result.NewRow();
                    dr[0] = dtSelect.Rows[i][0];
                    dr[1] = dtSelect.Rows[i][1];
                    result.Rows.Add(dr);
                }
            }

            return result;
        }

        public bool CreateBooking(string customerCode, DataTable dataTable)
        {
            return (model.CreateBooking(customerCode, dataTable));
        }
    }
}
