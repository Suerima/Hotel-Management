using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Account
    {
        private string username;
        private string password;
        private string email;
        private string name;
        private string phone;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }


        public Account() { }

        //, string email, string name, string phone
        public Account(string username, string password, string email, string name, string phone)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Name = name;
            this.Phone = phone;
        }
    }
}
