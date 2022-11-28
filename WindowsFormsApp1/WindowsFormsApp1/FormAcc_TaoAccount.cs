using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class FormAcc_TaoAccount : Form
    {
        Color yellow = Color.FromArgb(247, 206, 69);

        public FormAcc_TaoAccount()
        {
            InitializeComponent();
            loadListAccount();
            cbGender.Text = "Nam";
            cbAuthority.Text = "Quản lý";
        }


        static public bool checkName(string name)
        {
            Regex isValidInput = new Regex(@"^[AÀẢÃÁẠĂẰẲẴẮẶÂẦẨẪẤẬBCDĐEÈẺẼÉẸÊỀỂỄẾỆFGHIÌỈĨÍỊJKLMNOÒỎÕÓỌÔỒỔỖỐỘƠỜỞỠỚỢPQRSTUÙỦŨÚỤƯỪỬỮỨỰVWXYỲỶỸÝỴZ][aàảãáạăằẳẵắặâầẩẫấậbcdđeèẻẽéẹêềểễếệfghiìỉĩíịjklmnoòỏõóọôồổỗốộơờởỡớợpqrstuùủũúụưừửữứựvwxyỳỷỹýỵz]+ [AÀẢÃÁẠĂẰẲẴẮẶÂẦẨẪẤẬBCDĐEÈẺẼÉẸÊỀỂỄẾỆFGHIÌỈĨÍỊJKLMNOÒỎÕÓỌÔỒỔỖỐỘƠỜỞỠỚỢPQRSTUÙỦŨÚỤƯỪỬỮỨỰVWXYỲỶỸÝỴZ][aàảãáạăằẳẵắặâầẩẫấậbcdđeèẻẽéẹêềểễếệfghiìỉĩíịjklmnoòỏõóọôồổỗốộơờởỡớợpqrstuùủũúụưừửữứựvwxyỳỷỹýỵz]+(?: [AÀẢÃÁẠĂẰẲẴẮẶÂẦẨẪẤẬBCDĐEÈẺẼÉẸÊỀỂỄẾỆFGHIÌỈĨÍỊJKLMNOÒỎÕÓỌÔỒỔỖỐỘƠỜỞỠỚỢPQRSTUÙỦŨÚỤƯỪỬỮỨỰVWXYỲỶỸÝỴZ][aàảãáạăằẳẵắặâầẩẫấậbcdđeèẻẽéẹêềểễếệfghiìỉĩíịjklmnoòỏõóọôồổỗốộơờởỡớợpqrstuùủũúụưừửữứựvwxyỳỷỹýỵz]*)*");  // @"[\p{L} ]+$"
            if (isValidInput.IsMatch(name))
                return true;
            return false;
        }

        static public bool checkEmail(string email)
        {
            Regex isValidInput = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (isValidInput.IsMatch(email) && !AccountBUS.Instance.SearchEmail(email))
                return true;
            return false;
        }

        static public bool checkPassword(string password)
        {
            Regex isValidInput = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,10}$");
            if (isValidInput.IsMatch(password))
                return true;
            return false;
        }

        static public bool checkIDCard(string idcard)
        {
            Regex isValidInput = new Regex(@"^\d{9}$");
            if (isValidInput.IsMatch(idcard))
                return true;
            return false;
        }

        static public bool checkPhone(string phone)
        {
            Regex isValidInput = new Regex(@"^0(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7,8}$");
            if (isValidInput.IsMatch(phone))
                return true;
            return false;
        }

        public bool checkExistingUser(string username)
        {
            DataTable dt = AccountBUS.Instance.GetAccount(username);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = tbxFullname.Texts;
            string gender = cbGender.Text;
            DateTime dob =  DateTime.ParseExact(dtpDob.Text, "dd/MM/yyyy", null);
            string address = tbxAddress.Texts;
            string phone = tbxPhone.Texts;
            string idcard = tbxIDCard.Texts;
            string authority = cbAuthority.Text;
            string username = tbxUsername.Texts;
            string email = tbxEmail.Texts;
            string password = tbxPassword.Texts;
            string confirm = tbxConfirm.Texts;
            byte[] image = null;
            string filename = "D:\\QuanLyKhachSan\\WindowsFormsApp1\\WindowsFormsApp1\\Resources\\DefaultAvatar.jpg";
            // Read the file into a byte array
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                image = new Byte[fs.Length];
                fs.Read(image, 0, (int)fs.Length);
            }
            
            if (name == "Họ tên" || address == "Địa chỉ" || phone == "SĐT" || idcard == "CMND" || username == "Tên tài khoản" || email == "Email" || password == "Mật khẩu" || confirm == "Xác nhận mật khẩu")
            {
                MessageBox.Show("Nhập đây đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!checkName(name))
            {
            MessageBox.Show("Tên không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (!checkPhone(phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!checkIDCard(idcard))
            {
                MessageBox.Show("CMND không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!checkEmail(email))
            {
                MessageBox.Show("Email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(!checkPassword(password))
            {
                MessageBox.Show("Mật khẩu phải tổi thiểu 8 kí tự, gồm ít nhất 1 hoa, 1 thường, 1 số và 1 kí tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!password.Equals(confirm))
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp với mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Account account = new Account(username, password, email, authority, image);
                PersonalInfo perInfo = new PersonalInfo(username, name, gender, dob, address, phone, idcard);

                if (AccountBUS.Instance.InsertAccount(account, perInfo) > 1)
                {
                    MessageBox.Show("Tạo tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                    loadListAccount();
                }
                else
                    MessageBox.Show("Tên tài khoản đã tồn tại.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void reset()
        {
            tbxFullname.Texts = "Họ tên";
            tbxFullname.ForeColor = Color.DimGray;
            lbFullname.Text = "";

            tbxEmail.Texts = "Email";
            tbxEmail.ForeColor = Color.DimGray;
            lbEmail.Text = "";

            tbxAddress.Texts = "Địa chỉ";
            tbxAddress.ForeColor = Color.DimGray;
            lbAddress.Text = "";

            tbxPhone.Texts = "SĐT";
            tbxPhone.ForeColor = Color.DimGray;
            lbPhone.Text = "";

            tbxUsername.Texts = "Tên tài khoản";
            tbxUsername.ForeColor = Color.DimGray;
            lbUsername.Text = "";

            tbxIDCard.Texts = "CMND";
            tbxIDCard.ForeColor = Color.DimGray;
            lbIDCard.Text = "";

            tbxPassword.Texts = "Mật khẩu";
            tbxPassword.ForeColor = Color.DimGray;
            lbPassword.Text = "";

            tbxConfirm.Texts = "Xác nhận mật khẩu";
            tbxConfirm.ForeColor = Color.DimGray;
            lbConfirm.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        void loadListAccount()
        {
            dgvListAccount.DataSource = AccountBUS.Instance.GetListAccount();
        }


        #region Event
        private void tbxFullname_Enter(object sender, EventArgs e)
        {
            tbxFullname.BorderSize = 2;
            tbxFullname.BorderColor = yellow;
            lbFullname.Text = "Họ tên";
            lbFullname.ForeColor = yellow;

            if (tbxFullname.Texts == "Họ tên")
                tbxFullname.Texts = "";
            tbxFullname.ForeColor = Color.WhiteSmoke;
        }

        private void tbxFullname_Leave(object sender, EventArgs e)
        {
            tbxFullname.BorderSize = 1;
            tbxFullname.BorderColor = Color.DimGray;
            lbFullname.ForeColor = Color.DarkGray;

            if (tbxFullname.Texts == "")
            {
                tbxFullname.Texts = "Họ tên";
                tbxFullname.ForeColor = Color.DimGray;
                lbFullname.Text = "";
            }
        }

        private void cbGender_Enter(object sender, EventArgs e)
        {
            tbxGender.BorderSize = 2;
            tbxGender.BorderColor = yellow;
            lbGender.ForeColor = yellow;
        }

        private void cbGender_Leave(object sender, EventArgs e)
        {

            tbxGender.BorderSize = 1;
            tbxGender.BorderColor = Color.DimGray;
            lbGender.ForeColor = Color.DarkGray;
        }

        private void tbxAddress_Enter(object sender, EventArgs e)
        {
            tbxAddress.BorderSize = 2;
            tbxAddress.BorderColor = yellow;
            lbAddress.Text = "Địa chỉ";
            lbAddress.ForeColor = yellow;

            if (tbxAddress.Texts == "Địa chỉ")
                tbxAddress.Texts = "";
            tbxAddress.ForeColor = Color.WhiteSmoke;

        }

        private void tbxAddress_Leave(object sender, EventArgs e)
        {
            tbxAddress.BorderSize = 1;
            tbxAddress.BorderColor = Color.DimGray;
            lbAddress.ForeColor = Color.DarkGray;

            if (tbxAddress.Texts == "")
            {
                tbxAddress.Texts = "Địa chỉ";
                tbxAddress.ForeColor = Color.DimGray;
                lbAddress.Text = "";
            }

        }

        private void tbxPhone_Enter(object sender, EventArgs e)
        {
            tbxPhone.BorderSize = 2;
            tbxPhone.BorderColor = yellow;
            lbPhone.Text = "SĐT";
            lbPhone.ForeColor = yellow;

            if (tbxPhone.Texts == "SĐT")
                tbxPhone.Texts = "";
            tbxPhone.ForeColor = Color.WhiteSmoke;

        }

        private void tbxPhone_Leave(object sender, EventArgs e)
        {
            tbxPhone.BorderSize = 1;
            tbxPhone.BorderColor = Color.DimGray;
            lbPhone.ForeColor = Color.DarkGray;

            if (tbxPhone.Texts == "")
            {
                tbxPhone.Texts = "SĐT";
                tbxPhone.ForeColor = Color.DimGray;
                lbPhone.Text = "";
            }
        }

        private void tbxIDCard_Enter(object sender, EventArgs e)
        {
            tbxIDCard.BorderSize = 2;
            tbxIDCard.BorderColor = yellow;
            lbIDCard.Text = "CMND";
            lbIDCard.ForeColor = yellow;

            if (tbxIDCard.Texts == "CMND")
                tbxIDCard.Texts = "";
            tbxIDCard.ForeColor = Color.WhiteSmoke;
        }
        private void tbxIDCard_Leave(object sender, EventArgs e)
        {
            tbxIDCard.BorderSize = 1;
            tbxIDCard.BorderColor = Color.DimGray;
            lbIDCard.ForeColor = Color.DarkGray;

            if (tbxIDCard.Texts == "")
            {
                tbxIDCard.Texts = "CMND";
                tbxIDCard.ForeColor = Color.DimGray;
                lbIDCard.Text = "";
            }
        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            tbxUsername.BorderSize = 2;
            tbxUsername.BorderColor = yellow;
            lbUsername.Text = "Tên tài khoản";
            lbUsername.ForeColor = yellow;

            if (tbxUsername.Texts == "Tên tài khoản")
                tbxUsername.Texts = "";
            tbxUsername.ForeColor = Color.WhiteSmoke;
        }

        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            tbxUsername.BorderSize = 1;
            tbxUsername.BorderColor = Color.DimGray;
            lbUsername.ForeColor = Color.DarkGray;

            if (tbxUsername.Texts == "")
            {
                tbxUsername.Texts = "Tên tài khoản";
                tbxUsername.ForeColor = Color.DimGray;
                lbUsername.Text = "";
            }
        }

        private void tbxEmail_Enter(object sender, EventArgs e)
        {
            tbxEmail.BorderSize = 2;
            tbxEmail.BorderColor = yellow;
            lbEmail.Text = "Email";
            lbEmail.ForeColor = yellow;

            if (tbxEmail.Texts == "Email")
                tbxEmail.Texts = "";
            tbxEmail.ForeColor = Color.WhiteSmoke;
        }

        private void tbxEmail_Leave(object sender, EventArgs e)
        {
            tbxEmail.BorderSize = 1;
            tbxEmail.BorderColor = Color.DimGray;
            lbEmail.ForeColor = Color.DarkGray;

            if (tbxEmail.Texts == "")
            {
                tbxEmail.Texts = "Email";
                tbxEmail.ForeColor = Color.DimGray;
                lbEmail.Text = "";
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            tbxPassword.BorderSize = 2;
            tbxPassword.BorderColor = yellow;
            lbPassword.Text = "Mật khẩu mới";
            lbPassword.ForeColor = yellow;

            if (tbxPassword.Texts == "Mật khẩu mới")
                tbxPassword.Texts = "";
            tbxPassword.ForeColor = Color.WhiteSmoke;
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            tbxPassword.BorderSize = 1;
            tbxPassword.BorderColor = Color.DimGray;
            lbPassword.ForeColor = Color.DarkGray;

            if (tbxPassword.Texts == "")
            {
                tbxPassword.Texts = "Mật khẩu mới";
                tbxPassword.ForeColor = Color.DimGray;
                lbPassword.Text = "";
            }
        }

        private void tbxConfirm_Enter(object sender, EventArgs e)
        {
            tbxConfirm.BorderSize = 2;
            tbxConfirm.BorderColor = yellow;
            lbConfirm.Text = "Xác nhận mật khẩu";
            lbConfirm.ForeColor = yellow;

            if (tbxConfirm.Texts == "Xác nhận mật khẩu")
                tbxConfirm.Texts = "";
            tbxConfirm.ForeColor = Color.WhiteSmoke;
        }

        private void tbxConfirm_Leave(object sender, EventArgs e)
        {
            tbxConfirm.BorderSize = 1;
            tbxConfirm.BorderColor = Color.DimGray;
            lbConfirm.ForeColor = Color.DarkGray;

            if (tbxConfirm.Texts == "")
            {
                tbxConfirm.Texts = "Xác nhận mật khẩu";
                tbxConfirm.ForeColor = Color.DimGray;
                lbConfirm.Text = "";
            }
        }

        private void dtpDob_Enter(object sender, EventArgs e)
        {
            tbxDob.BorderSize = 2;
            tbxDob.BorderColor = yellow;
            lbDob.ForeColor = yellow;
        }

        private void dtpDob_Leave(object sender, EventArgs e)
        {
            tbxDob.BorderSize = 1;
            tbxDob.BorderColor = Color.DimGray;
            lbDob.ForeColor = Color.DarkGray;
        }

        private void cbAuthority_Enter(object sender, EventArgs e)
        {
            tbxAuthority.BorderSize = 2;
            tbxAuthority.BorderColor = yellow;
            lbAuthority.ForeColor = yellow;
        }

        private void cbAuthority_Leave(object sender, EventArgs e)
        {
            tbxAuthority.BorderSize = 1;
            tbxAuthority.BorderColor = Color.DimGray;
            lbAuthority.ForeColor = Color.DarkGray;
        }
        #endregion

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "Tìm kiếm")
            {
                if (cbSearch.Text == " Họ tên")
                {
                    dgvListAccount.DataSource = AccountBUS.Instance.SearchAccount("Name", tbSearch.Text);
                }
                else if (cbSearch.Text == " SĐT")
                {
                    dgvListAccount.DataSource = AccountBUS.Instance.SearchAccount("SĐT", tbSearch.Text);

                }
                else if (cbSearch.Text == " Chức vụ")
                {
                    dgvListAccount.DataSource = AccountBUS.Instance.SearchAccount("Authority", tbSearch.Text);
                }
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
                tbSearch.Text = "Tìm kiếm";
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Tìm kiếm")
                tbSearch.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbUser.Text == "")
                    MessageBox.Show("Please select the account you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    var result = MessageBox.Show("Are you sure you want to delete user " + lbUser.Text +" ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        if (lbAuthori.Text == "Nhân viên")
                        {
                            PersonalInfoBUS.Instance.DeletePerson(lbUser.Text);
                            loadListAccount();
                            MessageBox.Show("Delete successfully.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lbUser.Text = "";
                        }
                        else
                            MessageBox.Show("Can't delete account of Manager.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvListAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dgvListAccount.Rows[e.RowIndex] != null)
                    {
                        lbUser.Text = dgvListAccount.Rows[e.RowIndex].Cells[1].Value.ToString();
                        lbAuthori.Text = dgvListAccount.Rows[e.RowIndex].Cells[4].Value.ToString();
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
