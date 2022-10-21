using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.BUS
{
    public class ServiceBUS
    {
        private static ServiceBUS instance;
        public static ServiceBUS Instance
        {

            get
            {
                if (instance == null)
                    instance = new ServiceBUS();
                return instance;
            }
            private set { instance = value; }
        }
        private ServiceBUS() { }
    
        public DataTable GetService()
        {
            return ServiceDAO.Instance.GetService();
        }
    }
}
