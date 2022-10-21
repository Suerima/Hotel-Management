using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.DTO;
using static WindowsFormsApp1.FormLogin;

namespace WindowsFormsApp1.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private AccountDAO() { }
        
        public DataTable GetAccount(string username)
        {
            try
            {
                string query = string.Format("EXEC USP_Get_Account '{0}'", username);
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool Login(string tbUsername, string tbPassword)
        {

            string query = string.Format("USP_Login '{0}' , '{1}'", tbUsername, tbPassword);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public bool ForgotAccount(string email)
        {
            string query = string.Format("EXEC USP_Forgot_Account '{0}'", email);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public int UpdateAccount(Account account, string path)
        {
            string query = "UPDATE Account " +
                           "SET Name = N'" + account.Name + "', Phone = '" + account.Phone + "', Email = '" + account.Email + "', Password = '" + account.Password + "', " +
                           "Avatar = (SELECT * FROM OPENROWSET(BULK'" + path + "', SINGLE_BLOB) AS Picture) " +
                           "WHERE Username = '" + account.Username + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int UpdatePassword(string password, string email)
        {
            string query = string.Format("USP_Update_Account '{0}' '{1}'", password, email);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
