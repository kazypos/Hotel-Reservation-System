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
            this.Activated += LoginView_Activated;
        }

        private void LoginView_Activated(object sender, EventArgs e)
        {
            txtUserName.Focus();
            txtUserName.SelectAll();
        }

        private void LoginProcess()
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
                    control.LoadForm(new AdministrationView(txtUserName.Text));
                }
                else
                {
                    control.LoadForm(new StaffView(txtUserName.Text));
                }
            }
            else
            {
                MessageBox.Show("Login failed!");
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPassword.Focus();
            }

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LoginProcess();
            }
        }
    }
}
