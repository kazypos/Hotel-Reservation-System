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
        Form view;
        public MakeNewBookingController(Form view)
        {
            this.view = view;
            model = new MakeNewBookingModel();
        }
        public void LoadForm(Form frm)
        {
            frm.FormClosed += Event_FormClosed;
            view.Hide();
            frm.Show();
        }

        private void Event_FormClosed(object sender, FormClosedEventArgs e)
        {
            view.Show();
        }

        public DataTable Hotels { get { return model.Hotels; } }
        public DataTable RoomTypes { get { return model.RoomTypes; } }

        public string CustomerName(string code)
        {
            return model.CustomerName(code);
        }

        /// <summary>
        ///  1.get table room booked from database
        ///  2.join table room booked with table room pre-booking
        ///     follow RoomNo
        ///  3. Create 1 Dictionary to mark RoomNo not avaiable follow check-in date and check-out date
        ///  4. filter RoomNo avaiable with marked RoomNo Dictionary
        ///  
        /// </summary>
        /// <param name="hotelCode"> hotel code</param>
        /// <param name="roomType"> type of room</param>
        /// <param name="inDate"> check-in date</param>
        /// <param name="outDate"> check-out date</param>
        /// <param name="dataTable"> table Room pre-booking </param>
        /// <returns>table room avaiable</returns>
        public DataTable AvaiableRooms(string hotelCode, string roomType, DateTime inDate, DateTime outDate, DataTable dataTable)
        {
            string sql = "SELECT r.RoomNo,r.Price,bd.CheckinDate,bd.CheckoutDate "
                        + " FROM [HotelReservation].[dbo].[Room] r left join [HotelReservation].[dbo].[BookingDetail] "
                        + "bd on r.RoomNo= bd.RoomNo "
                        + "WHERE ";
            sql += " r.HotelCode='" + hotelCode + "' "
            + "and r.TypeCode=" + roomType;

            // table Room booked
            DataTable dtSelect = model.AvaiableRooms(sql);

            DataTable result = new DataTable();
            result.Columns.Add("RoomNo");
            result.Columns.Add("Price");

            // use to mark RoomNo busy 
            Dictionary<string, bool> marksBusy = new Dictionary<string, bool>();

            // xoa het gio phut giay
            string tmp = inDate.ToShortDateString();
            inDate = Convert.ToDateTime(tmp);

            tmp = outDate.ToShortDateString();
            outDate = Convert.ToDateTime(tmp);

            // add pre-book to list room booked
            if (dataTable.Rows.Count>0)
            {
                int sizeOriginal = dtSelect.Rows.Count;
                for (int k = 0; k < sizeOriginal; k++)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        if (dataTable.Rows[i]["RoomNo"].ToString().Equals(dtSelect.Rows[k]["RoomNo"].ToString()))
                        {
                            DataRow dr = dtSelect.NewRow();
                            dr[0] = dataTable.Rows[i]["RoomNo"].ToString();
                            dr[1] = dataTable.Rows[i]["Price per night"];
                            dr[2] = dataTable.Rows[i]["Check in"];
                            dr[3] = dataTable.Rows[i]["Check out"];
                            dtSelect.Rows.Add(dr);
                        }
                    }
                }
            }

            // filter follow checkin date and checkout date
            for (int i = 0; i < dtSelect.Rows.Count; i++)
            {
                if (dtSelect.Rows[i]["CheckinDate"].ToString().Equals(""))
                {
                   
                }
                else
                {
                    DateTime checkinDate = (DateTime)dtSelect.Rows[i]["CheckinDate"];
                    DateTime checkoutDate = (DateTime)dtSelect.Rows[i]["CheckoutDate"];

                    if (outDate<=checkinDate || inDate>=checkoutDate)
                    {
                    }
                    else
                    {
                        //MessageBox.Show("Add " + dtSelect.Rows[i][2].ToString());
                        // mark RoomNo is busy
                        if (!marksBusy.ContainsKey(dtSelect.Rows[i][0].ToString()))
                        {
                            marksBusy.Add(dtSelect.Rows[i][0].ToString(), true);
                        }
                    }
                }
            }

            // return RoomNo isn't busy
            for (int i = 0; i < dtSelect.Rows.Count; i++)
            {
                if (!marksBusy.ContainsKey(dtSelect.Rows[i]["RoomNo"].ToString()))
                {
                    DataRow dr = result.NewRow();
                    dr[0] = dtSelect.Rows[i][0];
                    dr[1] = dtSelect.Rows[i][1];
                    result.Rows.Add(dr);
                    marksBusy.Add(dtSelect.Rows[i][0].ToString(), true);
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
