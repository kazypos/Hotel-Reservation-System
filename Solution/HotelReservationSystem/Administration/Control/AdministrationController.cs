using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.Administration.Control
{
    class AdministrationController
    {
        Form view;
        public AdministrationController(Form view)
        {
            this.view = view;

        }
        public void LoadForm(Form frm)
        {
            frm.FormClosed += Event_FormClosed;
            view.Hide();
            frm.Show();
        }

        private void Event_FormClosed(object sender, FormClosedEventArgs e)
        {
            view.Show();
        }
    }
}
