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
            InitializeComponent();
            control = new AdministrationController(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
