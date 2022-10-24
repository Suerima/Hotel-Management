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
                return DataProvider.Instance.ExecuteScalar("EXEC USP_Get_LastServiceInvoice");
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
                return DataProvider.Instance.ExecuteQuery("EXEC USP_Get_ServiceInvoice");
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
                return DataProvider.Instance.ExecuteQuery("EXEC USP_Get_ServiceInvoiceInCheckOut");
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
                string query = string.Format("EXEC USP_Insert_ServiceInvoice '{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', N'{6}'",
                                            SI.ServiceInvoiceID, SI.CustomerID, SI.ManagerID, SI.EmployeeID, SI.DateCreated, SI.Total, SI.Status);
                return DataProvider.Instance.ExecuteNonQuery(query);
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
                string query = string.Format("EXEC USP_Update_ServiceInvoice '{0}'", sic);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
