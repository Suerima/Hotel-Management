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
    public partial class FormDT_DichVu : Form
    {
        public FormDT_DichVu()
        {
            InitializeComponent();
            loadListServiceReport(DateTime.Today, DateTime.Today);
        }

        int numbers = 0;
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
        public class Date
        {
            static public DateTime dateF;
            static public DateTime dateT;
        }

        private void btnSeen_Click(object sender, EventArgs e)
        {
            Date.dateF = DateTime.Parse(dateFrom.Value.ToString("yyyy-MM-dd"));
            Date.dateT = DateTime.Parse(dateTo.Value.ToString("yyyy-MM-dd"));
            loadListServiceReport(Date.dateF, Date.dateT);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReportService formReport = new FormReportService();
            formReport.ShowDialog();
        }
    }
}
