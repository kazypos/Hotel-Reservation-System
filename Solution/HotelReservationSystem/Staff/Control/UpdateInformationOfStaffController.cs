using HotelReservationSystem.Staff.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Staff.Control
{
    class UpdateInformationOfStaffController
    {
        UpdateInformationOfStaffModel model;
        public UpdateInformationOfStaffController()
        {
            model = new UpdateInformationOfStaffModel();
        }
        public bool UpdatePassword(string username, string old, string new1)
        {
            return model.UpdatePassword(username,old,new1);
        }
        public bool CheckExist(string UserName, string PassWord)
        {

            return model.CheckExist(UserName,PassWord);
        }
    }
}
