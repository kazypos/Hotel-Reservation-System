﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem.Staff.Control;

namespace HotelReservationSystem.Staff.View
{
    public partial class StaffView : Form
    {
        StaffController control;
        public StaffView()
        {
            InitializeComponent();
            control = new StaffController(this);
        }
        public void loadSomeThing()
        {
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
