using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Room
    {
        private string roomID;
        private string type;
        private string person;
        private int price;
        private string status;

        public string RoomID { get => roomID; set => roomID = value; }
        public string Type { get => type; set => type = value; }
        public int Price { get => price; set => price = value; }
        public string Status { get => status; set => status = value; }
        public string Person { get => person; set => person = value; }

        public Room() { }

        public Room(DataRow row)
        {
            this.RoomID = row["RoomID"].ToString();
            this.Type = row["Type"].ToString();
            this.Person = row["Person"].ToString();
            this.Price = (int)row["Price"];
            this.Status = row["Status"].ToString();
        }   

        public Room(string roomID, string type, string person, int price, string status)
        {
            RoomID = roomID;
            Type = type;
            Person = person;
            Price = price;
            Status = status;
        }
    }
}
