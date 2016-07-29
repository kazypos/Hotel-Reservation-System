using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HotelReservationSystem.Model
{
    class DatabaseConfig
    {
        public static readonly string connectionString = ConfigurationManager.
            ConnectionStrings["HotelReservationConnnectionString"].
            ConnectionString.ToString();
    }
}
