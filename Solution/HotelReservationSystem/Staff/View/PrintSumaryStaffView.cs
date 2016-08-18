
using HotelReservationSystem.Staff.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.Staff.View
{
    public partial class PrintSumaryStaffView : Form
    {
        PrintSummaryStaffController control;
        DataTable dataTable;
        public PrintSumaryStaffView()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            control = new PrintSummaryStaffController();
            dataTable = control.GetBookingWithDate(txtCustomer.Text, datePickerBooking.Value);
            dataGridViewStatistic.DataSource = dataTable;
            lblNumberOfRecord.Text = "Number of Record(s):" + dataTable.Rows.Count;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataTable = control.GetBookingWithDate(txtCustomer.Text, datePickerBooking.Value);
            dataGridViewStatistic.DataSource = dataTable;
            lblNumberOfRecord.Text = "Number of Record(s):" + dataTable.Rows.Count;
        }

        private void txtCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datePickerBooking_ValueChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }
    }
}
