using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
        }

        static public string username;
        static public string authority;


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Tên tài khoản" || tbPassword.Text == "Mật khẩu")
                MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (AccountBUS.Instance.Login(tbUsername.Text, tbPassword.Text))
                {
                    username = tbUsername.Text;
                    authority = AccountBUS.Instance.GetAuthority(username);
                    FormMain fm = new FormMain();
                    this.Hide();
                    fm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void linkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormResetPass fm = new FormResetPass();
            this.Hide();
            fm.Show();
        }

        #region Event
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Tên tài khoản")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Black;
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Tên tài khoản";
                tbUsername.ForeColor = Color.DimGray;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Mật khẩu")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Black;
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Mật khẩu";
                tbPassword.ForeColor = Color.DimGray;
                tbPassword.UseSystemPasswordChar = false;
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormPanelIcon_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnView.Visible = true;
            btnHide.Visible = false;
            tbPassword.UseSystemPasswordChar = false;

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            btnHide.Visible = true;
            btnView.Visible = false;
            tbPassword.UseSystemPasswordChar = true;
        }
        #endregion
    }
}
