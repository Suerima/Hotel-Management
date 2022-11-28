using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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



        public int InsertService(string serviceID, string nameservice, string type, int price)
        {
            try
            {
                return DataProvider.Instance.ExecuteNonQuery("USP_Insert_Service @ServiceID , @NameService , @Type , @Price", new object[] { serviceID, nameservice, type, price }); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteService(string serviceID)
        {
            try
            {
                return DataProvider.Instance.ExecuteNonQuery("USP_Delete_Service @ServiceID", new object[] { serviceID }); //

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateService(string serviceID, string nameservice, string type, int price)
        {
            try
            {
                return DataProvider.Instance.ExecuteNonQuery("USP_Update_Service @ServiceID , @NameService , @Type , @Price", new object[] { serviceID, nameservice, type, price }); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SearchService(string nameCol, string value)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_Search_Service @nameCol , @value", new object[] {nameCol , value}); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetLastServiceCode()
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("USP_Get_LastServiceCode"); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetService()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_Get_Service"); //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
