using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    internal class LoginDB
    {
        Database db;

        public LoginDB()
        {
            db = new Database();
        }
        public DataTable activeLogin(string username, string password)
        {
            string sql = "SELECT * FROM Account WHERE Username = '" + username + "' AND Password = '" + password + "'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }
        
        public DataTable forgotLogin(string email)
        {
            string sql = "SELECT * FROM Account WHERE Email = N'" + email + "'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public void UpdatePassword(string password, string email)
        {
            string sql = "UPDATE ACCOOUNT SET Password = '" + password + "' WHERE Email = N'" + email + "'";
            db.ExecuteNonQuery(sql);
        }
        
    }
}
