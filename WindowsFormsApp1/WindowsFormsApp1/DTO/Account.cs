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
        private string authority;
        private byte[] image;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Authority { get => authority; set => authority = value; }
        public byte[] Image { get => image; set => image = value; }

        public Account() { }


        //, string email, string name, string phone

        public Account(string username, string password, string email, string authority, byte[] image)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Authority = authority;
            this.Image = image;
        }
    }
}
