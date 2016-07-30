using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HotelReservationSystem.Model;
using System.Windows.Forms;

namespace HotelReservationSystem.Administration.Model
{
    class AddNewRoomTypeModel
    {
        public bool AddNewRoomType(string typeName)
        {
            if (CheckExist(typeName))
            {
                return false;
            }
            bool result = false;

            string sql = "INSERT INTO RoomType(TypeName) VALUES(@type)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DatabaseConfig.OpenConnection();
            cmd.Parameters.AddWithValue("@type", typeName);

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                result = true;
            }

            DatabaseConfig.CloseConnection();

            return result;
        }

        private bool CheckExist(string typeRoom)
        {
            bool result = false;

            string sql = "SELECT * FROM RoomType WHERE TypeName='" + typeRoom + "'";
            SqlCommand cmd = new SqlCommand(sql, DatabaseConfig.OpenConnection());
            SqlDataReader dr= cmd.ExecuteReader();
            if (dr.Read())
            {
                result = true;
            }
            DatabaseConfig.CloseConnection();
            return result;
        }
    }
}
