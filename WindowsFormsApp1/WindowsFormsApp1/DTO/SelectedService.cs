using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class SelectedService
    {
        private int no;
        private string serviceInvoiceID;
        private string serviceID;
        private int quantity;

        public string ServiceInvoiceID { get => serviceInvoiceID; set => serviceInvoiceID = value; }
        public string ServiceID { get => serviceID; set => serviceID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int No { get => no; set => no = value; }

        public SelectedService() { }

        public SelectedService(int no, string serviceInvoiceID, string serviceID,int quantity)
        {
            this.No = no;
            this.ServiceInvoiceID = serviceInvoiceID;
            this.ServiceID = serviceID;
            this.Quantity = quantity;
        }
    }
}
