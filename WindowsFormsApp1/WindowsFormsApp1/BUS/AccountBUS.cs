using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using static WindowsFormsApp1.FormLogin;

namespace WindowsFormsApp1.BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;
        public static AccountBUS Instance
        {

            get
            {
                if (instance == null)
                    instance = new AccountBUS();
                return AccountBUS.instance;
            }
            private set { instance = value; }
        }
        private AccountBUS() { }

        public bool Login(string tbUsername, string tbPassword)
        {
            return AccountDAO.Instance.Login(tbUsername, tbPassword);
        }

        public bool ForgotAccount(string email, string username)
        {
            return AccountDAO.Instance.ForgotAccount(email, username);
        }

        public DataTable GetAccount(string username)
        {
            return AccountDAO.Instance.GetAccount(username);
        }
        public int UpdateAccount(Account account, string path)
        {
            return AccountDAO.Instance.UpdateAccount(account, path);
        }

        public int UpdatePassword(string password, string email)
        {
            return AccountDAO.Instance.UpdatePassword(password, email);
        }
    }
}
