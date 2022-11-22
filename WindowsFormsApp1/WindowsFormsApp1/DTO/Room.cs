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
        private int person;
        private int price;
        private string status;
        private string description;

        public string RoomID { get => roomID; set => roomID = value; }
        public string Type { get => type; set => type = value; }
        public int Person { get => person; set => person = value; }
        public int Price { get => price; set => price = value; }
        public string Status { get => status; set => status = value; }
        public string Description { get => description; set => description = value; }

        public Room() { }

        public Room(DataRow row)
        {
            this.RoomID = row["RoomID"].ToString();
            this.Type = row["Type"].ToString();
            this.Person = (int)row["Person"];
            this.Price = (int)row["Price"];
            this.Status = row["Status"].ToString();
            this.Description = row["Description"].ToString();
        }   

        public Room(string roomID, string type, int person, int price, string status, string description)
        {
            RoomID = roomID;
            Type = type;
            Person = person;
            Price = price;
            Status = status;
            Description = description;
        }
    }
}
