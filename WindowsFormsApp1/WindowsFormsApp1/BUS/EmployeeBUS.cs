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

        public DataTable SearchEmployee(string name)
        {
            return EmployeeDAO.Instance.SearchEmployee(name);
        }

        public int InsertEmployee(Employee Employee)
        {
            return EmployeeDAO.Instance.InsertEmployee(Employee);
        }

        public int UpdateEmployee(Employee Employee)
        {
            return EmployeeDAO.Instance.UpdateEmployee(Employee);
        }

        public int DeleteEmployee(string employeeID)
        {
            return EmployeeDAO.Instance.DeleteEmployee(employeeID);
        }
    }
}
