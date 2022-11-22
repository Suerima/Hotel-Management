using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Booking
    {
        private string bookingID;
        private string managerID;
        private string customerID;
        private string roomID;
        private DateTime arrival;
        //private string departure;

        public string BookingID { get => bookingID; set => bookingID = value; }
        public string ManagerID { get => managerID; set => managerID = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public string RoomID { get => roomID; set => roomID = value; }
        public DateTime Arrival { get => arrival; set => arrival = value; }

        public Booking() { }
        public Booking(string bookingID, string managerID, string customerID, string roomID, DateTime arrival)
        {
            BookingID = bookingID;
            ManagerID = managerID;
            CustomerID = customerID;
            RoomID = roomID;
            Arrival = arrival;
        }
    }
}
