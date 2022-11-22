using System;
using System.Collections.Generic;
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

        public string ServiceName { get => serviceName; set => serviceName = value; }
        public string ManagerID { get => managerID; set => managerID = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }

        public ServiceReport() { }


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
