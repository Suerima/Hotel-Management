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
            cbGender.Text = "Male";
            cbAuthority.Text = "Manager";
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
            
            if (name == "Fullname" || address == "Address" || phone == "Phone" || idcard == "IDCard" || username == "Username" || email == "Email" || password == "Password" || confirm == "Confirm")
            {
                MessageBox.Show("Missing information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!checkName(name))
            {
            MessageBox.Show("Invalid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!checkPhone(phone))
            {
                MessageBox.Show("Invalid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!checkIDCard(idcard))
            {
                MessageBox.Show("Invalid IDCard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!checkEmail(email))
            {
                MessageBox.Show("Not a valid E-mail adrress.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!password.Equals(confirm))
            {
                MessageBox.Show("Password and Confirm Password does not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Account account = new Account(username, password, email, authority, image);
                PersonalInfo perInfo = new PersonalInfo(username, name, gender, dob, address, phone, idcard);

                if (AccountBUS.Instance.InsertAccount(account, perInfo) > 1)
                {
                    MessageBox.Show("Created successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                    loadListAccount();
                }
                else
                    MessageBox.Show("That userame already exists.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void reset()
        {
            tbxFullname.Texts = "Fullname";
            tbxFullname.ForeColor = Color.DimGray;
            lbFullname.Text = "";

            tbxEmail.Texts = "Email";
            tbxEmail.ForeColor = Color.DimGray;
            lbEmail.Text = "";

            tbxAddress.Texts = "Address";
            tbxAddress.ForeColor = Color.DimGray;
            lbAddress.Text = "";

            tbxPhone.Texts = "Phone";
            tbxPhone.ForeColor = Color.DimGray;
            lbPhone.Text = "";

            tbxUsername.Texts = "Username";
            tbxUsername.ForeColor = Color.DimGray;
            lbUsername.Text = "";

            tbxIDCard.Texts = "IDCard";
            tbxIDCard.ForeColor = Color.DimGray;
            lbIDCard.Text = "";

            tbxPassword.Texts = "Password";
            tbxPassword.ForeColor = Color.DimGray;
            lbPassword.Text = "";

            tbxConfirm.Texts = "Confirm";
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
            lbFullname.Text = "Fullname";
            lbFullname.ForeColor = yellow;

            if (tbxFullname.Texts == "Fullname")
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
                tbxFullname.Texts = "Fullname";
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
            lbAddress.Text = "Address";
            lbAddress.ForeColor = yellow;

            if (tbxAddress.Texts == "Address")
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
                tbxAddress.Texts = "Address";
                tbxAddress.ForeColor = Color.DimGray;
                lbAddress.Text = "";
            }

        }

        private void tbxPhone_Enter(object sender, EventArgs e)
        {
            tbxPhone.BorderSize = 2;
            tbxPhone.BorderColor = yellow;
            lbPhone.Text = "Phone";
            lbPhone.ForeColor = yellow;

            if (tbxPhone.Texts == "Phone")
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
                tbxPhone.Texts = "Phone";
                tbxPhone.ForeColor = Color.DimGray;
                lbPhone.Text = "";
            }
        }

        private void tbxIDCard_Enter(object sender, EventArgs e)
        {
            tbxIDCard.BorderSize = 2;
            tbxIDCard.BorderColor = yellow;
            lbIDCard.Text = "IDCard";
            lbIDCard.ForeColor = yellow;

            if (tbxIDCard.Texts == "IDCard")
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
                tbxIDCard.Texts = "IDCard";
                tbxIDCard.ForeColor = Color.DimGray;
                lbIDCard.Text = "";
            }
        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            tbxUsername.BorderSize = 2;
            tbxUsername.BorderColor = yellow;
            lbUsername.Text = "Username";
            lbUsername.ForeColor = yellow;

            if (tbxUsername.Texts == "Username")
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
                tbxUsername.Texts = "Username";
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
            lbPassword.Text = "Password";
            lbPassword.ForeColor = yellow;

            if (tbxPassword.Texts == "Password")
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
                tbxPassword.Texts = "Password";
                tbxPassword.ForeColor = Color.DimGray;
                lbPassword.Text = "";
            }
        }

        private void tbxConfirm_Enter(object sender, EventArgs e)
        {
            tbxConfirm.BorderSize = 2;
            tbxConfirm.BorderColor = yellow;
            lbConfirm.Text = "Confirm";
            lbConfirm.ForeColor = yellow;

            if (tbxConfirm.Texts == "Confirm")
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
                tbxConfirm.Texts = "Confirm";
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
            if (tbSearch.Text != "Search")
            {
                if (cbSearch.Text == " Fullname")
                {
                    dgvListAccount.DataSource = AccountBUS.Instance.SearchAccount("Name", tbSearch.Text);
                }
                else if (cbSearch.Text == " Phone")
                {
                    dgvListAccount.DataSource = AccountBUS.Instance.SearchAccount("Phone", tbSearch.Text);

                }
                else if (cbSearch.Text == " Authority")
                {
                    dgvListAccount.DataSource = AccountBUS.Instance.SearchAccount("Authority", tbSearch.Text);
                }
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
                tbSearch.Text = "Search";
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Search")
                tbSearch.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbUser.Text == "")
                    MessageBox.Show("Please select the account you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var result = MessageBox.Show("Are you sure you want to delete user " + lbUser.Text +" ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (lbAuthori.Text == "Cashier")
                        {
                            PersonalInfoBUS.Instance.DeletePerson(lbUser.Text);
                            loadListAccount();
                            MessageBox.Show("Delete successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lbUser.Text = "";
                        }
                        else
                            MessageBox.Show("Can't delete account of Manager.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
