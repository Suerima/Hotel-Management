using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class SelectedServiceDAO
    {
        private static SelectedServiceDAO instance;
        public static SelectedServiceDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SelectedServiceDAO(); return instance;
            }
            private set { instance = value; }
        }
        private SelectedServiceDAO() { }
        public DataTable GetSelectedService(string sic)
        {
            try
            {
                string query = string.Format("EXEC USP_Get_SelectedService '{0}'", sic);
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertSelectedService(SelectedService ss)
        {
            try
            {
                string query = string.Format("USP_Insert_SelectedService '{0}', '{1}', '{2}', '{3}', '{4}'", ss.No, ss.ServiceInvoiceID, ss.ServiceID, ss.Price, ss.Quantity);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteSelectedService(int no)
        {
            try
            {
                string query = string.Format("USP_Delete_SelectedService '{0}'", no);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateNo(int no)
        {
            try
            {
                string query = string.Format("EXEC USP_Update_No '{0}'", no);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
