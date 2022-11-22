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
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class FormQL_KhachHang : Form
    {
        private bool checkButton = false;
        Color yellow = Color.FromArgb(247, 206, 69);

        public FormQL_KhachHang()
        {

            InitializeComponent();
            tabControl.TabPages.Remove(tabPageEdit);
            loadData();
        }

        void loadData()
        {
            dgvListCustomer.DataSource = CustomerBUS.Instance.GetCustomer();
            lbRecord.Text = "Records: " + dgvListCustomer.RowCount.ToString();
        }

        private void reset()
        {
            tbCustomerID.Texts = GetNextCustomerID();
            tbName.Texts = "Fullname";
            cbGender.Text = "Male";
            tbIDCard.Texts = "IDCard";
            tbPhone.Texts = "Phone";
            tbAddress.Texts = "Address";
        }

        private void dgvListCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow r = dgvListCustomer.Rows[e.RowIndex];
                    if (r != null)
                    {
                        tbCustomerID.Texts = r.Cells[0].Value.ToString();
                        tbName.Texts = r.Cells[1].Value.ToString();
                        cbGender.Text = r.Cells[2].Value.ToString();
                        dtpDob.Text = r.Cells[3].Value.ToString();
                        tbAddress.Texts = r.Cells[4].Value.ToString();
                        tbPhone.Texts = r.Cells[5].Value.ToString();
                        tbIDCard.Texts = r.Cells[6].Value.ToString();
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string GetNextCustomerID()
        {
            string lastID = CustomerBUS.Instance.GetLastCustomerID();

            if (lastID == null)
                return "KH001";

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
                    return "KH" + zeroNumber + nextID.ToString();
                }
            }
            return "KH" + nextID;
        }
    
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabPageList);
            tabControl.TabPages.Add(tabPageEdit);
            tabPageEdit.Text = "ADD";
            reset();
            checkButton = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbCustomerID.Texts == "")
            {
                MessageBox.Show("Please select the customer you want to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tabControl.TabPages.Remove(tabPageList);
                tabControl.TabPages.Add(tabPageEdit);
                tabPageEdit.Text = "UPDATE";
                checkButton = false;
            }
        }

        public void DeleteCustomer()
        {
            try
            {
                if (tbCustomerID.Texts == "")
                    MessageBox.Show("Please select the customer you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var result = MessageBox.Show("Are you sure you want to delete this customer?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        PersonalInfoBUS.Instance.DeletePerson(tbCustomerID.Texts);
                        loadData();
                        MessageBox.Show("Delete successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbCustomerID.Texts = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string customerID = tbCustomerID.Texts;
                string name = tbName.Texts;
                string gender = cbGender.Text;
                DateTime dob = DateTime.ParseExact(dtpDob.Text, "dd/MM/yyyy", null);
                string address = tbAddress.Texts;
                string phone = tbPhone.Texts;
                string idcard = tbIDCard.Texts;

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
                    MessageBox.Show("Invalid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!FormAcc_TaoAccount.checkIDCard(idcard))
                {
                    MessageBox.Show("Invalid IDCard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    PersonalInfo personInfo = new PersonalInfo(customerID, name, gender, dob, address, phone, idcard);

                    if (checkButton == true) // true = ADD
                    {

                        CustomerBUS.Instance.InsertCustomer(personInfo);
                        MessageBox.Show("Insert successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // false = UPDATE
                    {
                        CustomerBUS.Instance.UpdateCustomer(personInfo);
                        MessageBox.Show("Update successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    tabControl.TabPages.Add(tabPageList);
                    tabControl.TabPages.Remove(tabPageEdit);
                    tbCustomerID.Texts = "";
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
            tbCustomerID.Texts = "";
        }

        #region Event

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "Search")
            {
                if (cbSearch.Text == " Fullname")
                {
                    dgvListCustomer.DataSource = CustomerBUS.Instance.SearchCustomer("Name", tbSearch.Text);
                }
                else if (cbSearch.Text == " Phone")
                {
                    dgvListCustomer.DataSource = CustomerBUS.Instance.SearchCustomer("Phone", tbSearch.Text);

                }
                else if (cbSearch.Text == " IDCard")
                {
                    dgvListCustomer.DataSource = CustomerBUS.Instance.SearchCustomer("IDCard", tbSearch.Text);

                }
                else if (cbSearch.Text == " CustomerID")
                {
                    dgvListCustomer.DataSource = CustomerBUS.Instance.SearchCustomer("CustomerID", tbSearch.Text);
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

        public void tbAddress_Leave(object sender, EventArgs e)
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

        private void dtpDob_Leave(object sender, EventArgs e)
        {
            tbDob.BorderSize = 1;
            tbDob.BorderColor = Color.DimGray;
            lbDob.ForeColor = Color.DarkGray;
        }

        private void dtpDob_Enter(object sender, EventArgs e)
        {
            tbDob.BorderSize = 2;
            tbDob.BorderColor = yellow;
            lbDob.ForeColor = yellow;
        }
#endregion
    }
}
