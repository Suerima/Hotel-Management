using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    public class RoomBUS
    {
        private static RoomBUS instance;
        public static RoomBUS Instance
        {

            get
            {
                if (instance == null)
                    instance = new RoomBUS();
                return RoomBUS.instance;
            }
            private set { instance = value; }
        }
        private RoomBUS() { }
        public string GetLastRoomID()
        {
            return RoomDAO.Instance.GetLastRoomID();
        }

        public DataTable GetRoomInBooking()
        {
            return RoomDAO.Instance.GetRoomInBooking();
        }

        public DataTable GetRoom()
        {
            return RoomDAO.Instance.GetRoom();
        }

        public DataTable SearchRoom(string nameCol, string value)
        {
            return RoomDAO.Instance.SearchRoom(nameCol, value);
        }
        
        public int InsertRoom(Room room)
        {
            return RoomDAO.Instance.InsertRoom(room);
        }

        public int UpdateRoom(Room room)
        {
            return RoomDAO.Instance.UpdateRoom(room);
        }

        public int UpdateStatusRoom(string roomID, string status)
        {
            return RoomDAO.Instance.UpdateStatusRoom(roomID, status);
        }

        public int DeleteRoom(string roomID)
        {
            return RoomDAO.Instance.DeleteRoom(roomID);
        }
    }
}
