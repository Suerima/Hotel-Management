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
    public class ServiceReportBUS
    {
        private static ServiceReportBUS instance;
        public static ServiceReportBUS Instance
        {

            get
            {
                if (instance == null)
                    instance = new ServiceReportBUS();
                return ServiceReportBUS.instance;
            }
            private set { instance = value; }
        }
        private ServiceReportBUS() { }

        public int InsertServiceReport(string sic)
        {
            return ServiceReportDAO.Instance.InsertServiceReport(sic);
        }

        public DataTable GetServiceReport(DateTime dateFrom, DateTime dateTo)
        {
            return ServiceReportDAO.Instance.GetServiceReport(dateFrom, dateTo);
        }
    }
}
