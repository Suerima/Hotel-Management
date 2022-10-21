using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Employee
    {
        private string employeeID;
        private string name;
        private string dob;
        private string gender;
        private string iDCard;
        private string phone;
        private string address;

        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string Name { get => name; set => name = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Gender { get => gender; set => gender = value; }
        public string IDCard { get => iDCard; set => iDCard = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }

        // Constructor
        public Employee() { }
        public Employee(string employee_ID, string name, string dob, string gender, string iDCard, string phone, string address)
        {
            this.EmployeeID = employee_ID;
            this.Name = name;
            this.Dob = dob;
            this.Gender = gender;
            this.IDCard = iDCard;
            this.Phone = phone;
            this.Address = address;
        }
    }
}
