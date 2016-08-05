using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem.Administration.Control;

namespace HotelReservationSystem.Administration.View
{
    public partial class PrintSummaryAdminView : Form
    {
        PrintSummaryAdminController control;
        DataTable dataTable;

        private string hotelCode;
        private string roomType;

        private DateTime inDate;
        private DateTime outDate;

        public PrintSummaryAdminView()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            control = new PrintSummaryAdminController();

            comboHotel.DisplayMember = "Name";
            comboHotel.ValueMember = "Code";
            comboHotel.DataSource = control.Hotels;

            comboRoomType.DisplayMember = "TypeName";
            comboRoomType.ValueMember = "TypeCode";
            comboRoomType.DataSource = control.RoomTypes;

            // clear hour, minute, second and just use to day, month and year
            String tmp = DateTime.Now.ToShortDateString();
            datePickerOut.Value = Convert.ToDateTime(tmp) + new TimeSpan(1, 0, 0, 0, 0);
            datePickerIn.Value = Convert.ToDateTime(tmp);
            inDate = datePickerIn.Value;
            outDate = datePickerOut.Value.Date;

            FillTableStatistic();
        }

        /// <summary>
        /// get data from Booking and BookingDetail table and fill data to table
        /// </summary>
        private void FillTableStatistic()
        {
            if (dataTable != null)
            {
                dataTable.Dispose();
            }
            dataTable = control.Statistic(hotelCode, roomType, inDate, outDate);
            dataGridViewStatistic.DataSource = dataTable;
            double total = 0;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                total += double.Parse(dataTable.Rows[i][5].ToString());
            }
            lblTotalRevenue.Text = "Total revenue: " + total + "($)";
        }

        private void ClearDataTable()
        {
            if (dataTable != null)
            {
                dataTable.Clear();
            }
        }

        private void datePickerIn_ValueChanged(object sender, EventArgs e)
        {
            inDate = datePickerIn.Value.Date;
            ClearDataTable();
        }

        private void datePickerOut_ValueChanged(object sender, EventArgs e)
        {
            outDate = datePickerOut.Value.Date;
            ClearDataTable();
        }

        private void btnViewRevenue_Click(object sender, EventArgs e)
        {
            if ((outDate - inDate).Days > 0)
            {
                FillTableStatistic();
            }
            else
            {
                MessageBox.Show("Check-out date must be greater than check-in date");
                ClearDataTable();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            hotelCode = comboHotel.SelectedValue.ToString();
            ClearDataTable();
        }

        private void comboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomType = comboRoomType.SelectedValue.ToString();
            ClearDataTable();
        }
    }
}
