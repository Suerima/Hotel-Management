using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace WindowsFormsApp1.DAO
{
    public class DataProvider
    {
        private static DataProvider instance; // Ctrl + R + E đóng gói

        public static DataProvider Instance
        {

            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            } // chưa khỏi tạo nên chắc chắn null
            private set { instance = value; }  // chỉ nội bộ trong class này set dc data
        }

        private DataProvider() { } // để đảm bảo bên ngoài ko tác động được chỉ lấy ra thôi
        // -> kiến trúc design patern singleton


        private string connectionSTR = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLKS2;Integrated Security=True";

        //nếu nhiều paramater thuộc nhiều kiểu dữ liệu thì cho 1 mảng object 
        // Trả ra  các dòng kết quả
        public DataTable ExecuteQuery(string query, object[] parameter = null) //Trả về 1 bảng
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection); // cau truy van se thuc thi

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                // command.Parameters.AddWithValue("@userName", id); gán @uer = id
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command); // trung gian lay du lieu 

                    adapter.Fill(dt); // do du lieu vao data

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        // using Insert, Update, Delete
        // Trả về số dòng được thực thi
        public int ExecuteNonQuery(string query) // Trả về số dòng thành công
        {

            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection); // cau truy van se thuc thi query tại conn này

                // command.Parameters.AddWithValue("@userName", id);

                data = command.ExecuteNonQuery(); // trả về số dòng thành công

                connection.Close();
            }
            return data;
        }

        // Trả ra số dòng kết quả nhứ select count(*)
        public string ExecuteScalar(string query) // Đếm số lượng
        {
            string data;
            
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection); // cau truy van se thuc thi

                data = (string)command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}
