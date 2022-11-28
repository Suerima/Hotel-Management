using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class ServiceInvoice
    {
        private string serviceInvoiceID;
        private string customerID;
        private string managerID;
        private string roomID;
        private string dateCreated;
        private int total;
        private string status;

        public string ServiceInvoiceID { get => serviceInvoiceID; set => serviceInvoiceID = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public string ManagerID { get => managerID; set => managerID = value; }
        public string DateCreated { get => dateCreated; set => dateCreated = value; }
        public int Total { get => total; set => total = value; }
        public string Status { get => status; set => status = value; }
        public string RoomID { get => roomID; set => roomID = value; }

        public ServiceInvoice() { }
        public ServiceInvoice(string serviceInvoiceID, string customerID, string managerID, string roomID, string dateCreated, int total, string status)
        {
            ServiceInvoiceID = serviceInvoiceID;
            CustomerID = customerID;
            ManagerID = managerID;
            RoomID = roomID;
            DateCreated = dateCreated;
            Total = total;
            Status = status;
        }
    }
}
