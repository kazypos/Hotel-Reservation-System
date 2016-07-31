using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Administration.Model;
using HotelReservationSystem.Administration.View;
using System.Data;

namespace HotelReservationSystem.Administration.Control
{
    class PrintSummaryAdminController
    {
        PrintSummaryAdminModel model;

        public PrintSummaryAdminController()
        {
            model = new PrintSummaryAdminModel();
        }

        public DataTable Hotels { get { return model.Hotels; } }
        public DataTable RoomTypes { get { return model.RoomTypes; } }

        public DataTable Statistic(string hotelCode, string roomType, DateTime inDate, DateTime outDate)
        {
            return model.Statistic(hotelCode, roomType, inDate, outDate);
        }
    }
}
