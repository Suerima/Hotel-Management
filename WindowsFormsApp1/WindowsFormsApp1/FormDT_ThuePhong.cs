using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormDT_ThuePhong : Form
    {
        public FormDT_ThuePhong()
        {
            InitializeComponent();
            DateTime from = DateTime.Today;
            DateTime to = DateTime.Today;

            loadListBookingReport(from, to);
        }

        int numbers = 0;
        private string Total()
        {
            int sum = 0;
            int i = 0;
            for (; i < dgvListBooking.Rows.Count; i++)
                sum += int.Parse(dgvListBooking.Rows[i].Cells[3].Value.ToString());
            numbers = i;
            return sum.ToString();
        }

        void loadListBookingReport(DateTime dateFrom, DateTime dateTo)
        {
            QuanLyDB db = new QuanLyDB();
            DataTable dt = db.GetAllListBookingReport(dateFrom, dateTo);
            dgvListBooking.DataSource = dt;
            txtTotal.Text = Total();
            lbNumbers.Text = numbers.ToString();
        }

        public class Date
        {
            static public DateTime dateF;
            static public DateTime dateT;
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
