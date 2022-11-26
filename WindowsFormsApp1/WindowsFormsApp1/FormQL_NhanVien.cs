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
        Color yellow = Color.FromArgb(247, 206, 69);

        public FormQL_NhanVien()
        {
  //          this.KeyPreview = true;
            InitializeComponent(); 
            tabControl.TabPages.Remove(tabPageEdit);
           if(FormLogin.authority == "Nhân viên")
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                tbEmployeeID.Enabled = false;
                tbName.Enabled = false;
                dtpDob.Enabled = false;
                cbGender.Enabled = false;
                tbIDCard.Enabled = false;
                tbPhone.Enabled = false;
                tbAddress.Enabled = false;
            }
            loadData();
        }

        void loadData()
        {
            dgvListEmployee.DataSource = EmployeeBUS.Instance.GetEmployee();
            lbRecord.Text = "Số lượng nhân viên: " + dgvListEmployee.RowCount.ToString();

        }
        private void reset()
        {
            tbEmployeeID.Texts = GetNextEmployeeID();
            tbName.Texts = "Fullname";
            cbGender.Text = "Male";
            tbIDCard.Texts = "IDCard";
            tbPhone.Texts = "Phone";
            tbAddress.Texts = "Address";
        }

        private void dgvListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                if (e.RowIndex != -1)
                {
                    DataGridViewRow r = dgvListEmployee.Rows[e.RowIndex];
                    if (r != null)
                    {
                        tbEmployeeID.Texts = r.Cells[0].Value.ToString();
                        tbName.Texts = r.Cells[1].Value.ToString();
                        cbGender.Text = r.Cells[2].Value.ToString();
                        dtpDob.Text = r.Cells[3].Value.ToString();
                        tbAddress.Texts = r.Cells[4].Value.ToString();
                        tbPhone.Texts = r.Cells[5].Value.ToString();
                        tbIDCard.Texts = r.Cells[6].Value.ToString();
                        cbStatus.Text = r.Cells[7].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
      
        private bool checkButton = false;

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
            if (tbEmployeeID.Texts == "")
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
                string employeeID = tbEmployeeID.Texts;
                string name = tbName.Texts;
                string gender = cbGender.Text;
                DateTime dob = DateTime.ParseExact(dtpDob.Text, "dd/MM/yyyy", null);
                string address = tbAddress.Texts;
                string phone = tbPhone.Texts;
                string idcard = tbIDCard.Texts;
                string status = cbStatus.Text;

                if (name == "Fullname" || address == "Address" || phone == "Phone" || idcard == "IDCard")
                {
                    MessageBox.Show("Missing information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!FormAcc_TaoAccount.checkName(name))
                {
                    MessageBox.Show("Invalid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!FormAcc_TaoAccount.checkPhone(phone))
                {
                    MessageBox.Show("Not a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!FormAcc_TaoAccount.checkIDCard(idcard))
                {
                    MessageBox.Show("Invalid IDCard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PersonalInfo personInfo = new PersonalInfo(employeeID, name, gender, dob, address, phone, idcard);

                    if (checkButton == true) // true = ADD
                    {
                        EmployeeBUS.Instance.InsertEmployee(personInfo);
                        MessageBox.Show("Insert successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        EmployeeBUS.Instance.UpdateEmployee(personInfo, status);
                        MessageBox.Show("Update successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    tabControl.TabPages.Add(tabPageList);
                    tabControl.TabPages.Remove(tabPageEdit);
                    tbEmployeeID.Texts = "";
                    loadData();
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
            tbEmployeeID.Texts = "";
        }

        public void DeleteEmployee()
        {
            try
            {
                if (tbEmployeeID.Texts == "")
                    MessageBox.Show("Please select the employee you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var result = MessageBox.Show("Are you sure you want to delete this employee?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        PersonalInfoBUS.Instance.DeletePerson(tbEmployeeID.Texts);
                        loadData();
                        MessageBox.Show("Delete successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbEmployeeID.Texts = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Event
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "Search")
            {
                if (cbSearch.Text == " Fullname")
                {
                    dgvListEmployee.DataSource = EmployeeBUS.Instance.SearchEmployee("Name", tbSearch.Text);
                }
                else if (cbSearch.Text == " Phone")
                {
                    dgvListEmployee.DataSource = EmployeeBUS.Instance.SearchEmployee("Phone", tbSearch.Text);

                }
                else if (cbSearch.Text == " IDCard")
                {
                    dgvListEmployee.DataSource = EmployeeBUS.Instance.SearchEmployee("IDCard", tbSearch.Text);

                }
                else if (cbSearch.Text == " EmployeeID")
                {
                    dgvListEmployee.DataSource = EmployeeBUS.Instance.SearchEmployee("EmployeeID", tbSearch.Text);
                }
            }
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

        private void tbName_Enter(object sender, EventArgs e)
        {

            tbName.BorderSize = 2;
            tbName.BorderColor = yellow;
            lbName.Text = "Fullname";
            lbName.ForeColor = yellow;

            if (tbName.Texts == "Fullname")
                tbName.Texts = "";
            tbName.ForeColor = Color.WhiteSmoke;
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            tbName.BorderSize = 1;
            tbName.BorderColor = Color.DimGray;
            lbName.ForeColor = Color.DarkGray;

            if (tbName.Texts == "")
            {
                tbName.Texts = "Fullname";
                tbName.ForeColor = Color.DimGray;
                lbName.Text = "";
            }
        }

        private void cbGender_Enter(object sender, EventArgs e)
        {
            tbGender.BorderSize = 2;
            tbGender.BorderColor = yellow;
            lbGender.ForeColor = yellow;
        }

        private void cbGender_Leave(object sender, EventArgs e)
        {
            tbGender.BorderSize = 1;
            tbGender.BorderColor = Color.DimGray;
            lbGender.ForeColor = Color.DarkGray;
        }

        private void dtpDob_Enter(object sender, EventArgs e)
        {
            tbDob.BorderSize = 2;
            tbDob.BorderColor = yellow;
            lbDob.ForeColor = yellow;
        }

        private void dtpDob_Leave(object sender, EventArgs e)
        {
            tbDob.BorderSize = 1;
            tbDob.BorderColor = Color.DimGray;
            lbDob.ForeColor = Color.DarkGray;
        }

        private void tbAddress_Enter(object sender, EventArgs e)
        {
            tbAddress.BorderSize = 2;
            tbAddress.BorderColor = yellow;
            lbAddress.Text = "Address";
            lbAddress.ForeColor = yellow;

            if (tbAddress.Texts == "Address")
                tbAddress.Texts = "";
            tbAddress.ForeColor = Color.WhiteSmoke;

        }
        private void tbAddress_Leave(object sender, EventArgs e)
        {
            tbAddress.BorderSize = 1;
            tbAddress.BorderColor = Color.DimGray;
            lbAddress.ForeColor = Color.DarkGray;

            if (tbAddress.Texts == "")
            {
                tbAddress.Texts = "Address";
                tbAddress.ForeColor = Color.DimGray;
                lbAddress.Text = "";
            }
        }


        private void tbIDCard_Enter(object sender, EventArgs e)
        {
            tbIDCard.BorderSize = 2;
            tbIDCard.BorderColor = yellow;
            lbIDCard.Text = "IDCard";
            lbIDCard.ForeColor = yellow;

            if (tbIDCard.Texts == "IDCard")
                tbIDCard.Texts = "";
            tbIDCard.ForeColor = Color.WhiteSmoke;
        }

        private void tbIDCard_Leave(object sender, EventArgs e)
        {
            tbIDCard.BorderSize = 1;
            tbIDCard.BorderColor = Color.DimGray;
            lbIDCard.ForeColor = Color.DarkGray;

            if (tbIDCard.Texts == "")
            {
                tbIDCard.Texts = "IDCard";
                tbIDCard.ForeColor = Color.DimGray;
                lbIDCard.Text = "";
            }
        }

        private void tbPhone_Enter(object sender, EventArgs e)
        {
            tbPhone.BorderSize = 2;
            tbPhone.BorderColor = yellow;
            lbPhone.Text = "Phone";
            lbPhone.ForeColor = yellow;

            if (tbPhone.Texts == "Phone")
                tbPhone.Texts = "";
            tbPhone.ForeColor = Color.WhiteSmoke;
        }
        private void tbPhone_Leave(object sender, EventArgs e)
        {
            tbPhone.BorderSize = 1;
            tbPhone.BorderColor = Color.DimGray;
            lbPhone.ForeColor = Color.DarkGray;

            if (tbPhone.Texts == "")
            {
                tbPhone.Texts = "Phone";
                tbPhone.ForeColor = Color.DimGray;
                lbPhone.Text = "";
            }
        }

        private void cbStatus_Enter(object sender, EventArgs e)
        {
            tbStatus.BorderSize = 2;
            tbStatus.BorderColor = yellow;
            lbStatus.ForeColor = yellow;
        }

        private void cbStatus_Leave(object sender, EventArgs e)
        {
            tbStatus.BorderSize = 1;
            tbStatus.BorderColor = Color.DimGray;
            lbStatus.ForeColor = Color.DarkGray;
        }
        #endregion

    }
}
