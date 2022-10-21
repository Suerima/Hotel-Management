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
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class FormQL_KhachHang : Form
    {
        public FormQL_KhachHang()
        {

            InitializeComponent();
            tabControl.TabPages.Remove(tabPageEdit);
        }

        void loadData()
        {
            dgvListCustomer.DataSource = CustomerBUS.Instance.GetCustomer();
        }

        private void FormQL_KhachHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void reset()
        {
            tbCustomerID.Text = GetNextCustomerID();
            tbName.Text = "";
            dtpDob.Text = "";
            cbGender.Text = "Male";
            tbIDCard.Text = "";
            tbPhone.Text = "";
            tbAddress.Text = "";
        }

        private void dgvListInfoCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvListCustomer.Rows[e.RowIndex];
            if (r != null)
            {
                tbCustomerID.Text = r.Cells[0].Value.ToString();
                tbName.Text = r.Cells[1].Value.ToString();
                dtpDob.Text = r.Cells[2].Value.ToString();
                cbGender.Text = r.Cells[3].Value.ToString();
                tbIDCard.Text = r.Cells[4].Value.ToString();
                tbPhone.Text = r.Cells[5].Value.ToString();
                tbAddress.Text = r.Cells[6].Value.ToString();

            }
        }

        private bool checkButton = false;
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
            tabPageEdit.Text = "Add customer";
            reset();
            checkButton = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbCustomerID.Text == "")
            {
                MessageBox.Show("Please select the customer you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tabControl.TabPages.Remove(tabPageList);
                tabControl.TabPages.Add(tabPageEdit);
                tabPageEdit.Text = "Update customer";
                checkButton = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCustomerID.Text == "")
                    MessageBox.Show("Please select the customer you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var result = MessageBox.Show("Are you sure you want to delete this customer?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        CustomerBUS.Instance.DeleteCustomer(tbCustomerID.Text);
                        loadData();
                        MessageBox.Show("Delete successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbCustomerID.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text == "" || dtpDob.Text == "" || cbGender.Text == "" || tbIDCard.Text == "" || tbPhone.Text == "" || tbAddress.Text == "")
                {
                    MessageBox.Show("Enter missing customer information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    Customer customer = new Customer(tbCustomerID.Text, tbName.Text, dtpDob.Text, cbGender.Text, tbIDCard.Text, tbPhone.Text, tbAddress.Text);

                    if (checkButton == true) // true = ADD
                    {
                        CustomerBUS.Instance.InsertCustomer(customer);
                        loadData();
                        MessageBox.Show("Insert successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // false = UPDATE
                    {
                        CustomerBUS.Instance.UpdateCustomer(customer);
                        loadData();
                        MessageBox.Show("Update successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    tabControl.TabPages.Add(tabPageList);
                    tabControl.TabPages.Remove(tabPageEdit);
                    tbCustomerID.Text = "";
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
            tbCustomerID.Text = "";
        }

        #region Event
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "Search by name ")
                dgvListCustomer.DataSource = CustomerBUS.Instance.SearchCustomer("Name", tbSearch.Text);
            else
                loadData();
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Search by name ")
                tbSearch.Text = "";
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
                tbSearch.Text = "Search by name ";
        }
        #endregion


    }
}
