using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Administration.Model;

namespace HotelReservationSystem.Administration.Control
{
    class AddNewRoomTypeController
    {
        AddNewRoomTypeModel model;

        public AddNewRoomTypeController()
        {
            model = new AddNewRoomTypeModel();
        }

        public bool AddNewRoomType(string type)
        {
            return model.AddNewRoomType(type);
        }

        public bool CheckExist(string typeRoom)
        {
            return model.CheckExist(typeRoom);
        }
    }
}
