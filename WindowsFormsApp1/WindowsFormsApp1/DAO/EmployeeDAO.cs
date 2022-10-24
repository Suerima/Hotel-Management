using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;
using static WindowsFormsApp1.FormLogin;

namespace WindowsFormsApp1.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeDAO(); return instance;
            }
            private set { instance = value; }
        }
        private EmployeeDAO() { }
        public string GetLastEmployeeID()
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("EXEC USP_Get_LastEmployeeID");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetEmployee()
        {
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuery("EXEC USP_Get_Employee");
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetEmployeeInService()
        {
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuery("EXEC USP_Get_EmployeeInService");
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SearchEmployee(string name)
        {
            try
            {
                string query = string.Format("EXEC USP_Search_Employee N'{0}'", name);
                DataTable dt = DataProvider.Instance.ExecuteQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertEmployee(Employee employee)
        {
            try
            {
                string query = string.Format("EXEC USP_Insert_Employee '{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', N'{6}'",
                                            employee.EmployeeID, employee.Name, employee.Dob, employee.Gender, employee.IDCard, employee.Phone, employee.Address);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateEmployee(Employee employee)
        {
            try
            {
                string query = string.Format("EXEC USP_Update_Employee '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', N{6}",
                                             employee.EmployeeID, employee.Name, employee.Dob, employee.Gender, employee.IDCard, employee.Phone, employee.Address);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateEmployeeStatus(string employeeID)
        {
            try
            {
                string query = string.Format("EXEC USP_Update_EmployeeStatus {0}", employeeID);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteEmployee(string employeeID)
        {
            try
            {
                string query = string.Format("EXEC USP_Delete_Employee '{0}'", employeeID);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
