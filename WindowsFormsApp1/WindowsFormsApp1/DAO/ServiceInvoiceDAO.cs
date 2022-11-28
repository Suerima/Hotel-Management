using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class ServiceInvoiceDAO
    {
        private static ServiceInvoiceDAO instance;
        public static ServiceInvoiceDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServiceInvoiceDAO(); return instance;
            }
            private set { instance = value; }
        }
        private ServiceInvoiceDAO() { }
        public string GetLastServiceInvoiceCode()
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("USP_Get_LastServiceInvoice"); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetServiceInvoice()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_Get_ServiceInvoice"); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetTotalServiceInvoice(string roomID)
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("USP_Get_Total_ServiceInvoice @RoomID", new object[] {roomID}); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetServiceInvoiceInCheckOut()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_Get_ServiceInvoice_CheckOut"); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertServiceInvoice(ServiceInvoice SI)
        {
            try
            {
                string query = "USP_Insert_ServiceInvoice @ServiceInvoiceCode , @CustomerID , @MangerID , @RoomID , @DateCreate , @Total , @Status"; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { SI.ServiceInvoiceID, SI.CustomerID, SI.ManagerID, SI.RoomID , SI.DateCreated, SI.Total, SI.Status });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateServiceInvoice(string sic)
        {
            try
            {
                string query = "USP_Update_ServiceInvoice @SIC"; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { sic});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteServiceInvoice(string sic)
        {
            try
            {
                string query = "USP_Delete_ServiceInvoice @SIC"; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { sic});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
