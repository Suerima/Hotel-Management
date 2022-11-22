using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Principal;
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

        public bool SearchEmail(string email)
        {
            return AccountDAO.Instance.SearchEmail(email);
        }

        public DataTable GetListAccount()
        {
            return AccountDAO.Instance.GetListAccount();
        }

        public DataTable GetAccount(string username)
        {
            return AccountDAO.Instance.GetAccount(username);
        }

        public string GetAuthority(string username)
        {
            return AccountDAO.Instance.GetAuthority(username);

        }

        public string GetPassword(string username)
        {
            return AccountDAO.Instance.GetPassword(username);
        }
        public DataTable SearchAccount(string nameCol, string value)
        {
            return AccountDAO.Instance.SearchAccount(nameCol, value);
        }
        public int InsertAccount(Account account, PersonalInfo perInfo)
        {
            return AccountDAO.Instance.InsertAccount(account, perInfo);
        }

        public int UpdateImage(string username, string filename)
        {
             return AccountDAO.Instance.UpdateImage(username, filename);
        }

        public int ChangePassword(string username, string password)
        {
            return AccountDAO.Instance.ChangePassword(username, password);
        }

        public int UpdatePassword(string password, string email)
        {
            return AccountDAO.Instance.UpdatePassword(password, email);
        }
    }
}
