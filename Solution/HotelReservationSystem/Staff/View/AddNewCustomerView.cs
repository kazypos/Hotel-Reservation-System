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
    public partial class AddNewCustomerView : Form
    {
        AddNewCustomerController control;
        public AddNewCustomerView()
        {
            InitializeComponent();
            control = new AddNewCustomerController();
        }
        private void CheckValidCustomer()
        {
            if (txtCode.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter customer code!");
            }
            else if (control.CheckExist(txtCode.Text.Trim()))
            {
                MessageBox.Show("Code '" + txtCode.Text.Trim() + "' is existed");
            }
            else if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter customer name!");
            }
            else if (txtAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter address!");
            }
            else if (!control.CheckExist(txtCode.Text.Trim()))
            {
                AddNewCustomer();
            }

        }
        private void AddNewCustomer()
        {
            if (control.AddNewCustomer(txtCode.Text, txtName.Text, txtAddress.Text))
            {
                MessageBox.Show("Add new customer successful!");
                txtCode.Text = txtName.Text = txtAddress.Text = "";
                txtCode.Focus();
            }
            else
            {
                txtCode.SelectAll();
                MessageBox.Show("Add new customer failed!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CheckValidCustomer();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
