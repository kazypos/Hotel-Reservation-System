using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Administration.Model;
using System.Data;

namespace HotelReservationSystem.Administration.Control
{
    class AddNewRoomController
    {
        AddNewRoomModel model;
        public AddNewRoomController()
        {
            model = new AddNewRoomModel();
        }

        public DataTable Hotels { get { return model.Hotels; } }
        public DataTable RoomTypes { get { return model.RoomTypes; } }
        public bool AddNewRoom(string hotelcode, int type, string roomno, double price, bool busy)
        {
            return model.AddNewRoom(hotelcode, type, roomno, price, busy);
        }

        public bool CheckRoomExist(string roomno)
        {
            return model.CheckRoomExist(roomno);
        }
    }
}
