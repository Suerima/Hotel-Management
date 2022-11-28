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
            lbRecord.Text = "Số lượng khách hàng: " + dgvListCustomer.RowCount.ToString();
        }

        private void reset()
        {
            tbCustomerID.Texts = GetNextCustomerID();
            tbName.Texts = "Họ tên";
            cbGender.Text = "Name";
            tbIDCard.Texts = "CMND";
            tbPhone.Texts = "SĐT";
            tbAddress.Texts = "Địa chỉ";
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
            tabPageEdit.Text = "Thêm thông tin khách hàng";
            reset();
            checkButton = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbCustomerID.Texts == "")
            {
                MessageBox.Show("Chọn khách hàng bạn muốn cập nhật thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tabControl.TabPages.Remove(tabPageList);
                tabControl.TabPages.Add(tabPageEdit);
                tabPageEdit.Text = "Cập nhật thông tin khách hàng";
                checkButton = false;
            }
        }

        public void DeleteCustomer()
        {
            try
            {
                if (tbCustomerID.Texts == "")
                    MessageBox.Show("Vui lòng chọn khách hàng bạn muốn xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    var result = MessageBox.Show("Bạn có chắc muốn xoá khách hàng này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        PersonalInfoBUS.Instance.DeletePerson(tbCustomerID.Texts);
                        loadData();
                        MessageBox.Show("Xoá thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                if (name == "Họ tên" || address == "Địa chỉ" || phone == "SĐT" || idcard == "CMND")
                {
                    MessageBox.Show("Nhập thiếu thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!FormAcc_TaoAccount.checkName(name))
                {
                    MessageBox.Show("Tên không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!FormAcc_TaoAccount.checkPhone(phone))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!FormAcc_TaoAccount.checkIDCard(idcard))
                {
                    MessageBox.Show("CMND không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    PersonalInfo personInfo = new PersonalInfo(customerID, name, gender, dob, address, phone, idcard);

                    if (checkButton == true) // true = ADD
                    {

                        CustomerBUS.Instance.InsertCustomer(personInfo);
                        MessageBox.Show("Thêm khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // false = UPDATE
                    {
                        CustomerBUS.Instance.UpdateCustomer(personInfo);
                        MessageBox.Show("Cập nhật thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "Tìm kiếm")
            {
                if (cbSearch.Text == " Họ tên")
                {
                    dgvListCustomer.DataSource = CustomerBUS.Instance.SearchCustomer("Name", tbSearch.Text);
                }
                else if (cbSearch.Text == " Số điện thoại")
                {
                    dgvListCustomer.DataSource = CustomerBUS.Instance.SearchCustomer("Phone", tbSearch.Text);
                }
                else if (cbSearch.Text == " CMND")
                {
                    dgvListCustomer.DataSource = CustomerBUS.Instance.SearchCustomer("IDCard", tbSearch.Text);

                }
                else if (cbSearch.Text == " Mã khách hàng")
                {
                    dgvListCustomer.DataSource = CustomerBUS.Instance.SearchCustomer("CustomerID", tbSearch.Text);
                }
            }
        }
        #region Event

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Tìm kiếm")
                tbSearch.Text = "";
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
                tbSearch.Text = "Tìm kiếm";
        }


        private void tbName_Enter(object sender, EventArgs e)
        {
            tbName.BorderSize = 2;
            tbName.BorderColor = yellow;
            lbName.Text = "Họ tên";
            lbName.ForeColor = yellow;

            if (tbName.Texts == "Họ tên")
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
                tbName.Texts = "Họ tên";
                tbName.ForeColor = Color.DimGray;
                lbName.Text = "";
            }
        }

        private void tbAddress_Enter(object sender, EventArgs e)
        {
            tbAddress.BorderSize = 2;
            tbAddress.BorderColor = yellow;
            lbAddress.Text = "Địa chỉ";
            lbAddress.ForeColor = yellow;

            if (tbAddress.Texts == "Địa chỉ")
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
                tbAddress.Texts = "Địa chỉ";
                tbAddress.ForeColor = Color.DimGray;
                lbAddress.Text = "";
            }
        }

        private void tbIDCard_Enter(object sender, EventArgs e)
        {
            tbIDCard.BorderSize = 2;
            tbIDCard.BorderColor = yellow;
            lbIDCard.Text = "CMND";
            lbIDCard.ForeColor = yellow;

            if (tbIDCard.Texts == "CMND")
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
                tbIDCard.Texts = "CMND";
                tbIDCard.ForeColor = Color.DimGray;
                lbIDCard.Text = "";
            }
        }

        private void tbPhone_Enter(object sender, EventArgs e)
        {
            tbPhone.BorderSize = 2;
            tbPhone.BorderColor = yellow;
            lbPhone.Text = "SĐT";
            lbPhone.ForeColor = yellow;

            if (tbPhone.Texts == "SĐT")
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
                tbPhone.Texts = "SĐT";
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
