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
    public partial class AdministrationView : Form
    {
        AdministrationController control;
        public AdministrationView()
        {
            Init();
        }

        public AdministrationView(string username)
        {
            Init();
            lblUsername.Text = username;
        }

        private void Init() {
            InitializeComponent();
            control = new AdministrationController(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewRoomType_Click(object sender, EventArgs e)
        {
            control.LoadForm(new AddNewRoomTypeView());
        }

        private void btnUpdateRoomPrice_Click(object sender, EventArgs e)
        {
            control.LoadForm(new UpdateRoomPriceView());
        }

        private void btnPrintSummnary_Click(object sender, EventArgs e)
        {
            control.LoadForm(new PrintSummaryAdminView());
        }
    }
}
