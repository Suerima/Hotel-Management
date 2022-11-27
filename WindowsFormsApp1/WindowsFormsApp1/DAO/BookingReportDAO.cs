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
        public List<Booking> LoadChart1(int year)
        {
            List<Booking> lst = new List<Booking>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_Booking_Chart @year", new object[] { year});

            foreach (DataRow item in data.Rows)
            {
                Booking bk = new Booking(item);
                lst.Add(bk);
            }

            return lst;
        }

        public List<BookingReport> LoadChart2(DateTime dateTo)
        {
            List<BookingReport> lst = new List<BookingReport>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_Chart_Type_Room @date", new object[] {dateTo });

            foreach (DataRow item in data.Rows)
            {
                BookingReport bk = new BookingReport(item);
                lst.Add(bk);
            }

            return lst;
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
