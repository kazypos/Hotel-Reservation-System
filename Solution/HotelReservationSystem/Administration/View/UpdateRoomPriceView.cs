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
    public partial class UpdateRoomPriceView : Form
    {
        UpdateRoomPriceController control;

        private string hotelCode;
        private int roomTypeCode;

        private string roomNo;
        private double oldPrice;
        private double newPrice;

        public UpdateRoomPriceView()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            control = new UpdateRoomPriceController();

            comboHotel.DisplayMember = "Name";
            comboHotel.ValueMember = "Code";
            comboHotel.DataSource = control.Hotels;

            comboRoomType.DisplayMember = "TypeName";
            comboRoomType.ValueMember = "TypeCode";
            comboRoomType.DataSource = control.RoomTypes;
        }

        /// <summary>
        /// Load lai combox room associtate with hotel code and room type code
        /// </summary>
        private void ReloadRoom()
        {
            comboRoom.DisplayMember = "RoomNo";
            comboRoom.ValueMember = "Price";
            comboRoom.DataSource = control.Rooms(roomTypeCode, hotelCode);
        }

        private void UpdateRoomPrice()
        {

        }

        private void comboHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            hotelCode = comboHotel.SelectedValue.ToString();
            ReloadRoom();
        }

        private void comboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(comboRoomType.SelectedValue.ToString(), out roomTypeCode);
            ReloadRoom();
        }

        private void comboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOldPrice.Text = comboRoom.SelectedValue.ToString();

            double.TryParse(txtOldPrice.Text, out oldPrice);

            txtNewPrice.Text = txtOldPrice.Text;

            roomNo = ((DataTable)comboRoom.DataSource).Rows[comboRoom.SelectedIndex][0].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNewPrice.Text, out newPrice))
            {
                if (oldPrice != newPrice)
                {
                    // update price
                    if (control.UpdateNewPrice(roomNo, hotelCode, newPrice))
                    {
                        MessageBox.Show("Update new price successful!");
                        txtOldPrice.Text = newPrice.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Update new price fail!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please enter new Price");
                }
            }
            else
            {
                MessageBox.Show("New price invalid!");
                txtNewPrice.SelectAll();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
