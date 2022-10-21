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
    public class ServiceInvoiceBUS
    {
        private static ServiceInvoiceBUS instance;
        public static ServiceInvoiceBUS Instance
        {

            get
            {
                if (instance == null)
                    instance = new ServiceInvoiceBUS();
                return ServiceInvoiceBUS.instance;
            }
            private set { instance = value; }
        }
        private ServiceInvoiceBUS() { }

        public string GetLastServiceInvoiceCode()
        {
             return ServiceInvoiceDAO.Instance.GetLastServiceInvoiceCode();
        }

        public DataTable GetServiceInvoice()
        {
            return ServiceInvoiceDAO.Instance.GetServiceInvoice();
        }
        public int InsertServiceInvoice(ServiceInvoice SI)
        {

            return ServiceInvoiceDAO.Instance.InsertServiceInvoice(SI);

        }

        public int UpdateServiceInvoice(string sic)
        {

            return ServiceInvoiceDAO.Instance.UpdateServiceInvoice(sic);
        }
    }
}
