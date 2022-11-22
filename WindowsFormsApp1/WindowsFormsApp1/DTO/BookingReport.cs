using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class BookingReport
    {
        private string roomID;
        private DateTime dateCreate;
        private DateTime datePay;
        private int total;

        public string RoomID { get => roomID; set => roomID = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public DateTime DatePay { get => datePay; set => datePay = value; }
        public int Total { get => total; set => total = value; }


        public BookingReport() { }


        public BookingReport(string roomID, DateTime dateCreate, DateTime datePay, int total)
        {
            RoomID = roomID;
            DateCreate = dateCreate;
            DatePay = datePay;
            Total = total;
        }
    }
}
