using System;
using System.Collections.Generic;
using System.Data;
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

        private int month;
        private int total;

        public string BookingID { get => bookingID; set => bookingID = value; }
        public string ManagerID { get => managerID; set => managerID = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public string RoomID { get => roomID; set => roomID = value; }
        public DateTime Arrival { get => arrival; set => arrival = value; }
    
        public int Month { get => month; set => month = value; }
        public int Total { get => total; set => total = value; }

        public Booking(DataRow row)
        {
            this.Month = (int)row["Month"];
            this.Total = (int)row["Total"]; 
        }


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
