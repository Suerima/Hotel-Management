using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
    public partial class FormDT_ThuePhong : Form
    {
        int numbers = 0;

        public class Date
        {
            static public DateTime dateF;
            static public DateTime dateT;
        }

        public FormDT_ThuePhong()
        {
            InitializeComponent();
            loadListBookingReport(DateTime.Today, DateTime.Today);
        }

        private string Total()
        {
            int sum = 0;
            int i = 0;
            for (; i < dgvListBooking.Rows.Count; i++)
                sum += int.Parse(dgvListBooking.Rows[i].Cells["Total1"].Value.ToString());
            numbers = i;
            return sum.ToString();
        }

        void loadListBookingReport(DateTime dateFrom, DateTime dateTo)
        {
            dgvListBooking.DataSource = BookingReportBUS.Instance.GetBookingReport(dateFrom, dateTo);
            txtTotal.Text = Total();
            lbNumbers.Text = numbers.ToString();
        }

        private void btnSeen_Click(object sender, EventArgs e)
        {
            Date.dateF = DateTime.Parse(dateFrom.Value.ToString("yyyy-MM-dd"));
            Date.dateT = DateTime.Parse(dateTo.Value.ToString("yyyy-MM-dd"));
            loadListBookingReport(Date.dateF, Date.dateT);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReportBooking formReport = new FormReportBooking();
            formReport.ShowDialog();
        }
    }
}
