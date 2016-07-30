using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Model;
using HotelReservationSystem.Entity;

namespace HotelReservationSystem.Control
{
    class LoginController
    {
        LoginModel lm;
        public LoginController()
        {
            lm = new LoginModel();
        }

        public bool Login(Login accountEntry)
        {
            return lm.CheckLogin(accountEntry);
        }
    }
}
