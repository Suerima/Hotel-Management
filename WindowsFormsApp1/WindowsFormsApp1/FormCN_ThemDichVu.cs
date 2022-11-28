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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FormCN_ThemDichVu : Form
    {
        public FormCN_ThemDichVu()
        {
            InitializeComponent();
            tbServiceID.Text = GetNextServiceCode();
            loadData();
        }

        public string GetNextServiceCode()
        {
            string lastID = ServiceBUS.Instance.GetLastServiceCode();

            if (lastID == null)
                return "DV001";

            int nextID = int.Parse(lastID.Remove(0, 2)) + 1; 
            string zeroNumber = "";

            for (int i = 1; i <= 3; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= 3 - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return "DV" + zeroNumber + nextID.ToString();
                }
            }
            return "DV" + nextID;
        }

        void loadData()
        {
            dgvListService.DataSource = ServiceBUS.Instance.GetService();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ServiceDAO.Instance.InsertService(tbServiceID.Text, tbName.Text, cbType.Text, Int32.Parse(tbPrice.Text)) > 0)
                MessageBox.Show("Thêm dịch vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm dịch vụ thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ServiceDAO.Instance.DeleteService(tbServiceID.Text) > 0)
                    MessageBox.Show("Thêm dịch vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xoá dịch vụ thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ServiceDAO.Instance.UpdateService(tbServiceID.Text, tbName.Text, cbType.Text, Int32.Parse(tbPrice.Text)) > 0)
                    MessageBox.Show("Thêm dịch vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cập nhật dịch vụ thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != " Tìm kiếm")
            {
                if (cbSearch.Text == " Mã dịch vụ")
                {
                    dgvListService.DataSource = ServiceBUS.Instance.SearchService("Service_Code", tbSearch.Text);
                }
                else if (cbSearch.Text == " Tên dịch vụ")
                {
                    dgvListService.DataSource = ServiceBUS.Instance.SearchService("Service_Name", tbSearch.Text);
                }
                else
                {
                    dgvListService.DataSource = ServiceBUS.Instance.SearchService("Type", tbSearch.Text);
                }
            }
        }

        private void dgvListService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow r = dgvListService.Rows[e.RowIndex];
                    if (r != null)
                    {
                        tbServiceID.Text = r.Cells[0].Value.ToString();
                        tbName.Text = r.Cells[1].Value.ToString();
                        cbType.Text = r.Cells[2].Value.ToString();
                        tbPrice.Text = r.Cells[3].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
