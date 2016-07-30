using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HotelReservationSystem.Administration.Model;
using HotelReservationSystem.Administration.View;
using HotelReservationSystem.Entity;

namespace HotelReservationSystem.Administration.Control
{
    class UpdateRoomPriceController
    {
        UpdateRoomPriceModel model;
        public UpdateRoomPriceController()
        {
            model = new UpdateRoomPriceModel();
        }
        public DataTable Hotels { get { return model.Hotels; } }
        public DataTable RoomTypes { get { return model.RoomTypes; } }

        public DataTable Rooms(int typeCode, string hotelCode)
        {
            return model.Rooms(typeCode, hotelCode);
        }

        public bool UpdateNewPrice(string roomNo, string hotelCode, double newPrice)
        {
            return model.UpdateNewPrice(roomNo, hotelCode, newPrice);
        }
    }
}
