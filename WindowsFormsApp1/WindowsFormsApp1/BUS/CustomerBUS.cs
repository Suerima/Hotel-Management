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

        public string GetCustomerID(string customerID)
        {
            return CustomerDAO.Instance.GetCustomerID(customerID);

        }

        public string GetCustomerIDInBooking(string customerID)
        {
            return CustomerDAO.Instance.GetCustomerIDInBooking(customerID);
        }
        public DataTable SearchCustomer(string nameCol, string value)
        {
            return CustomerDAO.Instance.SearchCustomer(nameCol, value);
        }
        public DataTable SearchCustomerInService(string name)
        {
            try
            {
                return CustomerDAO.Instance.SearchCustomerInService(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable SearchRoomInServiceInvoiceCheckOut(string roomID)
        {
            return CustomerDAO.Instance.SearchRoomInServiceInvoiceCheckOut(roomID);
        }

        public DataTable SearchRoomInBookingCheckOut(string roomID)
        {
            return CustomerDAO.Instance.SearchRoomInBookingCheckOut(roomID);
        }

        public int InsertCustomer(PersonalInfo person)
        {
            return CustomerDAO.Instance.InsertCustomer(person);
        }

        public int UpdateCustomer(PersonalInfo person)
        {
            return CustomerDAO.Instance.UpdateCustomer(person);
        }

    }
}
