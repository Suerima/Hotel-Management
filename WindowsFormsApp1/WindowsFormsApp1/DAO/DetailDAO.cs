using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class DetailDAO
    {
        private static DetailDAO instance;
        public static DetailDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DetailDAO(); return instance;
            }
            private set { instance = value; }
        }
        private DetailDAO() { }

        public string[] GetDetailsRoom(string roomID)
        {
            try
            {
                string[] detailList = new string[8];
                int i = 0;
                string query = "USP_Get_Detail_Room @roomID"; //
                
                DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { roomID });

                foreach(DataRow item in data.Rows)
                {
                    Detail detail = new Detail(item);
                    detailList[i] = detail.Details;
                    i++;
                }
                return detailList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetDetail(string[] arr)
        {
            try
            {
                string query = "USP_Get_ListAccount"; //
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
