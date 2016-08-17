using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem.Administration.Model;
using HotelReservationSystem.Administration.Control;

namespace HotelReservationSystem.Administration.View
{
    public partial class AddNewStaffView : Form
    {
        AddNewStaffController controller;
        public AddNewStaffView()
        {
            InitializeComponent();
            controller = new AddNewStaffController();
        }

        private void AddNewStaff()
        {
            bool role = false;
            if (radioBtnAdmin.Checked) role = true;
            else if (radioBtnStaff.Checked) role = false;
            if (controller.AddNewStaff(txtUserName.Text, txtPassword.Text, role))
            {
                MessageBox.Show("The Staff has been added!!!");
                txtUserName.Text = txtPassword.Text = "";
                radioBtnAdmin.Checked = false;
                radioBtnStaff.Checked = false;
            }
            else
            {
                txtUserName.SelectAll();
                txtPassword.SelectAll();
                MessageBox.Show("Add Staff fail!!!");
            }
        }

        private void CheckValidStaff()
        {
            if (txtUserName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Username!");
            }
            else if (txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Password!");
            }
            else if (!radioBtnAdmin.Checked && !radioBtnStaff.Checked)
            {
                MessageBox.Show("Please choose your position!");
            }
            else if (!controller.CheckUserExist(txtUserName.Text.Trim()))
            {
                AddNewStaff();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            CheckValidStaff();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
