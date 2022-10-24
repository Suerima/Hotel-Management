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
    public partial class FormForgotPass : Form
    {
        public FormForgotPass()
        {
            InitializeComponent();
        }

        static public string email;

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin fm = new FormLogin();
            fm.Show();
        }
            
        private void btContinue_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Enter your email address")
            {
                MessageBox.Show("Invalid your email address.");
                return;
            }
            else
            {
                if (AccountBUS.Instance.ForgotAccount(tbEmail.Text, tbUsername.Text))
                {
                    email = tbEmail.Text;
                    FormResetPass fm = new FormResetPass();
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your email address is incorrect.");
                }
            }
        }

        #region Event
        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Enter your email address")
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = Color.Gainsboro;
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Enter your email address";
                tbEmail.ForeColor = Color.DimGray;
            }
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Enter your username")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Gainsboro;
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Enter your username";
                tbUsername.ForeColor = Color.DimGray;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        private void panelForgotPass_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormForgotPass_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
