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
using static System.DateTime; 

namespace WindowsFormsApp1
{
    public partial class FormCN_DichVu : Form
    {
        public FormCN_DichVu()
        {
            InitializeComponent();
            loadListCustomer();
            loadListServiceInvoice();
            loadIDServiceInvoice();
            loadListService();
            loadComboBox();
            tabControl.TabPages.Remove(tabPageDetail);
        }

        void loadComboBox() // done
        {
            cbEmployeeID.DataSource = EmployeeBUS.Instance.GetEmployeeInService();
            cbEmployeeID.ValueMember = "EmployeeID";
        }

        void loadListCustomer() // done
        {
            dgvListCustomer.DataSource = CustomerBUS.Instance.GetCustomerInService();
        }

        void loadListServiceInvoice() // done
        {
            dgvListServiceInvoice.DataSource = ServiceInvoiceBUS.Instance.GetServiceInvoice(); ;
        }

        void loadListService() // DONE
        {

            dgvListService.DataSource = ServiceBUS.Instance.GetService();
        }


        void loadListSelectedService(string sic)        // done
        {
            dgvListSelectedService.DataSource = SelectedServiceBUS.Instance.GetSelectedService(sic);
        }

        void loadIDServiceInvoice()
        {
            tbServiceInvoiceCode.Text = GetNextIDServiceInvoice();
        }
       
        public string GetNextIDServiceInvoice()
        {
            string lastID = ServiceInvoiceBUS.Instance.GetLastServiceInvoiceCode();

            if (lastID == null)
                return "SIC001";

            int nextID = int.Parse(lastID.Remove(0, 3)) + 1; // Ex: BK012 ->  13
            string zeroNumber = "";
            for (int i = 1; i <= 3; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= 3 - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return "SIC" + zeroNumber + nextID.ToString();
                }
            }
            return "SIC" + nextID;
        }

        public void SetButton(bool set)
        {
            btnChoose.Enabled = set;
            btnSave.Enabled = set;
            btnDelete.Enabled = set;
        }
    
        private int checkServiceInvoiceCode(string sic)
        {
            for (int i = 0; i < dgvListServiceInvoice.Rows.Count; i++)
                if (dgvListServiceInvoice.Rows[i].Cells[0].Value != null && dgvListServiceInvoice.Rows[i].Cells[0].Value.ToString() == sic)
                    return i;
            return -1;
        }

        private int checkCustomerID(string cusID)
        {
            for (int i = 0; i < dgvListCustomer.Rows.Count; i++)
                if (dgvListCustomer.Rows[i].Cells[0].Value != null && dgvListCustomer.Rows[i].Cells[0].Value.ToString() == cusID)
                    return i;
            return -1;
        }


        private void dgvListCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                tbCustomerID.Text = dgvListCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvListServiceInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow r = new DataGridViewRow();
                r = dgvListServiceInvoice.Rows[e.RowIndex];
                if (r != null)
                    tbServiceInvoiceCode.Text = r.Cells[0].Value.ToString();
            }
        }

        private void dgvListService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow r = dgvListService.Rows[e.RowIndex];
                if (r != null)
                {
                    lbServiceCode.Text = r.Cells[0].Value.ToString();
                    lbPrice.Text = r.Cells[3].Value.ToString();
                }
            }
        }

        private void dgvListSelectedService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow r = dgvListSelectedService.Rows[e.RowIndex];
                if (r != null)
                    no_seleted = int.Parse(r.Cells[0].Value.ToString());
            }
        }

        // DONE
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CustomerBUS.Instance.GetCustomerID(tbCustomerID.Text) == null)
            {
                MessageBox.Show("Invalid CustomerID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(cbEmployeeID.Text == "")
            {
                MessageBox.Show("Invalid EmployeeID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SetButton(true);
                string dateCreated = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")).ToString();

                ServiceInvoice SI = new ServiceInvoice(tbServiceInvoiceCode.Text, tbCustomerID.Text, FormLogin.username, cbEmployeeID.Text, dateCreated, 0, "UNPAID");
                ServiceInvoiceBUS.Instance.InsertServiceInvoice(SI);
                //loadListServiceInvoice();
                loadListSelectedService(tbServiceInvoiceCode.Text);

                tabControl.TabPages.Remove(tabPageList);
                tabControl.TabPages.Add(tabPageDetail);
                tabPageDetail.Text = "Detail";
                lbSIC.Text = tbServiceInvoiceCode.Text;
                lbCustomerID.Text = tbCustomerID.Text;

            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabPageList);
            tabControl.TabPages.Add(tabPageDetail);
            tabPageDetail.Text = "Detail";
            SetButton(false);
            lbSIC.Text = tbServiceInvoiceCode.Text;
            loadListSelectedService(tbServiceInvoiceCode.Text);
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                int no = dgvListSelectedService.Rows.Count;
                SelectedService ss = new SelectedService(no, lbSIC.Text, lbServiceCode.Text, int.Parse(nudQuantity.Text));
                SelectedServiceBUS.Instance.InsertSelectedService(ss);
                loadListSelectedService(lbSIC.Text);
                MessageBox.Show("Inserted Successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int no_seleted;

        private void UpdateNo()
        {
            for (int i = no_seleted; i < dgvListSelectedService.Rows.Count; i++)
                SelectedServiceBUS.Instance.UpdateNo(i);
            loadListSelectedService(lbSIC.Text);
        }
       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure you want to delete this item?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SelectedServiceBUS.Instance.DeleteSelectedService(no_seleted);
                    UpdateNo();
                    MessageBox.Show("Deleted Successfully.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            ServiceInvoiceBUS.Instance.UpdateServiceInvoice(tbServiceInvoiceCode.Text, cbEmployeeID.Text).ToString();
            if (EmployeeBUS.Instance.GetStatusEmployee(cbEmployeeID.Text) == "Busy")
                ServiceReportBUS.Instance.InsertServiceReport(lbSIC.Text);
            loadListServiceInvoice();
            loadIDServiceInvoice();
            //
            //EmployeeBUS.Instance.UpdateEmployeeStatus(cbEmployeeID.Text);
            loadComboBox();
            MessageBox.Show("Saved successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabControl.TabPages.Remove(tabPageDetail);
            tabControl.TabPages.Add(tabPageList);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {

            tabControl.TabPages.Remove(tabPageDetail);
            tabControl.TabPages.Add(tabPageList);
            ServiceInvoiceBUS.Instance.DeleteServiceInvoice(lbSIC.Text);
            /*            if (db.CheckTotalServiceInvoice(lbSIC.Text) == lbSIC.Text)
                        {
                            db.DeleteServiceInvoice(lbSIC.Text);
                        }
            */
            loadListServiceInvoice();
            loadIDServiceInvoice();
        }

        #region
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "Name of Customer")
            {
                dgvListCustomer.DataSource = CustomerBUS.Instance.SearchCustomerInService(tbSearch.Text);
            }
        }
        private void txtCustomerID_Enter(object sender, EventArgs e)
        {
            if (tbCustomerID.Text == "None")
            {
                tbCustomerID.Text = "";
                tbCustomerID.ForeColor = Color.White;
            }
        }

        private void txtCustomerID_Leave(object sender, EventArgs e)
        {
            if (tbCustomerID.Text == "")
            {
                tbCustomerID.Text = "None";
                tbCustomerID.ForeColor = Color.Gray;
            }
        }
        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (tbCustomerID.Text != "None")
            {
                tbCustomerID.ForeColor = Color.White;
            }
        }
        private void txtEmployeeID_Enter(object sender, EventArgs e)
        {
            if (cbEmployeeID.Text == "None")
            {
                cbEmployeeID.Text = "";
                cbEmployeeID.ForeColor = Color.White;
            }
        }

        private void txtEmployeeID_Leave(object sender, EventArgs e)
        {
            if (cbEmployeeID.Text == "")
            {
                cbEmployeeID.Text = "None";
                cbEmployeeID.ForeColor = Color.Gray;
            }
        }
        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if (cbEmployeeID.Text != "None")
            {
                cbEmployeeID.ForeColor = Color.White;
            }
        }

        private void txtServiceInvoiceCode_Enter(object sender, EventArgs e)
        {
            if (tbServiceInvoiceCode.Text == "None")
            {
                tbServiceInvoiceCode.Text = "";
                tbServiceInvoiceCode.ForeColor = Color.White;
            }
        }

        private void txtServiceInvoiceCode_Leave(object sender, EventArgs e)
        {
            if (tbServiceInvoiceCode.Text == "")
            {
                tbServiceInvoiceCode.Text = "None";
                tbServiceInvoiceCode.ForeColor = Color.Gray;
            }
        }

        private void txtServiceInvoiceCode_TextChanged(object sender, EventArgs e)
        {
            if (tbServiceInvoiceCode.Text != "None")
            {
                tbServiceInvoiceCode.ForeColor = Color.White;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Name of Customer")
            {
                tbSearch.Text = "";
                tbSearch.ForeColor = Color.White;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = "Name of Customer";
                tbSearch.ForeColor = Color.Gray;
            }
        }
        #endregion

    }
}
