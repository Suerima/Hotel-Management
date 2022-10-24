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

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            customizeDesigning();
            openChildForm(new FormAccount());
            this.KeyPreview = true;
        }

        Color gray = Color.FromArgb(80, 72, 89);
        Color dark = Color.FromArgb(35, 32, 39);

        private void customizeDesigning()
        {
            panelQuanLySubMenu.Visible = false; // không hiện thị
            panelChucNangSubMenu.Visible = false;
            panelThongKeSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelQuanLySubMenu.Visible == true)
                panelQuanLySubMenu.Visible = false;
            if (panelChucNangSubMenu.Visible == true)
                panelChucNangSubMenu.Visible = false;
            if (panelThongKeSubMenu.Visible == true)
                panelThongKeSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        // Open child form
        private Form ActivForm = null;
        private void openChildForm(Form childForm)
        {
            if (ActivForm != null)
                ActivForm.Close();
            ActivForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAccount());
            customizeDesigning();
        }

        private void btnQuanly_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQuanLySubMenu);
            btnQL_NhanVien.BackColor = dark;
            btnQL_KhachHang.BackColor = dark;
            btnQL_Phong.BackColor = dark;
        }

        private void btnQL_NhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new FormQL_NhanVien());
            btnQL_NhanVien.BackColor = gray;
            btnQL_KhachHang.BackColor = dark;
            btnQL_Phong.BackColor = dark;

        }

        private void btnQL_KhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new FormQL_KhachHang());
            btnQL_NhanVien.BackColor = dark;
            btnQL_KhachHang.BackColor = gray;
            btnQL_Phong.BackColor = dark;

        }

        private void btnQL_Phong_Click(object sender, EventArgs e)
        {
            openChildForm(new FormQL_Phong());
            btnQL_NhanVien.BackColor = dark;
            btnQL_KhachHang.BackColor = dark;
            btnQL_Phong.BackColor = gray;

        }

        private void btnChucnang_Click(object sender, EventArgs e)
        {
            
            showSubMenu(panelChucNangSubMenu);
            btnCN_ThuePhong.BackColor = dark;
            btnCN_TraPhong.BackColor = dark;
            btnCN_DichVu.BackColor = dark;
        }

        private void btnCN_ThuePhong_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCN_ThuePhong());
            btnCN_ThuePhong.BackColor = gray;
            btnCN_TraPhong.BackColor = dark;
            btnCN_DichVu.BackColor = dark;
        }

        private void btnCN_TraPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCN_TraPhong());
            btnCN_ThuePhong.BackColor = dark;
            btnCN_TraPhong.BackColor = gray;
            btnCN_DichVu.BackColor = dark;
        }

        private void btnCN_DichVu_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCN_DichVu());
            btnCN_ThuePhong.BackColor = dark;
            btnCN_TraPhong.BackColor = dark;
            btnCN_DichVu.BackColor = gray;
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThongKeSubMenu);
            btnTk_DichVu.BackColor = dark;
            btnTk_ThuePhong.BackColor = dark;
        }

        private void btnTk_DichVu_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDT_DichVu());
            btnTk_DichVu.BackColor = gray;
            btnTk_ThuePhong.BackColor = dark;
        }

        private void btnTk_ThuePhong_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDT_ThuePhong());
            btnTk_DichVu.BackColor = dark;
            btnTk_ThuePhong.BackColor = gray;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (ActivForm.Name)
            {
                case "FormQL_NhanVien":
                    if (e.KeyCode == Keys.Delete)
                        ((FormQL_NhanVien)ActivForm).DeleteEmployee();
                    break;
                case "FormQL_KhachHang":
                    if (e.KeyCode == Keys.Delete)
                        ((FormQL_KhachHang)ActivForm).DeleteCustomer();
                    break;
                case "FormQL_Phong":
                    if (e.KeyCode == Keys.Delete)
                        ((FormQL_Phong)ActivForm).DeleteRoom();
                    break;
                case "FormCN_ThuePhong":
                    if (e.KeyCode == Keys.Delete)
                        ((FormCN_ThuePhong)ActivForm).DeleteBooking();
                    break;
            }
        }
    }
}
