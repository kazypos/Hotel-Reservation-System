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
    public partial class AddNewRoomTypeView : Form
    {
        AddNewRoomTypeController control;
        public AddNewRoomTypeView()
        {
            InitializeComponent();
            control = new AddNewRoomTypeController();
        }

        private void AddNewRoomType() {
            if (control.AddNewRoomType(txtTypeName.Text))
            {
                MessageBox.Show("Add new room type successful!");
                txtTypeName.Text = "";
                txtTypeName.Focus();
            }
            else
            {
                txtTypeName.SelectAll();
                MessageBox.Show("Add new room type failed!");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            AddNewRoomType();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTypeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== Convert.ToChar(Keys.Enter))
            {
                AddNewRoomType();
            }
        }
    }
}
