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
                return DataProvider.Instance.ExecuteScalar("USP_Get_LastCustomerID"); //
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
                return DataProvider.Instance.ExecuteQuery("USP_Get_Customer"); //
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
                return DataProvider.Instance.ExecuteQuery("USP_Get_Customer_Service"); //
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
                return DataProvider.Instance.ExecuteQuery("USP_Get_Customer_Booking"); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetCustomerID(string customerID)
        {
            try
            {
                string query = "USP_Get_CustomerID @CustomerID";//
                return DataProvider.Instance.ExecuteScalar(query, new object[] {customerID}); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetCustomerIDInBooking(string customerID)
        {
            try
            {
                string query = "USP_Get_CustomerID_Booking @CustomerID";//
                return DataProvider.Instance.ExecuteScalar(query, new object[] { customerID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SearchRoomInServiceInvoiceCheckOut(string roomID)
        {
            try
            {
                string query = "USP_Search_Room_ServiceInvoice_CheckOut @CustomerID";//
                return DataProvider.Instance.ExecuteQuery(query, new object[] { roomID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SearchRoomInBookingCheckOut(string roomID) 
        {
            try
            {
                string query = "USP_Search_Room_Booking_CheckOut @RoomID";//
                return DataProvider.Instance.ExecuteQuery(query, new object[] { roomID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SearchCustomerInService(string name)
        {
            try
            {
                string query = "USP_Search_Customer_Service @Name"; //
                return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
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
                string query = "USP_Search_Customer @nameCol , @value"; //
                return DataProvider.Instance.ExecuteQuery(query, new object[] {nameCol, value });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertCustomer(PersonalInfo per)
        {
            try
            {
                string query = "USP_Insert_Customer @CustomerID , @Name ,  @Gender , @Dob , @Address , @Phone , @IDCard "; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { per.PersonID, per.Name, per.Gender, per.Dob, per.Address, per.Phone, per.Idcard });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
        public int UpdateCustomer(PersonalInfo per)
        {
            try
            {
                string query = "USP_Update_Customer @CustomerID , @Name ,  @Gender , @Dob , @Address , @Phone , @IDCard "; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { per.PersonID, per.Name, per.Gender, per.Dob, per.Address, per.Phone, per.Idcard });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
