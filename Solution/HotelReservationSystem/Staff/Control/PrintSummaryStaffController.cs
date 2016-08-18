using HotelReservationSystem.Staff.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Staff.Control
{
    class PrintSummaryStaffController
    {
        PrintSummaryStaffModel model;
        public PrintSummaryStaffController()
        {
            model = new PrintSummaryStaffModel();
        }
        public DataTable GetBookingWithDate(string customerName, DateTime Date) {
            return model.GetBookingWithDate(customerName,Date);
        }
    }
}
