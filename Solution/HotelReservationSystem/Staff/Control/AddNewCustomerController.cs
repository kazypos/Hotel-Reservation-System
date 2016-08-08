using HotelReservationSystem.Staff.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Staff.Control
{
    class AddNewCustomerController
    {
        AddNewCustomerModel model;

        public AddNewCustomerController()
        {
            model = new AddNewCustomerModel();
            
        }

        public bool AddNewCustomer(string customerCode, string customerName, string customerAddress)
        {
            return model.AddNewCustomer(customerCode,customerName,customerAddress);
        }
    }
}
