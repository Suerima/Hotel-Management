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

        public List<Room> LoadRoomList()
        {
            List<Room> roomList = new List<Room>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_Get_Room");

            foreach(DataRow item in data.Rows)
            {
                Room room = new Room(item);
                roomList.Add(room);
            }

            return roomList;
        }    
        public string GetLastRoomID()
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("USP_Get_LastRoomID"); //
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
                return DataProvider.Instance.ExecuteQuery("USP_Get_Room_Booking"); //
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
                return DataProvider.Instance.ExecuteQuery("USP_Get_Room"); //
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
                string query = "USP_Search_Room @nameCol , @value"; //
                return DataProvider.Instance.ExecuteQuery(query, new object[] { nameCol, value }); ;
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
                string query = "USP_Insert_Room @RoomID , @Type , @Person , @Price , @Status , @Description"; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] {room.RoomID, room.Type, room.Person, room.Price, room.Status, room.Description});
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
                string query = "USP_Update_Room @RoomID , @Type , @Person , @Price , @Status , @Description"; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { room.RoomID, room.Type, room.Person, room.Price, room.Status, room.Description });
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
                string query = "USP_Delete_Room @RoomID";//
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] {roomID});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
