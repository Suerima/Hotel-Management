using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class ServiceDAO
    {
        private static ServiceDAO instance;
        public static ServiceDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServiceDAO(); return instance;
            }
            private set { instance = value; }
        }
        private ServiceDAO() { }
        public DataTable GetService()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SELECT * FROM FU_Get_Service() ");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
