using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

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
            Date.dateF = new DateTime(2022, 11, 01);
            Date.dateT = new DateTime(2022, 11, 30);
            loadListBookingReport(Date.dateF, Date.dateT);
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

        void loadChart1(int year)
        {
            List<Booking> lst = BookingReportDAO.Instance.LoadChart1(year);
            chart1.ChartAreas[0].AxisX.Minimum = 1;
            chart1.ChartAreas[0].AxisX.Maximum = 12;
            int i = 0;
            chart1.Series["chart1"].Points.Clear();

            foreach (Booking item in lst)
            {
                chart1.Series["chart1"].Points.AddXY(item.Month, item.Total);
                if (item.Total > 0)
                    chart1.Series["chart1"].Points[i].Label = item.Total.ToString();
                i++;
            }
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold); // Chart X axis Title Font
        }

        void loadChart2(DateTime dateTo)
        {
            List<BookingReport> lst = BookingReportDAO.Instance.LoadChart2(dateTo);
            int i = 0;
            chart2.Series["chart2"].Points.Clear();

            foreach (BookingReport item in lst)
            {
                chart2.Series["chart2"].Points.AddXY(item.Type, item.TotalL);
                chart2.Series["chart2"].Points[i++].Label = item.TotalL;
            }
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Loại dịch vụ";
            chart2.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold); // Chart X axis Title Font

        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(2022, Int32.Parse(cbMonth.Text), 15);

            loadChart2(date1);
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadChart1(Int32.Parse(cbYear.Text));
        }
    }
}
