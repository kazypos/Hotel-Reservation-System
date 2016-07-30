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
using HotelReservationSystem.Administration.View;
using HotelReservationSystem.Staff.View;


namespace HotelReservationSystem.View
{
    public partial class LoginView : Form
    {
        LoginController control;
        public LoginView()
        {
            InitializeComponent();
            control = new LoginController(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.LoginId = txtUserName.Text;
            l.LoginPassword = txtPassword.Text;
            l.Roles = radioBtnAdmin.Checked;
            if (control.Login(l))
            {
                txtPassword.Text = "";
                MessageBox.Show("Login successful!");
                // do something
                if (l.Roles)
                {
                    control.LoadForm(new AdministrationView());
                }
                else
                {
                    control.LoadForm(new StaffView());
                }
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
