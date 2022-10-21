using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;
        public static RoomDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoomDAO(); return instance;
            }
            private set { instance = value; }
        }
        private RoomDAO() { }
        public string GetLastRoomID()
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("EXEC USP_Get_LastRoomID");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetRoomInBooking()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("EXEC USP_Get_RoomInBooking");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetRoom()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("EXEC USP_Get_Room");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SearchRoom(string nameCol, string value)
        {
            try
            {
                string query = string.Format("EXEC USP_Search_Room '{0}', '{1}'", nameCol, value);
                DataTable dt = DataProvider.Instance.ExecuteQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertRoom(Room room)
        {
            try
            {
                string query = string.Format("EXEC USP_Insert_Room '{0}', N'{1}', '{2}', '{3}', '{4}', N'{5}'",
                                            room.RoomID, room.Type, room.Person, room.Price, room.Status, room.Description);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateRoom(Room room)
        {
            try
            {
                string query = string.Format("EXEC USP_Update_Room '{0}', '{1}', '{2}', '{3}', '{4}', N'{5}'",
                                             room.RoomID, room.Type, room.Person, room.Price, room.Status, room.Description);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateStatusRoom(string roomID, string status)
        {
            try
            {
                string query = string.Format("EXEC USP_Update_RoomStatus '{0}', '{1}'",
                                             roomID , status);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteRoom(string roomID)
        {
            try
            {
                string query = string.Format("EXEC USP_Delete_Room '{0}'", roomID);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
