using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
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
        
        public DataTable GetListAccount()
        {
            try
            {
                string query = "USP_Get_ListAccount"; //
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAccount(string username)
        {
            try
            {
                string query = "USP_Get_Account @Username"; //
                return DataProvider.Instance.ExecuteQuery(query, new object[] {username});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetAuthority(string username)
        {
            try
            {
                string query = "USP_Get_Authority @Username"; //
                return DataProvider.Instance.ExecuteScalar(query, new object[] { username });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetPassword(string username)
        {
            try
            {
                string query = "USP_Get_Password @Username "; //
                return DataProvider.Instance.ExecuteScalar(query, new object[] {username});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable SearchAccount(string nameCol, string value)
        {
            try
            {
                string query = "USP_Search_Account @nameCol , @value "; //
                return DataProvider.Instance.ExecuteQuery(query, new object[] {nameCol, value });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SearchEmail(string email)
        {
            string query = "USP_Search_Email @Email "; //

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {email});

            return result.Rows.Count > 0;
        }

        public bool Login(string username, string password)
        {

            string query = "USP_Login_Account @Username , @Password "; //

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username, password});

            return result.Rows.Count > 0;
        }

        public bool ForgotAccount(string email, string username) 
        {
            string query = "USP_Forgot_Account @Email , @Username "; //

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {email, username});

            return result.Rows.Count > 0;
        }

        public int InsertAccount(Account a, PersonalInfo p)
        {
            try
            {
                string query = "USP_Insert_Account @PersonalID , @Name , @Gender , @Dob , @Address , @Phone , @IDCard , @Password , @Email , @Authority , @Avatar "; //

                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { p.PersonID, p.Name, p.Gender, p.Dob, p.Address, p.Phone, p.Idcard, a.Password, a.Email, a.Authority, a.Image });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateImage(string username, string filename)
        {
            try
            {
                byte[] imageData = null;
                // Read the file into a byte array
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    imageData = new Byte[fs.Length];
                    fs.Read(imageData, 0, (int)fs.Length);
                }

                string query = "USP_Update_Image @Username , @Avatar"; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, imageData });

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ChangePassword(string username, string password)
        {   
            try
            { 
                string query = "USP_Update_Password @Username , @Password "; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { username , password });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdatePassword(string password, string email)
        {
            try
            {
                string query = "USP_Update_Password_Mail @Password , @Email "; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] {password, email});
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
