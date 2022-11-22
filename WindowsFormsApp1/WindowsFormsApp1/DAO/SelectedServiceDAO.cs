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
                string query = "USP_Get_SelectedService @SIC"; //
                return DataProvider.Instance.ExecuteQuery(query, new object[] {sic});
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
                string query = "USP_Insert_SelectedService @No , @ServiceInvoiceCode , @ServiceCode , @Quantity"; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] {ss.No, ss.ServiceInvoiceID, ss.ServiceID, ss.Quantity});
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
                string query = "USP_Delete_SelectedService @No"; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] {no});
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
                string query = "USP_Update_No @No"; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] {no});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
