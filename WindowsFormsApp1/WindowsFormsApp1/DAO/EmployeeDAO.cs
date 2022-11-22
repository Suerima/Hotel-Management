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
                return DataProvider.Instance.ExecuteScalar("USP_Get_LastEmployeeID"); //
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
                return DataProvider.Instance.ExecuteQuery("USP_Get_Employee"); // 
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string GetStatusEmployee(string employeeID)
        {
            try
            {
                string query = "USP_Get_Status_Employee @EmployeeID "; // 
                return DataProvider.Instance.ExecuteScalar(query, new object[] {employeeID});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetEmployeeInService()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_Get_Employee_Service"); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SearchEmployee(string nameCol, string value)
        {
            try
            {
                string query = "USP_Search_Employee @nameCol , @value"; //
                return DataProvider.Instance.ExecuteQuery(query, new object[] {nameCol, value});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertEmployee(PersonalInfo per)
        {
            try
            {
                string query = "USP_Insert_Employee @PersonID , @Name , @Gender , @Dob , @Phone , @Address , @IDCard "; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] {per.PersonID, per.Name, per.Gender, per.Dob, per.Phone, per.Address, per.Idcard});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateEmployee(PersonalInfo per, string status)
        {
            try
            {
                string query = "USP_Update_Employee @PersonID , @Name , @Gender , @Dob , @Phone , @Address , @IDCard , @Status"; //

                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { per.PersonID, per.Name, per.Gender, per.Dob, per.Phone, per.Address, per.Idcard, status });
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
                string query = "USP_Update_Status_Employee @EmployeeID"; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { employeeID });
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
                string query = "USP_Delete_Person @EmployeeID"; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { employeeID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
