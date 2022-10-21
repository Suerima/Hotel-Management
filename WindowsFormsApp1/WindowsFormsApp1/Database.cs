using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    internal class Database
    {
        private SqlConnection connection;
        private SqlDataAdapter da;
        private DataSet ds;

        public Database()
        {
            string strCnn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLKS2;Integrated Security=True";
            connection = new SqlConnection(strCnn);
        }
        //select
        public DataTable ExecuteQuery(string sql)
        {
            da = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        //insert, update, delete
        public void ExecuteNonQuery(string sql)
        {
            SqlCommand sqlcmd = new SqlCommand(sql, connection); //Lệnh của ADO.net thực hiện lệnh sql
            connection.Open();
            sqlcmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
