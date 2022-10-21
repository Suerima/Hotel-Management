using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                return DataProvider.Instance.ExecuteScalar("EXEC USP_Get_LastBookingID");
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
                return DataProvider.Instance.ExecuteQuery("EXEC USP_Get_Booking");
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
                string query = string.Format("EXEC USP_Search_Booking '{0}'", bookingID);
                return DataProvider.Instance.ExecuteQuery(query);
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
                string query = string.Format("EXEC USP_Insert_Booking '{0}', N'{1}', '{2}', '{3}', '{4}'",
                                            booking.BookingID, booking.ManagerID, booking.CustomerID, booking.RoomID, booking.Arrival);
                return DataProvider.Instance.ExecuteNonQuery(query);
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
                string query = string.Format("EXEC USP_Delete_Booking '{0}'", bookingID);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
