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
    public partial class AddNewHotelView : Form
    {
        AddNewHotelController control;
        public AddNewHotelView()
        {
            InitializeComponent();
            control = new AddNewHotelController();
        }
        private void AddNewHotel()
        {
            if (control.AddNewHotel(txtCode.Text, txtName.Text, txtAddress.Text))
            {
                MessageBox.Show("A new hotel has been added!!!");
                txtCode.Text = txtName.Text = txtAddress.Text = "";
                txtCode.Focus();
                txtName.Focus();
                txtAddress.Focus();
            }
            else
            {
                txtCode.SelectAll();
                txtName.SelectAll();
                txtAddress.SelectAll();
                MessageBox.Show("Add hotel fail!!!!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddNewHotel();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
