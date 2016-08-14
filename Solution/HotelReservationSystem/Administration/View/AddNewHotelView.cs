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
            }
            else
            {
                txtCode.SelectAll();
                txtName.SelectAll();
                txtAddress.SelectAll();
                MessageBox.Show("Add hotel fail!!!!");
            }
        }

        private void CheckValidHotel()
        {
            if (txtCode.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter hotelcode!");
            }
            else if (control.CheckExistCode(txtCode.Text.Trim()))
            {
                MessageBox.Show("Code '" + txtCode.Text.Trim() + "' is existed");
            }
            else if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter hotelname!");
            }
            //else if (control.CheckExistName(txtName.Text.Trim()))
            //{
            //    MessageBox.Show("Name '" + txtName.Text.Trim() + "' is existed");
            //}
            else if (txtAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter address!");
            }
            else if (!control.CheckExistCode(txtCode.Text.Trim())
                //&& !control.CheckExistName(txtName.Text.Trim())
                )
            {
                AddNewHotel();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CheckValidHotel();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
