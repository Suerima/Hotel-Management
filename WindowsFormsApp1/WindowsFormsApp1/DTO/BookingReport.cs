using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class BookingReport
    {
        private string roomID;
        private string type;
        private DateTime dateCreate;
        private DateTime datePay;
        private int total;
        private string totalL;


        public string RoomID { get => roomID; set => roomID = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public DateTime DatePay { get => datePay; set => datePay = value; }
        public int Total { get => total; set => total = value; }
        public string Type { get => type; set => type = value; }
        public string TotalL { get => totalL; set => totalL = value; }


        public BookingReport(DataRow row)
        {
            this.Type = row["Type"].ToString();
            this.TotalL = row["Total"].ToString();
        }

        public BookingReport(string roomID, DateTime dateCreate, DateTime datePay, int total)
        {
            RoomID = roomID;
            DateCreate = dateCreate;
            DatePay = datePay;
            Total = total;
        }
    }
}
