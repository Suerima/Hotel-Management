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
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class FormDT_DichVu : Form
    {
        int numbers = 0;

        public class Date
        {
            static public DateTime dateF1;
            static public DateTime dateT1;
        }

        public FormDT_DichVu()
        {
            InitializeComponent(); 
            Date.dateF1 = new DateTime(2022, 11, 01);
            Date.dateT1 = new DateTime(2022, 11, 30);
            loadListServiceReport(DateTime.Today, DateTime.Today);
        }

        private string Total()
        {
            int sum = 0;
            int i = 0;
            for (; i < dgvListServiceInvoice.Rows.Count; i++)
                sum += int.Parse(dgvListServiceInvoice.Rows[i].Cells["Total1"].Value.ToString());
            numbers = i;
            return sum.ToString();
        }

        void loadListServiceReport(DateTime dateFrom, DateTime dateTo)
        {
            dgvListServiceInvoice.DataSource = ServiceReportBUS.Instance.GetServiceReport(dateFrom, dateTo);
            txtTotal.Text = Total();
            lbNumbers.Text = numbers.ToString();
        }

        private void btnSeen_Click(object sender, EventArgs e)
        {
            Date.dateF1 = DateTime.Parse(dateFrom.Value.ToString("yyyy-MM-dd"));
            Date.dateT1 = DateTime.Parse(dateTo.Value.ToString("yyyy-MM-dd"));
            loadListServiceReport(Date.dateF1, Date.dateT1);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReportService formReport = new FormReportService();
            formReport.ShowDialog();
        }

        void loadChart1(int year)
        {
            List<Service> lst = ServiceReportDAO.Instance.LoadChart1(year);
            chart1.ChartAreas[0].AxisX.Minimum = 1;
            chart1.ChartAreas[0].AxisX.Maximum = 12;
            int i = 0;
            chart1.Series["chart1"].Points.Clear();

            foreach (Service item in lst)
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
            List<ServiceReport> lst = ServiceReportDAO.Instance.LoadChart2(dateTo);
            int i = 0;
            chart2.Series["chart2"].Points.Clear();

            foreach (ServiceReport item in lst)
            {
                chart2.Series["chart2"].Points.AddXY(item.Type, item.Total);
                chart2.Series["chart2"].Points[i++].Label = item.Total;
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
