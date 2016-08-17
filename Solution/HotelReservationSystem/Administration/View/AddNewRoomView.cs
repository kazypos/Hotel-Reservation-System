using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem.Administration.Control;
using HotelReservationSystem.Administration.Model;
namespace HotelReservationSystem.Administration.View
{
    public partial class AddNewRoomView : Form
    {
        AddNewRoomController control;
        public AddNewRoomView()
        {
            InitializeComponent();
            Init();
        }
        //string hotelcode;

        private void Init()
        {
            control = new AddNewRoomController();
            comboHotel.DisplayMember = "Name";
            comboHotel.ValueMember = "Code";
            comboHotel.DataSource = control.Hotels;

            comboRoomType.DisplayMember = "TypeName";
            comboRoomType.ValueMember = "TypeCode";
            comboRoomType.DataSource = control.RoomTypes;
        }

        private void AddNewRoom()
        {
            bool busy = false;
            //string hotelcode;
            int type = Convert.ToInt32(comboRoomType.SelectedValue.ToString());
            double price=Convert.ToDouble(txtPrice.Text);
            if (control.AddNewRoom(comboHotel.SelectedValue.ToString(), type, txtRoomNo.Text.ToString(), price,busy))
            {
                MessageBox.Show("The room has been save!");
                txtRoomNo.Text = txtPrice.Text = "";

            }
            else
            {
                txtRoomNo.SelectAll();
                txtPrice.SelectAll();
                MessageBox.Show("Add room fail!!!");
            }
        }

        private void CheckValidRoom()
        {

            if (txtRoomNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter room no!");
            }
            else if (txtPrice.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter price!");
            }
            else if (!control.CheckRoomExist(txtRoomNo.Text.Trim(), comboHotel.SelectedValue.ToString().Trim()))
            {
                AddNewRoom();
            }
            else
            {
                MessageBox.Show("The room is exist!");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            CheckValidRoom();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
