using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class PersonalInfo
    {
        private string personID;
        private string name;
        private string gender;
        private DateTime dob;
        private string address;
        private string phone;
        private string idcard;

        public string PersonID { get => personID; set => personID = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Idcard { get => idcard; set => idcard = value; }

        public PersonalInfo() { }

        public PersonalInfo(string personID, string name, string gender, DateTime dob, string address, string phone, string idcard)
        {
            this.PersonID = personID;
            this.Name = name;
            this.Gender = gender;
            this.Dob = dob;
            this.Address = address;
            this.Phone = phone;
            this.Idcard = idcard;
        }
    }
}
