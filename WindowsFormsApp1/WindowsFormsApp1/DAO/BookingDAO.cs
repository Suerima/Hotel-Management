using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class BookingDAO
    {
        private static BookingDAO instance; // Ctrl + R + E đóng gói

        public static BookingDAO Instance
        {
            get
            {
                if (instance == null)              // chưa khỏi tạo nên chắc chắn null
                    instance = new BookingDAO();
                return BookingDAO.instance;
            }
            private set { instance = value; }      // chỉ nội bộ trong class này set dc data
        }

        private BookingDAO() { }

        public string GetLastBookingID()
        {
            try
            {
                string query = "USP_Get_LastBookingID"; //
                return DataProvider.Instance.ExecuteScalar(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetBooking()
        {
            try
            {
                string query = "USP_Get_Booking"; //
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetBookingInCheckOut()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_Get_Booking_CheckOut"); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SearchBooking(string bookingID)
        {
            try
            {
                string query = "USP_Search_Booking @BookingID "; //
                return DataProvider.Instance.ExecuteQuery(query, new object[] {bookingID});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertBooking(Booking booking)
        {
            try
            {
                string query = "USP_Insert_Booking @BookingID , @ManagerID , @CustomerID , @RoomID , @Arrival "; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] {booking.BookingID, booking.ManagerID, booking.CustomerID, booking.RoomID, booking.Arrival});
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteBooking(string bookingID)
        {
            try
            {
                string query = "USP_Delete_Booking @Booking "; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] {bookingID});
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
                string query = "USP_Update_Status_Room @RoomID , @Status"; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] {roomID, status});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
