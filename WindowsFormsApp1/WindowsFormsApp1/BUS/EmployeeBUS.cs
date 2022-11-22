using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    public class EmployeeBUS
    {
        private static EmployeeBUS instance;
        public static EmployeeBUS Instance
        {

            get
            {
                if (instance == null)
                    instance = new EmployeeBUS();
                return EmployeeBUS.instance;
            }
            private set { instance = value; }
        }
        private EmployeeBUS() { }

        public string GetLastEmployeeID()
        {
            return EmployeeDAO.Instance.GetLastEmployeeID();
        }

        public DataTable GetEmployee()
        {
            return EmployeeDAO.Instance.GetEmployee();
        }
        public string GetStatusEmployee(string employeeID)
        {
            return EmployeeDAO.Instance.GetStatusEmployee(employeeID);
        }
        public DataTable GetEmployeeInService()
        {
            return EmployeeDAO.Instance.GetEmployeeInService();
        }

        public DataTable SearchEmployee(string nameCol, string value)
        {
            return EmployeeDAO.Instance.SearchEmployee(nameCol, value);
        }

        public int InsertEmployee(PersonalInfo person)
        {
            return EmployeeDAO.Instance.InsertEmployee(person);
        }

        public int UpdateEmployee(PersonalInfo person, string status)
        {
            return EmployeeDAO.Instance.UpdateEmployee(person, status);
        }

        public int UpdateEmployeeStatus(string employeeID)
        {
            return EmployeeDAO.Instance.UpdateEmployeeStatus(employeeID);
        }

        public int DeleteEmployee(string employeeID)
        {
            return EmployeeDAO.Instance.DeleteEmployee(employeeID);
        }
    }
}
