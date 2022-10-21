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
    public partial class FormResetPass : Form
    {
        public FormResetPass()
        {
            InitializeComponent();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (tbNewPass.Text == "New password" && tbConPass.Text == "Confirm password")
            {
                MessageBox.Show("Enter your new password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tbNewPass.Text != tbConPass.Text)
            {
                MessageBox.Show("The password confirmation does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            else
            {
                try
                {
                    AccountBUS.Instance.UpdatePassword(tbConPass.Text, FormForgotPass.email);
                    MessageBox.Show("Password changed successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                FormLogin fm = new FormLogin();
                fm.Show();
                this.Hide();
            }
        }
        #region Event
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void tbNewPass_Enter(object sender, EventArgs e)
        {
            if (tbNewPass.Text == "New password")
            {
                tbNewPass.Text = "";
                tbNewPass.ForeColor = Color.Gainsboro;
            }
        }

        private void tbNewPass_Leave(object sender, EventArgs e)
        {
            if (tbNewPass.Text == "")
            {
                tbNewPass.Text = "New password";
                tbNewPass.ForeColor = Color.DimGray;
            }
        }

        private void tbConPass_Enter(object sender, EventArgs e)
        {
            if (tbConPass.Text == "Confirm password")
            {
                tbConPass.Text = "";
                tbConPass.ForeColor = Color.Gainsboro;
            }
        }

        private void tbConPass_Leave(object sender, EventArgs e)
        {
            if (tbConPass.Text == "")
            {
                tbConPass.Text = "Confirm password";
                tbConPass.ForeColor = Color.DimGray;
            }
        }
        private void FormResetPass_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
