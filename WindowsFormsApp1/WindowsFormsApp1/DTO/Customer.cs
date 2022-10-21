using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Customer
    {
        private string customerID;
        private string name;
        private string dob;
        private string gender;
        private string iDCard;
        private string phone;
        private string address;

        public string CustomerID { get => customerID; set => customerID = value; }
        public string Name { get => name; set => name = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Gender { get => gender; set => gender = value; }
        public string IDCard { get => iDCard; set => iDCard = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }

        public Customer() { }
        public Customer(string customerID, string name, string dob, string gender, string iDCard, string phone, string address)
        {
            this.CustomerID = customerID;
            this.Name = name;
            this.Dob = dob;
            this.Gender = gender;
            this.IDCard = iDCard;
            this.Phone = phone;
            this.Address = address;
        }
    }
}
