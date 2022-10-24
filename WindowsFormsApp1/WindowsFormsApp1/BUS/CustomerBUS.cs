using Newtonsoft.Json.Linq;
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
    public class CustomerBUS
    {
        private static CustomerBUS instance;
        public static CustomerBUS Instance
        {

            get
            {
                if (instance == null)
                    instance = new CustomerBUS();
                return CustomerBUS.instance;
            }
            private set { instance = value; }
        }
        private CustomerBUS() { }

        public string GetLastCustomerID()
        {
            return CustomerDAO.Instance.GetLastCustomerID();
        }
        public DataTable GetCustomer()
        {
            return CustomerDAO.Instance.GetCustomer();
        }
        public DataTable GetCustomerInService()
        {
            return CustomerDAO.Instance.GetCustomerInService();
        }

        public DataTable GetCustomerInBooking()
        {
            return CustomerDAO.Instance.GetCustomerInBooking();
        }

        public DataTable SearchCustomer(string nameCol, string value)
        {
            return CustomerDAO.Instance.SearchCustomer(nameCol, value);
        }

        public DataTable SearchCustomerInServiceInvoiceCheckOut(string customerID)
        {
            return CustomerDAO.Instance.SearchCustomerInServiceInvoiceCheckOut(customerID);
        }

        public DataTable SearchCustomerInBookingCheckOut(string customerID)
        {
            return CustomerDAO.Instance.SearchCustomerInBookingCheckOut(customerID);
        }

        public int InsertCustomer(Customer customer)
        {
            return CustomerDAO.Instance.InsertCustomer(customer);
        }

        public int UpdateCustomer(Customer customer)
        {
            return CustomerDAO.Instance.UpdateCustomer(customer);
        }

        public int DeleteCustomer(string customerID)
        {
            return CustomerDAO.Instance.DeleteCustomer(customerID);
        }
    }
}
