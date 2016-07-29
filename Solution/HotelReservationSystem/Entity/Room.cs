using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Entity
{
    class Room
    {
        public string RoomNo { get; set; }
        public string HotelCode { get; set; }
        public int TypeCode { get; set; }
        public int Price { get; set; }
        public bool Busy { get; set; }

    }
}
