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
using System.Data;

namespace HotelReservationSystem.Administration.View
{
    public partial class PrintSummaryAdminView : Form
    {
        PrintSummaryAdminController control;

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

            inDate = datePickerIn.Value.Date;
            outDate = datePickerOut.Value.Date;
        }

        private void FillTableStatistic()
        {
            DataTable dt = control.Statistic(hotelCode, roomType, inDate, outDate);
            dataGridViewStatistic.DataSource = dt;
            double total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                total += double.Parse(dt.Rows[i][5].ToString());
            }
            lblTotalRevenue.Text = "Total revenue: " + total + "($)";
        }

        private void datePickerIn_ValueChanged(object sender, EventArgs e)
        {
            inDate = datePickerIn.Value.Date;
        }

        private void datePickerOut_ValueChanged(object sender, EventArgs e)
        {
            outDate = datePickerOut.Value.Date;
        }

        private void btnViewRevenue_Click(object sender, EventArgs e)
        {
            FillTableStatistic();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            hotelCode = comboHotel.SelectedValue.ToString();
        }

        private void comboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomType = comboRoomType.SelectedValue.ToString();
        }
    }
}
