using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
            loadData();
        }
          
        void loadData()
        {
            DataTable dt = AccountBUS.Instance.GetAccount(FormLogin.username);
            
            try
            { 
                tbUsername_in.Text = dt.Rows[0]["Username"].ToString();
                tbName_in.Text = dt.Rows[0]["Name"].ToString();
                tbPhone_in.Text = dt.Rows[0]["Phone"].ToString();
                tbEmail_in.Text = dt.Rows[0]["Email"].ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dt.Rows[0]["Avatar"]);
                pictureBox.Image = new Bitmap(memoryStream);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            
        private string path;
        private void linkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.bmp; *.wmf; *.png)| *.gif; *.jpg; *.bmp; *.wmf; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = openFileDialog.FileName; // Gán image lên picturebox
                path = openFileDialog.FileName.ToString(); // Lấy path
            }
        }

        private void reset()
        {
            tbName.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
            tbCurrentPassword.Text = "";
            tbNewPassword.Text = "";
            tbConfirmPassword.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNewPassword.Text != tbConfirmPassword.Text && tbNewPassword.Text != "")
                {
                    MessageBox.Show("The password confirmation does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Account account = new Account(tbUsername_in.Text, tbConfirmPassword.Text, tbEmail.Text, tbName.Text, tbPhone.Text);
                    AccountBUS.Instance.UpdateAccount(account, path);
                    loadData();
                    reset();
                    MessageBox.Show("Update successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

 
    }
}
