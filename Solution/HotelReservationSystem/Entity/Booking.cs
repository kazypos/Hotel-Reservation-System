using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Entity
{
    class Booking
    {
        public int Code { get; set; }
        public string CustomerCode { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
