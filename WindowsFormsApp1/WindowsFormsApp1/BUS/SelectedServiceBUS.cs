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
    public class SelectedServiceBUS
    {
        private static SelectedServiceBUS instance;
        public static SelectedServiceBUS Instance
        {

            get
            {
                if (instance == null)
                    instance = new SelectedServiceBUS();
                return SelectedServiceBUS.instance;
            }
            private set { instance = value; }
        }
        private SelectedServiceBUS() { }

        public DataTable GetSelectedService(string sic)
        {
            return SelectedServiceDAO.Instance.GetSelectedService(sic);
        }

        public int InsertSelectedService(SelectedService ss)
        {
            return SelectedServiceDAO.Instance.InsertSelectedService(ss);
        }

        public int DeleteSelectedService(int no)
        {
            return SelectedServiceDAO.Instance.DeleteSelectedService(no);
        }

        public int UpdateNo(int no)
        {
            return SelectedServiceDAO.Instance.UpdateNo(no);
        }
    }
}
