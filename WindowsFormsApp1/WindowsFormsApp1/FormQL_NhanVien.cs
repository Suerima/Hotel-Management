using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //MemoryStream
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
    public partial class FormQL_NhanVien : Form
    {
        public FormQL_NhanVien()
        {
            this.KeyPreview = true;
            InitializeComponent(); 
            tabControl.TabPages.Remove(tabPageEdit);
            loadData();

        }
        void loadData()
        {
            dgvListEmployee.DataSource = EmployeeBUS.Instance.GetEmployee();
            lbRecord.Text = "Records: " + dgvListEmployee.RowCount.ToString();

        }

        private void dgvListInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvListEmployee.Rows[e.RowIndex];
            if (r != null)
            {
                tbEmployeeID.Text = r.Cells[0].Value.ToString();
                tbName.Text = r.Cells[1].Value.ToString();
                dtpDob.Text = r.Cells[2].Value.ToString();
                cbGender.Text = r.Cells[3].Value.ToString();
                tbIDCard.Text = r.Cells[4].Value.ToString();
                tbPhone.Text = r.Cells[5].Value.ToString();
                tbAddress.Text = r.Cells[6].Value.ToString();

            }
        }

        public string GetNextEmployeeID()
        {
            string lastID = EmployeeBUS.Instance.GetLastEmployeeID();

            if (lastID == null)
                return "NV001";

            int nextID = int.Parse(lastID.Remove(0, 2)) + 1; // Ex: BK012 ->  13

            string zeroNumber = "";

            for (int i = 1; i <= 3; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= 3 - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return "NV" + zeroNumber + nextID.ToString();
                }
            }
            return "NV" + nextID;
        }
      
        private void reset()
        {
            tbEmployeeID.Text = GetNextEmployeeID();
            tbName.Text = "";
            dtpDob.Text = "";
            cbGender.Text = "Male";
            tbIDCard.Text = "";
            tbPhone.Text = "";
            tbAddress.Text = "";
        }


        private bool checkButton;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabPageList);
            tabControl.TabPages.Add(tabPageEdit);
            tabPageEdit.Text = "Add employee";
            reset();
            checkButton = true;
        }
    
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbEmployeeID.Text == "")
            {
                MessageBox.Show("Please select the employee you want to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tabControl.TabPages.Remove(tabPageList);
                tabControl.TabPages.Add(tabPageEdit);
                tabPageEdit.Text = "UPDATE";
                checkButton = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text == "" || dtpDob.Text == "" || cbGender.Text == "" || tbIDCard.Text == "" || tbPhone.Text == "" || tbAddress.Text == "")
                {
                    MessageBox.Show("Enter missing employee information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    Employee employee = new Employee(tbEmployeeID.Text, tbName.Text, dtpDob.Text, cbGender.Text, tbIDCard.Text, tbPhone.Text, tbAddress.Text);

                    if (checkButton == true)
                    {
                        EmployeeBUS.Instance.InsertEmployee(employee);
                        loadData();
                        MessageBox.Show("Insert successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        EmployeeBUS.Instance.UpdateEmployee(employee);
                        loadData();
                        MessageBox.Show("Update successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    tabControl.TabPages.Add(tabPageList);
                    tabControl.TabPages.Remove(tabPageEdit);
                    tbEmployeeID.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabPageEdit);
            tabControl.TabPages.Add(tabPageList);
            tbEmployeeID.Text = "";
        }

        #region Event
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "Search")
                dgvListEmployee.DataSource = EmployeeBUS.Instance.SearchEmployee(tbSearch.Text);
            else
                loadData();
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Search")
                tbSearch.Text = "";
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
                tbSearch.Text = "Search";
        }
        #endregion

        public void DeleteEmployee()
        {
            try
            {
                if (tbEmployeeID.Text == "")
                    MessageBox.Show("Please select the employee you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var result = MessageBox.Show("Are you sure you want to delete this employee?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        EmployeeBUS.Instance.DeleteEmployee(tbEmployeeID.Text);
                        loadData();
                        MessageBox.Show("Delete successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbEmployeeID.Text = "";
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
