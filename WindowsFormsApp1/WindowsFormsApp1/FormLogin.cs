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
  

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username" || tbPassword.Text == "Password")
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }
            else
            {
                if (AccountBUS.Instance.Login(tbUsername.Text, tbPassword.Text))
                {
                    username = tbUsername.Text;
                    FormMain fm = new FormMain();
                    this.Hide();
                    fm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Your username or passward is incorrect.");
                }
            }
        }

        private void linkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormForgotPass fm = new FormForgotPass();
            this.Hide();
            fm.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #region Event
        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.LightGray;
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Username";
                tbUsername.ForeColor = Color.DimGray;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.LightGray;
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
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
        #endregion
    }
}
