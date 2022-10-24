using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO(); return instance;
            }
            private set { instance = value; }
        }
        private CustomerDAO() { }

        public string GetLastCustomerID()
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("EXEC USP_Get_LastCustomerID");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetCustomer()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("EXEC USP_Get_Customer"); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetCustomerInService()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("EXEC USP_Get_CustomerInService ");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetCustomerInBooking()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("EXEC USP_Get_CustomerInBooking");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SearchCustomerInServiceInvoiceCheckOut(string customerID)
        {
            try
            {
                string query = string.Format("EXEC USP_Search_CustomerInServiceInvoice_CheckOut '{0}'", customerID);
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SearchCustomerInBookingCheckOut(string customerID)
        {
            try
            {
                string query = string.Format("EXEC USP_Search_CustomerInBooking_CheckOut '{0}'", customerID);
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SearchCustomer(string nameCol, string value)
        {
            try
            {
                string query = string.Format("EXEC USP_Search_Customer '{0}' , '{1}'", nameCol, value);
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertCustomer(Customer customer)
        {
            try
            {
                string query = string.Format("EXEC USP_Insert_Customer '{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', N'{6}'",
                                            customer.CustomerID, customer.Name, customer.Dob, customer.Gender, customer.IDCard, customer.Phone, customer.Address);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateCustomer(Customer customer)
        {
            try
            {
                string query = string.Format("EXEC USP_Update_Customer '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', N{6}",
                                             customer.CustomerID, customer.Name, customer.Dob, customer.Gender, customer.IDCard, customer.Phone, customer.Address);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteCustomer(string customerID)
        {
            try
            {
                string query = string.Format("EXEC USP_Delete_Customer '{0}'", customerID);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
