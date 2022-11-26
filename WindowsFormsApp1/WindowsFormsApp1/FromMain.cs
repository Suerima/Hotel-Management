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
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {

        private Panel leftBorderBtn; //panelSideMenu
        private Button currentBtn;
        private Panel panelParent;

        Color gray = Color.FromArgb(58, 60, 66);
        Color black = Color.FromArgb(31, 33, 37);
        Color dark = Color.FromArgb(46, 48, 52);
        Color yellow = Color.FromArgb(247, 206, 69);
        public FormMain()
        {
            InitializeComponent();
            customizeDesigning();
            openChildForm(new FormAcc_ThongTin());
            loadData();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 35);
            panelSideMenu.Controls.Add(leftBorderBtn);
            if (FormLogin.authority == "Nhân viên")
            {
                btnAcc_Create.Visible = false;
                panelAccountSubMenu.Size = new Size(291, 45);
                btnThongke.Visible = false;
            }
            this.KeyPreview = true;
        }

        private void customizeDesigning()
        {
            panelAccountSubMenu.Visible = false;
            panelQuanLySubMenu.Visible = false; // không hiện thị
            panelChucNangSubMenu.Visible = false;
            panelThongKeSubMenu.Visible = false;
        }

        private void ActivateButton(object senderBtn, int y)
        {
            if (senderBtn != null)
            {
                reset();
                currentBtn = (Button)senderBtn;
                panelParent = (Panel)currentBtn.Parent;

                currentBtn.BackColor = gray;
                leftBorderBtn.BackColor = yellow;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y + y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void reset() //0 parent, 1 child
        {
            if (currentBtn != null)
            {
                panelParent = (Panel)currentBtn.Parent;
                if (panelParent == panelSideMenu)
                    currentBtn.BackColor = black;
                else
                    currentBtn.BackColor = dark;
                leftBorderBtn.Visible = false;
            }
        } 
        
        private void hideSubMenu()
        {
            if (panelAccountSubMenu.Visible == true)
                panelAccountSubMenu.Visible = false;
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
           // openChildForm(new FormAccount());
            showSubMenu(panelAccountSubMenu);
            btnAcc_Information.BackColor = dark;
            btnAcc_Create.BackColor = dark;
            ActivateButton(sender, 0);
        }

        private void btnAcc_Information_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAcc_ThongTin());
            btnAcc_Create.BackColor = dark;
            ActivateButton(sender, btnAccount.Location.Y + 36);
        }

        private void btnAcc_Create_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAcc_TaoAccount());
            btnAcc_Information.BackColor = dark;
            ActivateButton(sender, btnAccount.Location.Y + 36);
        }
        private void btnQuanly_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQuanLySubMenu);
            btnQL_NhanVien.BackColor = dark;
            btnQL_KhachHang.BackColor = dark;
            btnQL_Phong.BackColor = dark;   
            ActivateButton(sender, 0);
        }

        private void btnQL_NhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new FormQL_NhanVien());
            btnQL_KhachHang.BackColor = dark;
            btnQL_Phong.BackColor = dark;
            ActivateButton(sender, btnQuanly.Location.Y + 36);
        }

        private void btnQL_KhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new FormQL_KhachHang());
            btnQL_NhanVien.BackColor = dark;
            btnQL_Phong.BackColor = dark;
            ActivateButton(sender, btnQuanly.Location.Y + 36) ;

        }

        private void btnQL_Phong_Click(object sender, EventArgs e)
        {
            openChildForm(new FormQL_Phong());
            btnQL_NhanVien.BackColor = dark;
            btnQL_KhachHang.BackColor = dark;
            ActivateButton(sender, btnQuanly.Location.Y + 36);

        }

        private void btnChucnang_Click(object sender, EventArgs e)
        {
            
            showSubMenu(panelChucNangSubMenu);
            btnCN_ThuePhong.BackColor = dark;
            btnCN_TraPhong.BackColor = dark;
            btnCN_DichVu.BackColor = dark;
            ActivateButton(sender, 0);

        }

        private void btnCN_ThuePhong_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBooking());
            btnCN_TraPhong.BackColor = dark;
            btnCN_DichVu.BackColor = dark;
            ActivateButton(sender, btnChucnang.Location.Y + 36);
        }

        private void btnCN_TraPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCN_TraPhong());
            btnCN_ThuePhong.BackColor = dark;
            btnCN_DichVu.BackColor = dark;
            ActivateButton(sender, btnChucnang.Location.Y + 36);
        }

        private void btnCN_DichVu_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCN_DichVu());
            btnCN_ThuePhong.BackColor = dark;
            btnCN_TraPhong.BackColor = dark;
            ActivateButton(sender, btnChucnang.Location.Y + 36);
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThongKeSubMenu);
            btnTk_DichVu.BackColor = dark;
            btnTk_ThuePhong.BackColor = dark;
            ActivateButton(sender, 0);
        }

        private void btnTk_DichVu_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDT_DichVu());
            btnTk_ThuePhong.BackColor = dark;
            ActivateButton(sender, btnThongke.Location.Y + 36);
        }

        private void btnTk_ThuePhong_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDT_ThuePhong());
            btnTk_DichVu.BackColor = dark;
            ActivateButton(sender, btnThongke.Location.Y + 36);
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
/*                case "FormBooking":
                    if (e.KeyCode == Keys.Delete)
                        ((FormBooking)ActivForm).DeleteBooking();*/
            }
        }

        void loadData()
        {
            //Để đọc dữ liệu hình ảnh ra ta dùng 1 mảng Byte để chứa giá trị của field hình ảnh. Sau đó muốn hiển thị nó lên PictureBox ta phải dùng MemoryStream để đưa ra:

            DataTable dt = AccountBUS.Instance.GetAccount(FormLogin.username);
            MemoryStream memoryStream = new MemoryStream((byte[])dt.Rows[0]["Avatar"]);
            pictureBox.Image = Image.FromStream(memoryStream);

            lbName.Text = dt.Rows[0]["Name"].ToString();
            int x = (int)(Math.Round((-0.46 * (lbName.Size.Width * 1.3) + 135)));
            lbName.Location = new Point(x, 120);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg; *.bmp; *.wmf; *.png)| *.jpg; *.bmp; *.wmf; *.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = dlg.FileName; // Gán image lên picturebox               
                AccountBUS.Instance.UpdateImage(FormLogin.username, dlg.FileName.ToString());                           
                MessageBox.Show("Avatar update successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
