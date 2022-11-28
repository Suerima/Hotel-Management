using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;
using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp1
{
    public partial class FormAcc_ThongTin : Form
    {

        Color yellow = Color.FromArgb(247, 206, 69);
        public FormAcc_ThongTin()
        {
            InitializeComponent();
            tabControl.TabPages.Remove(tabPersonal);
            tabControl.TabPages.Remove(tabLogin);
            loadData();
        }

        void loadData()
        {
            DataTable dt = AccountBUS.Instance.GetAccount(FormLogin.username);
            lbName.Text = dt.Rows[0]["Name"].ToString();

            try
            {
                lbName.Text = dt.Rows[0]["Name"].ToString();
                lbGender.Text = dt.Rows[0]["Gender"].ToString();
                lbDob.Text = dt.Rows[0]["Dob"].ToString().Replace(" 12:00:00 AM", string.Empty);
                lbAddress.Text = dt.Rows[0]["Address"].ToString();
                lbPhone.Text = dt.Rows[0]["Phone"].ToString();
                lbIDCard.Text = dt.Rows[0]["IDCard"].ToString();
                lbAuthority.Text = dt.Rows[0]["Authority"].ToString();
                lbUsername.Text = dt.Rows[0]["Username"].ToString();
                lbEmail.Text = dt.Rows[0]["Email"].ToString();

                tbName.Texts = lbName.Text;
                cbGender.Text = lbGender.Text;
               // tbDob.Text = lbDob.Text;
                tbAddress.Texts = lbAddress.Text;
                tbPhone.Texts = lbPhone.Text;
                tbIDCard.Texts = lbIDCard.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void SwapTabPage(TabPage tabRemoved, TabPage tabAdded)
        {
            tabControl.TabPages.Remove(tabRemoved);
            tabControl.TabPages.Add(tabAdded);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbName.Texts;
                string gender = cbGender.Text;
                DateTime dob = DateTime.ParseExact(dtpDob.Text, "dd/MM/yyyy", null);
                string address = tbAddress.Texts;
                string phone = tbPhone.Texts;
                string idcard = tbIDCard.Texts;


                if (!FormAcc_TaoAccount.checkName(name))
                    MessageBox.Show("Tên không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (!FormAcc_TaoAccount.checkPhone(phone))
                    MessageBox.Show("SĐT không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (!FormAcc_TaoAccount.checkIDCard(idcard))
                    MessageBox.Show("CMND không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {   //Convert.ToDateTime(tbDob.Text)
                    PersonalInfo perinfo = new PersonalInfo(FormLogin.username, name, gender, dob, address, phone, idcard);
                    PersonalInfoBUS.Instance.UpdatePersonalInfo(perinfo);
                    loadData();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SwapTabPage(tabPersonal, tabInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbChangePersonal_Click(object sender, EventArgs e)
        {
            SwapTabPage(tabInfo, tabPersonal);
        }

        private void lbChangeLogin_Click(object sender, EventArgs e)
        {
            SwapTabPage(tabInfo, tabLogin);
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            SwapTabPage(tabLogin,tabInfo);
        }

        private void btnCancelPersonal_Click(object sender, EventArgs e)
        {
            SwapTabPage(tabPersonal, tabInfo);
        }

        #region Event
        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            tbxCurrent.BorderSize = 2;
            tbxCurrent.BorderColor = yellow;
            lbCurrent.Text = "Current password";
            lbCurrent.ForeColor = yellow;

            if (tbxCurrent.Texts == "Current password")
            {
                tbxCurrent.Texts = "";
                tbxCurrent.ForeColor = Color.WhiteSmoke;
                tbxCurrent.PasswordChar = true;
            }
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            tbxCurrent.BorderSize = 1;
            tbxCurrent.BorderColor = Color.DimGray;
            lbCurrent.ForeColor = Color.DarkGray;

            if (tbxCurrent.Texts == "")
            {
                tbxCurrent.Texts = "Current password";
                tbxCurrent.ForeColor = Color.DimGray;
                tbxCurrent.PasswordChar = false;
                lbCurrent.Text = "";
            }
        }
        private void tbxNew_Enter(object sender, EventArgs e)
        {
            tbxNew.BorderSize = 2;
            tbxNew.BorderColor = Color.FromArgb(247, 206, 69);
            lbNew.Text = "New password";
            lbNew.ForeColor = Color.FromArgb(247, 206, 69);

            if (tbxNew.Texts == "New password")
            {
                tbxNew.Texts = "";
                tbxNew.ForeColor = Color.WhiteSmoke;
                tbxNew.PasswordChar = true;
            }
        }

        private void tbxNew_Leave(object sender, EventArgs e)
        {
            tbxNew.BorderSize = 1;
            tbxNew.BorderColor = Color.DimGray;
            lbNew.ForeColor = Color.DarkGray;

            if (tbxNew.Texts == "")
            {
                tbxNew.Texts = "New password";
                tbxNew.ForeColor = Color.DimGray;
                lbNew.Text = "";
                tbxNew.PasswordChar = false;
            }
        }
        private void tbxConfirm_Enter(object sender, EventArgs e)
        {
            tbxConfirm.BorderSize = 2;
            tbxConfirm.BorderColor = Color.FromArgb(247, 206, 69);
            lbConfirm.Text = "Confirm password";
            lbConfirm.ForeColor = Color.FromArgb(247, 206, 69);

            if (tbxConfirm.Texts == "Confirm password")
            {
                tbxConfirm.Texts = "";
                tbxConfirm.ForeColor = Color.WhiteSmoke;
                tbxConfirm.PasswordChar = true;
            }
        }

        private void tbxConfirm_Leave(object sender, EventArgs e)
        {
            tbxConfirm.BorderSize = 1;
            tbxConfirm.BorderColor = Color.DimGray;
            lbConfirm.ForeColor = Color.DarkGray;

            if (tbxConfirm.Texts == "")
            {
                tbxConfirm.Texts = "Confirm password";
                tbxConfirm.ForeColor = Color.DimGray;
                lbConfirm.Text = "";
                tbxConfirm.PasswordChar = false;
            }
        }
        #endregion

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnView.Visible = true;
            btnHide.Visible = false;
            tbxCurrent.PasswordChar = false;
            tbxNew.PasswordChar = false;
            tbxConfirm.PasswordChar = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            btnHide.Visible = true;
            btnView.Visible = false;
            tbxCurrent.PasswordChar = true;
            tbxNew.PasswordChar = true;
            tbxConfirm.PasswordChar = true;
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            try
            {
                string username = lbUsername.Text;
                string password = AccountBUS.Instance.GetPassword(username);
                string currentPass = tbxCurrent.Texts;
                string newPass = tbxNew.Texts;
                string confirmPass = tbxConfirm.Texts;
                
                if (!currentPass.Equals(password))
                {
                    MessageBox.Show("Mật khẩu hiện tại không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!newPass.Equals(confirmPass))
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(AccountBUS.Instance.ChangePassword(username, newPass) > 0) 
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SwapTabPage(tabLogin, tabInfo);
                }
                else
                {
                    MessageBox.Show("Thay đổi mật khẩu thất bại.", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #region Event
        private void cbGender_Enter(object sender, EventArgs e)
        {
            tbGender.BorderSize = 2;
            tbGender.BorderColor = yellow;
            lbGender1.ForeColor = yellow;
        }

        private void cbGender_Leave(object sender, EventArgs e)
        {
            tbGender.BorderSize = 1;
            tbGender.BorderColor = Color.DimGray;
            lbGender1.ForeColor = Color.DarkGray;
        }
        private void tbName_Enter(object sender, EventArgs e)
        {
            tbName.BorderSize = 2;
            tbName.BorderColor = yellow;
            lbName1.Text = "Họ tên";
            lbName1.ForeColor = yellow;

            if (tbName.Texts == "Họ tên")
                tbName.Texts = "";
            tbName.ForeColor = Color.WhiteSmoke;
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            tbName.BorderSize = 1;
            tbName.BorderColor = Color.DimGray;
            lbName1.ForeColor = Color.DarkGray;

            if (tbName.Texts == "")
            {
                tbName.Texts = "Họ tên";
                tbName.ForeColor = Color.DimGray;
                lbName1.Text = "";
            }
        }
        private void dtpDob_Enter(object sender, EventArgs e)
        {
            tbDob.BorderSize = 2;
            tbDob.BorderColor = yellow;
            lbDob1.ForeColor = yellow;
        }

        private void dtpDob_Leave(object sender, EventArgs e)
        {
            tbDob.BorderSize = 1;
            tbDob.BorderColor = Color.DimGray;
            lbDob1.ForeColor = Color.DarkGray;
        }
        private void tbAddress_Enter(object sender, EventArgs e)
        {
            tbAddress.BorderSize = 2;
            tbAddress.BorderColor = yellow;
            lbAddress1.Text = "Địa chỉ";
            lbAddress1.ForeColor = yellow;

            if (tbAddress.Texts == "Địa chỉ")
                tbAddress.Texts = "";
            tbAddress.ForeColor = Color.WhiteSmoke;
        }
        private void tbAddress_Leave(object sender, EventArgs e)
        {
            tbAddress.BorderSize = 1;
            tbAddress.BorderColor = Color.DimGray;
            lbAddress1.ForeColor = Color.DarkGray;

            if (tbAddress.Texts == "")
            {
                tbAddress.Texts = "Địa chỉ";
                tbAddress.ForeColor = Color.DimGray;
                lbAddress1.Text = "";
            }
        }

        private void tbPhone_Enter(object sender, EventArgs e)
        {
            tbPhone.BorderSize = 2;
            tbPhone.BorderColor = yellow;
            lbPhone1.Text = "SĐT";
            lbPhone1.ForeColor = yellow;

            if (tbPhone.Texts == "SĐT")
                tbPhone.Texts = "";
            tbPhone.ForeColor = Color.WhiteSmoke;
        }

        private void tbPhone_Leave(object sender, EventArgs e)
        {
            tbPhone.BorderSize = 1;
            tbPhone.BorderColor = Color.DimGray;
            lbPhone1.ForeColor = Color.DarkGray;

            if (tbPhone.Texts == "")
            {
                tbPhone.Texts = "SĐT";
                tbPhone.ForeColor = Color.DimGray;
                lbPhone1.Text = "";
            }
        }

        private void tbIDCard_Enter(object sender, EventArgs e)
        {
            tbIDCard.BorderSize = 2;
            tbIDCard.BorderColor = yellow;
            lbIDCard1.Text = "CMND";
            lbIDCard1.ForeColor = yellow;

            if (tbIDCard.Texts == "CMND")
                tbIDCard.Texts = "";
            tbIDCard.ForeColor = Color.WhiteSmoke;
        }

        private void tbIDCard_Leave(object sender, EventArgs e)
        {
            tbIDCard.BorderSize = 1;
            tbIDCard.BorderColor = Color.DimGray;
            lbIDCard1.ForeColor = Color.DarkGray;

            if (tbIDCard.Texts == "")
            {
                tbIDCard.Texts = "CMND";
                tbIDCard.ForeColor = Color.DimGray;
                lbIDCard1.Text = "";
            }
        }
        #endregion
    }
}
