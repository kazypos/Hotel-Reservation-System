using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem.Staff.Control;

namespace HotelReservationSystem.Staff.View
{
    public partial class StaffView : Form
    {
        StaffController control;
        public StaffView()
        {
            Init();
        }

        public StaffView(string username)
        {
            Init();
            lblUsername.Text = username;
        }

        private void Init()
        {
            InitializeComponent();
            control = new StaffController(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMakeNewBooking_Click(object sender, EventArgs e)
        {
            control.LoadForm(new MakeNewBookingView());
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            control.LoadForm(new AddNewCustomerView());

        }

        private void btnUpdateInforStaff_Click(object sender, EventArgs e)
        {

        }
    }
}
