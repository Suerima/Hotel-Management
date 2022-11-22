using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class BookingReportDAO
    {
        private static BookingReportDAO instance;
        public static BookingReportDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BookingReportDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private BookingReportDAO() { }

        public int InsertBookingReport(BookingReport br)
        {
            try
            {
                string query = "USP_Insert_BookingReport @RoomID , @DateCreate , @DatePay , @Total "; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] {br.RoomID, br.DateCreate, br.DatePay, br.Total });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetBookingReport(DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                string query = " USP_Get_BookingReport @DateFrom , @DateTo "; //
                return DataProvider.Instance.ExecuteQuery(query, new object[] { dateFrom, dateTo });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
