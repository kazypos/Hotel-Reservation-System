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

        private void CheckValidTypeRoom() {
            if (txtTypeName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter room type!");
            }
            else
            {
                if (!control.CheckExist(txtTypeName.Text.Trim()))
                {
                    AddNewRoomType();
                }
                else
                {
                    MessageBox.Show("Room type \"" + txtTypeName.Text.Trim() + "\" existed");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CheckValidTypeRoom();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
