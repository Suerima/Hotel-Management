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

        public List<Service> LoadChart1(int year)
        {
            List<Service> lst = new List<Service>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_Service_Chart @year", new object[] { year });

            foreach (DataRow item in data.Rows)
            {
                Service s = new Service(item);
                lst.Add(s);
            }

            return lst;
        }
        public List<ServiceReport> LoadChart2(DateTime dateTo)
        {
            List<ServiceReport> lst = new List<ServiceReport>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_Chart_Type_Service @date", new object[] { dateTo });

            foreach (DataRow item in data.Rows)
            {
                ServiceReport sr = new ServiceReport(item);
                lst.Add(sr);
            }

            return lst;
        }
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
