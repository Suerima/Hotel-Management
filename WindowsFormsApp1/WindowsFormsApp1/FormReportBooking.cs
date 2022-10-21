using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace WindowsFormsApp1
{
    public partial class FormReportBooking : Form
    {
        public FormReportBooking()
        {
            InitializeComponent();
        }

        private void FormReportBooking_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report2.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                QuanLyDB db = new QuanLyDB();
                DateTime dateF = FormDT_ThuePhong.Date.dateF;
                DateTime dateT = FormDT_ThuePhong.Date.dateT;
                reportDataSource.Value = db.GetAllListBookingReport(dateF, dateT);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
