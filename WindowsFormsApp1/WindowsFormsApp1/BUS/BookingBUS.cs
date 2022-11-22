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
    public class BookingBUS
    {
        private static BookingBUS instance;
        public static BookingBUS Instance
        {

            get
            {
                if (instance == null)
                    instance = new BookingBUS();
                return BookingBUS.instance;
            }
            private set { instance = value; }
        }

        private BookingBUS() { }

        public string GetLastBookingID()
        {
            return BookingDAO.Instance.GetLastBookingID();
        }
        public DataTable GetBooking()
        {
            return BookingDAO.Instance.GetBooking();
        }
        public DataTable GetBookingInCheckOut()
        {
            return BookingDAO.Instance.GetBookingInCheckOut();
        }
        public DataTable SearchBooking(string bookingID)
        {
            return BookingDAO.Instance.SearchBooking(bookingID);
        }

        public int InsertBooking(Booking booking)
        {
            return BookingDAO.Instance.InsertBooking(booking);
        }

        public int DeleteBooking(string booking)
        {
            return BookingDAO.Instance.DeleteBooking(booking);
        }

        public int UpdateStatusRoom(string roomID, string status)
        {
            return BookingDAO.Instance.UpdateStatusRoom(roomID, status);
        }
    }
}
