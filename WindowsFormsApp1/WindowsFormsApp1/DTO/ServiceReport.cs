using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class ServiceReport
    {
        private string serviceName;
        private string managerID;
        private DateTime dateCreate;
        private int quantity;
        private int price;

        private string type;
        private string total;


        public string ServiceName { get => serviceName; set => serviceName = value; }
        public string ManagerID { get => managerID; set => managerID = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }
        public string Total { get => total; set => total = value; }

        public ServiceReport() { }

        public ServiceReport(DataRow row)
        {
            this.Type = row["Type"].ToString();
            this.Total = row["Total"].ToString();
        }
        public ServiceReport(string serviceName, string managerID, DateTime dateCreate, int quantity, int price)
        {
            ServiceName = serviceName;
            ManagerID = managerID;
            DateCreate = dateCreate;
            Quantity = quantity;
            Price = price;
        }

    }
}
