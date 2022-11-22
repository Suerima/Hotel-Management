using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class ServiceReportDAO
    {
        private static ServiceReportDAO instance;
        public static ServiceReportDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServiceReportDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private ServiceReportDAO() { }

        public int InsertServiceReport(string sic)
        {
            try
            {
                string query = "USP_Insert_ServiceReport @SIC "; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] {sic});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetServiceReport(DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                string query = " USP_Get_ServiceReport @DateFrom , @DateTo "; //
                return DataProvider.Instance.ExecuteQuery(query, new object[] { dateFrom, dateTo});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
