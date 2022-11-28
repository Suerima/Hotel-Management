using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                roomList.Add(room);
            }

            return roomList;
        }

        public List<Room> LoadAmenitiesRoomList(string result, int length, string type, string person)
        {
            List<Room> roomList = new List<Room>();

            string query = "SELECT Room.* " +
                           "FROM Room, (SELECT RoomID " +
                                       "FROM (SELECT * FROM DetailRoom WHERE " + result + " ) AS A " +
                                       "GROUP BY RoomID " +
                                       "HAVING COUNT(DetailID) = " + length.ToString() + ") B " +
                           "WHERE Room.RoomID = B.RoomID AND (Type = '" + type + "' ) AND Person = '" + person + "' ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                roomList.Add(room);
            }

            return roomList;
        }


        public ArrayList LoadListImages(string roomID)
        {
          //  List<Image> imageList = new List<Image>();
            ArrayList alist = new ArrayList();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_Get_Path @RoomID", new object[] {roomID});

            foreach (DataRow item in data.Rows)
            {
                Image path = new Image(item);
                alist.Add(path.Path);
            }

            return alist;
        }

        public DataTable GetRoomService(string customerid)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_Get_Room_Service @CustomerID", new object[] {customerid}); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetPersonRoom(string roomid)
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("USP_Get_Person_Room @RoomID", new object[] { roomid }); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetTypeRoom(string roomid)
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("USP_Get_Type_Room @RoomID", new object[] { roomid }); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetFirstPath(string roomid)
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("USP_Get_Path @RoomID", new object[] {roomid}); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        public void InsertListImageRoom(string roomid, ArrayList lstPath, int count)
        {
            try
            {
               

                string query = "USP_Insert_Images_Room @RoomID , @Path";
                for (int i = 0; i < count; i++)
                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { roomid, lstPath[i] });

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertImageRoom(string roomid, string filename)
        {
            try
            {
                /*byte[] imageData = null;
                // Read the file into a byte array
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    imageData = new Byte[fs.Length];
                    fs.Read(imageData, 0, (int)fs.Length);
                }*/

                string query = "USP_Insert_Images_Room @RoomID , @Path"; //
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { roomid, filename });

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InsertDetailRoom(string[] lstDetails, string roomid)
        {
            try
            {
                string query = "USP_Insert_DetailRoom @DetailID , @RoomID"; //
                for(int i = 0; i < lstDetails.Length; i++)
                     DataProvider.Instance.ExecuteQuery(query, new object[] { lstDetails[i], roomid });
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
                string query = "USP_Insert_Room @RoomID , @Type , @Person , @Price , @Status "; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] {room.RoomID, room.Type, room.Person, room.Price, room.Status});
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
                string query = "USP_Update_Room @RoomID , @Type , @Person , @Price , @Status"; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { room.RoomID, room.Type, room.Person, room.Price, room.Status});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteDetailRoom(string roomID)
        {
            try
            {
                string query = "USP_Delete_DetailRoom @RoomID";//
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { roomID });
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
