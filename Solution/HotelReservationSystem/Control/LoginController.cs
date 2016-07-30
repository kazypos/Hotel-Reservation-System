﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Model;
using HotelReservationSystem.Entity;
using System.Windows.Forms;

namespace HotelReservationSystem.Control
{
    class LoginController
    {
        LoginModel model;
        Form view;
        public LoginController(Form view)
        {
            model = new LoginModel();
            this.view = view;
        }

        public bool Login(Login accountEntry)
        {
            return model.CheckLogin(accountEntry);
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
