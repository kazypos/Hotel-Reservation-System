using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem.Control;
using HotelReservationSystem.Entity;

namespace HotelReservationSystem.View
{
    public partial class LoginView : Form
    {
        LoginController lc;
        public LoginView()
        {
            InitializeComponent();
            lc = new LoginController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.LoginId = txtUserName.Text;
            l.LoginPassword = txtPassword.Text;
            l.Roles = radioBtnAdmin.Checked;
            if (lc.Login(l))
            {
                txtPassword.Text = "";
                MessageBox.Show("Login successful!");
                // do something

            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
