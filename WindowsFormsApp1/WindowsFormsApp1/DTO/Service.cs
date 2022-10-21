using System;
using System.Collections.Generic;
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

        public string ServiceID { get => serviceID; set => serviceID = value; }
        public string ServiceName { get => serviceName; set => serviceName = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Price { get => price; set => price = value; }


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
