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
    public partial class UpdateInformationOfStaffView : Form
    {
        UpdateInformationOfStaffController control;
        public UpdateInformationOfStaffView(string username)
        {
            InitializeComponent();
            txtUserName.Text = username;
            txtUserName.Enabled = false;
            control = new UpdateInformationOfStaffController();
        }

        private void CheckValidStaff()
        {
            if (txtOldPassword.Text.Equals(""))
            {
                MessageBox.Show("Please enter current Password");
            }
            else if (txtNewPassword.Text.Equals(""))
            {
                MessageBox.Show("Please enter New Password!");
            }
            else if (!control.CheckExist(txtUserName.Text, txtOldPassword.Text))
            {
                MessageBox.Show("Old Password wrong!");
            }
            else if (txtOldPassword.Text.Equals(txtNewPassword.Text))
            {
                MessageBox.Show("New Password must different with Old Password!");
            }
            else
            {
                UpdatePass();
            }

        }
        private void UpdatePass()
        {
            if (control.UpdatePassword(txtUserName.Text, txtOldPassword.Text, txtNewPassword.Text))
            {
                MessageBox.Show("Change password is successfull");
                txtOldPassword.Text = txtNewPassword.Text = "";
                txtOldPassword.Focus();
            }
            else
            {
                MessageBox.Show("Chang password failed!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            CheckValidStaff();

        }
    }
}
