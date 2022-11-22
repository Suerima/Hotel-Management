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
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class FormResetPass : Form
    {
        string randomCode;
        public static string to;

        public FormResetPass()
        {
            InitializeComponent();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username" || tbEmail.Text == "Email address")
                MessageBox.Show("Please enter your username and email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!AccountBUS.Instance.ForgotAccount(tbEmail.Text, tbUsername.Text))
                MessageBox.Show("Couldn't find your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    string from, pass, messageBody;
                    Random rand = new Random();
                    randomCode = (rand.Next(999999)).ToString();

                    AccountBUS.Instance.UpdatePassword(randomCode, tbEmail.Text);

                    MailMessage message = new MailMessage();
                    to = (tbEmail.Text).ToString();
                    from = "lu2002ny@gmail.com";
                    pass = "idofzgnlvweosnyw";
                    messageBody = "Your reset code is " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "DEHOTEL password reseting code";
                    
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);                   
                    smtp.Send(message);
                    MessageBox.Show("New password sent successfully to your email address.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    backFormLogin();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void backFormLogin()
        {
            this.Close();
            FormLogin fm = new FormLogin();
            fm.Show();
        }

        private void btnLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            backFormLogin();
        }
        #region Event

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Gainsboro;
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

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Email address")
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = Color.Gainsboro;
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Email address";
                tbEmail.ForeColor = Color.DimGray;

            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormResetPass_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
