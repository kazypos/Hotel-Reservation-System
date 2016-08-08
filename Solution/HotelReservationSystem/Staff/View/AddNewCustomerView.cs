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
        
        private void AddNewCustomer()
        {
           
            if (control.AddNewCustomer(txtCode.Text,txtName.Text,txtAddress.Text))
            {
                MessageBox.Show("Add new customer successful!");
                groupBox1.ResetText();
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
            AddNewCustomer();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
