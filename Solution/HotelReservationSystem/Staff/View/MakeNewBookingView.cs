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
using System.Data;

namespace HotelReservationSystem.Staff.View
{
    public partial class MakeNewBookingView : Form
    {
        MakeNewBookingController control;
        // code of customer
        private string customerCode = "";

        // variable for show room avaiable
        private string hotelCode;
        private string roomType;
        private DateTime inDate;
        private DateTime outDate;
        ///////////////////////////

        private string roomNo;
        private double priceRoom;

        DataTable dataTable;

        public MakeNewBookingView()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            control = new MakeNewBookingController();

            comboHotel.DisplayMember = "Name";
            comboHotel.ValueMember = "Code";
            comboHotel.DataSource = control.Hotels;

            comboRoomType.DisplayMember = "TypeName";
            comboRoomType.ValueMember = "TypeCode";
            comboRoomType.DataSource = control.RoomTypes;

            // init inDate and outDate
            inDate = datePickerIn.Value.Date;
            outDate = datePickerOut.Value.Date;

            dataTable = new DataTable();
            dataTable.Columns.Add("HotelCode", typeof(string));
            dataTable.Columns.Add("RoomType", typeof(string));
            dataTable.Columns.Add("RoomNo", typeof(string));
            dataTable.Columns.Add("Price per night", typeof(double));
            dataTable.Columns.Add("Check in", typeof(DateTime));
            dataTable.Columns.Add("Check out", typeof(DateTime));
            dataTable.Columns.Add("Number of night(s)", typeof(int));
            dataTable.Columns.Add("Total price", typeof(double));


            dataGridViewRooms.DataSource = dataTable;
            dataGridViewRooms.Columns["HotelCode"].Visible = false;
            dataGridViewRooms.Columns["RoomType"].Visible = false;

        }

        private void SearchCustomerCode()
        {
            string customerName = control.CustomerName(txtCustomerCode.Text);
            customerName = customerName.Trim();
            if (!customerName.Equals(""))
            {
                // show cutomer name below
                txtCustomerName.Text = customerName;
                customerCode = txtCustomerCode.Text;
            }
            else
            {
                // do something else
                MessageBox.Show("Not found Customer code: " + txtCustomerCode.Text);
                txtCustomerCode.SelectAll();
                txtCustomerName.Text = "";
                customerCode = "";
            }
        }

        private void CreateBooking()
        {
            if (customerCode.Equals(""))
            {
                MessageBox.Show("Please provide customer code");
            }
            else
            {
                if (control.CreateBooking(customerCode, dataTable))
                {
                    MessageBox.Show("Booking successful!");
                }
                else
                {
                    MessageBox.Show("Booking failed!");
                }
            }

        }

        private void AddBook()
        {
            DataRow dr = dataTable.NewRow();

            dr["HotelCode"] = hotelCode;
            dr["RoomType"] = roomType;

            dr["RoomNo"] = roomNo;
            dr["Price per night"] = priceRoom;
            dr["Check in"] = inDate;
            dr["Check out"] = outDate;

            TimeSpan ts = outDate - inDate;
            int day = ts.Days + 1 > 0 ? ts.Days + 1 : 0;

            dr["Number of night(s)"] = day;
            dr["Total price"] = day * priceRoom;

            dataTable.Rows.Add(dr);
        }

        public void UpdateTotalAmount()
        {
            double total = 0;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                total += double.Parse(dataTable.Rows[i]["Total price"].ToString());
            }
            lblTotalAmount.Text = "Total amount (in $): " + total.ToString();
        }

        private void UpdateListRoomAvaiable()
        {
            //ClearListRoomAvaiable();

            listBoxRoom.DisplayMember = "RoomNo";
            listBoxRoom.ValueMember = "Price";
            listBoxRoom.DataSource = control.AvaiableRooms(hotelCode, roomType, inDate, outDate, dataTable);
        }
        private void ClearListRoomAvaiable()
        {
            listBoxRoom.DataSource = null;
            // listBoxRoom.Items.Clear();
        }

        private void txtCustomerCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SearchCustomerCode();
                ClearListRoomAvaiable(); ;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchCustomerCode();
            ClearListRoomAvaiable();
        }

        private void datePickerIn_ValueChanged(object sender, EventArgs e)
        {
            inDate = datePickerIn.Value.Date;
            ClearListRoomAvaiable();
        }

        private void datePickerOut_ValueChanged(object sender, EventArgs e)
        {
            outDate = datePickerOut.Value.Date;
            ClearListRoomAvaiable();
        }

        private void btnViewAvailableRooms_Click(object sender, EventArgs e)
        {
            UpdateListRoomAvaiable();

        }

        private void comboHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            hotelCode = comboHotel.SelectedValue.ToString();
            ClearListRoomAvaiable();
        }

        private void comboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomType = comboRoomType.SelectedValue.ToString();
            ClearListRoomAvaiable();
        }

        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            // show new form register customer and hide this form
            MessageBox.Show("This feature in progress develop");
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (listBoxRoom.Items.Count > 0)
            {
                roomNo = ((DataRowView)listBoxRoom.SelectedItem)[0].ToString();
                double.TryParse(listBoxRoom.SelectedValue.ToString(), out priceRoom);
                AddBook();
                UpdateListRoomAvaiable();
                UpdateTotalAmount();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CreateBooking();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
