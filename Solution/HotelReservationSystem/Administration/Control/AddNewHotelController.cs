using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Administration.Model;

namespace HotelReservationSystem.Administration.Control
{
    class AddNewHotelController
    {
        AddNewHotelModel model;
        public AddNewHotelController()
        {
            model = new AddNewHotelModel();
        }
        public bool AddNewHotel(string code,string name,string address)
        {
            return model.AddNewHotel(code,name,address);
        }
        public bool CheckExistName(string name)
        {
            return model.CheckExistName(name);
        }
        public bool CheckExistCode(string code)
        {
            return model.CheckExistCode(code);
        }
    }
}
