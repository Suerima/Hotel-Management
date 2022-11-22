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
    public class BookingReportBUS
    {
        private static BookingReportBUS instance;
        public static BookingReportBUS Instance
        {

            get
            {
                if (instance == null)
                    instance = new BookingReportBUS();
                return BookingReportBUS.instance;
            }
            private set { instance = value; }
        }
        private BookingReportBUS() { }

        public int InsertBookingReport(BookingReport br)
        {
            return BookingReportDAO.Instance.InsertBookingReport(br);
        }

        public DataTable GetBookingReport(DateTime dateFrom, DateTime dateTo)
        {
            return BookingReportDAO.Instance.GetBookingReport(dateFrom, dateTo);
        }
    }
}
