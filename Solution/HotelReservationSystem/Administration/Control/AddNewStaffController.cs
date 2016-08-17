using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Administration.Model;

namespace HotelReservationSystem.Administration.Control
{
    class AddNewStaffController
    {
        AddNewStaffModel model;
        public AddNewStaffController()
        {
            model = new AddNewStaffModel();
        }
        public bool AddNewStaff(string username,string password,bool role)
        {
            return model.AddNewStaff(username, password, role);
        }
        public bool CheckUserExist(string username)
        {
            return model.CheckUserExist(username);
        }
    }
}
