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
using WindowsFormsApp1.BUS;

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

                DateTime dateF = FormDT_ThuePhong.Date.dateF;
                DateTime dateT = FormDT_ThuePhong.Date.dateT;                
                // Chế độ xem report
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                // Đường dẫn
                reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ReportBooking.rdlc";

                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = BookingReportBUS.Instance.GetBookingReport(dateF, dateT);
                reportViewer1.LocalReport.DataSources.Clear();
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
