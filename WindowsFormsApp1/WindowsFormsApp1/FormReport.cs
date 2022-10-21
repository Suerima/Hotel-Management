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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report1.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                QuanLyDB db = new QuanLyDB();
                DateTime dateF = FormDT_DichVu.Date.dateF;
                DateTime dateT = FormDT_DichVu.Date.dateT;
                reportDataSource.Value = db.GetAllListServiceReport(dateF, dateT);
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
