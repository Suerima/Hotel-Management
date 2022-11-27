using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Service
    {
        private string serviceID;
        private string serviceName;
        private string unit;
        private string price;

        private int month;
        private int total;

        public string ServiceID { get => serviceID; set => serviceID = value; }
        public string ServiceName { get => serviceName; set => serviceName = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Price { get => price; set => price = value; }
        public int Month { get => month; set => month = value; }
        public int Total { get => total; set => total = value; }

        public Service(DataRow row)
        {
            this.Month = (int)row["Month"];
            this.Total = (int)row["Total"];
        }

        public Service() { }
        public Service(string serviceID, string serviceName, string unit, string price)
        {
            this.ServiceID = serviceID;
            this.ServiceName = serviceName;
            this.Unit = unit;
            this.Price = price;
        }
    }
}
