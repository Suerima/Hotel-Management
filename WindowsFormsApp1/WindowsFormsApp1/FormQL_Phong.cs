using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FormQL_Phong : Form
    {
        private bool checkButton = false;
        Color yellow = Color.FromArgb(247, 206, 69);
        string filename = "D:\\QuanLyKhachSan\\WindowsFormsApp1\\WindowsFormsApp1\\Resources\\logo.png";
        
        private string status;
        int index;
        int count;
        ArrayList alist;

        public FormQL_Phong()
        {
            InitializeComponent();
            tabControl.TabPages.Remove(tabPageEdit);

            loadData();

            if (FormLogin.authority == "Nhân viên")
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false; 
            }
        }

        void loadData()
        {
            dgvListRoom.DataSource = RoomBUS.Instance.GetRoom();
            lbRecord.Text = "Số lượng phòng: " + dgvListRoom.RowCount.ToString();
        }

        static public bool checkPrice(string price)
        {
            Regex isValidInput = new Regex(@"^[0-9]*$");
            if (isValidInput.IsMatch(price))
                return true;
            return false;
        }

        private void reset()
        {
            tbRoomID.Texts = GetNextRoomID();
            cbType.Text = "Standard";
            cbPerson.Text = "2";
            cbTypeBed.Text = "Giường đôi";
            tbPrice.Texts = "Price";
        }

        private void dgvListRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow r = dgvListRoom.Rows[e.RowIndex];
                if (r != null)
                {
                    tbRoomID.Texts = r.Cells[0].Value.ToString();
                    cbType.Text = r.Cells[1].Value.ToString();
                    cbPerson.Text = r.Cells[2].Value.ToString();
                    tbPrice.Texts = r.Cells[3].Value.ToString();
                    status = r.Cells[4].Value.ToString();
                }
            }
        }

        public string GetNextRoomID()
        {
            string lastID = RoomBUS.Instance.GetLastRoomID();

            if (lastID == null)
                return "P101";

            int nextID = int.Parse(lastID.Remove(0, 1)) + 1; // Ex: BK012 ->  13

            string zeroNumber = "";

            for (int i = 1; i <= 3; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= 3 - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return "P" + zeroNumber + nextID.ToString();
                }
            }
            return "P" + nextID;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabPageList);
            tabControl.TabPages.Add(tabPageEdit);
            tabPageEdit.Text = "Thêm phòng";
            reset();
            checkButton = true;
            resetCheckListBox();
            pictureBox1.ImageLocation = filename; // Gán image lên picturebox
            alist = new ArrayList();
            index = 0;
            count = 0;
            lbCountImage.Text = count.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbRoomID.Texts == "")
                MessageBox.Show("Chọn phòng bạn muốn cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                tabControl.TabPages.Remove(tabPageList);
                tabControl.TabPages.Add(tabPageEdit);
                tabPageEdit.Text = "Cập nhật thông tin phòng";
                checkButton = false;
                PopulateListCheckBox(tbRoomID.Texts);
                loadImageRoom(tbRoomID.Texts);

            }
        }
       
        public void DeleteRoom()
        {
            try
            {
                if (tbRoomID.Texts == "")
                    MessageBox.Show("Vui lòng chọn phòng muốn xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    var result = MessageBox.Show("Bạn có chắc muốn xoá phòng này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        RoomBUS.Instance.DeleteRoom(tbRoomID.Texts);
                        loadData();
                        MessageBox.Show("Xoá thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbRoomID.Texts = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRoom();
        }

        private string[] convertDetailID(string[] amenities, int length)
        {
            string[] r = new string[length];

            for (int i = 0; i < length; i++)
            {
                if (String.Compare(amenities[i], "Hai giường đơn") == 0)
                    r[i] = "DT001";
                else if (String.Compare(amenities[i], "Giường đôi") == 0)
                    r[i] = "DT002";
                else if (String.Compare(amenities[i], "Hướng ra biển") == 0)
                    r[i] = "DT003";
                else if (String.Compare(amenities[i], "Hướng ra phố") == 0)
                    r[i] = "DT004";
                else if (String.Compare(amenities[i], "Bồn tắm") == 0)
                    r[i] = "DT005";
                else if (String.Compare(amenities[i], "Hồ bơi riêng") == 0)
                    r[i] = "DT006";
                else if (String.Compare(amenities[i], "Ban công") == 0)
                    r[i] = "DT007";
                else if (String.Compare(amenities[i], "Máy pha cafe") == 0)
                    r[i] = "DT008";
                else
                    r[i] = "DT009";
            }
            return r;
        }

        void resetCheckListBox()
        {
            for (int i = 0; i < clbAmenities.Items.Count; i++)
                clbAmenities.SetItemCheckState(i, CheckState.Unchecked);
        }

        private void PopulateListCheckBox(string roomid)
        {
            resetCheckListBox();

            string[] listDetails = new string[8];
            DetailDAO.Instance.GetDetailsRoom(roomid).CopyTo(listDetails, 0);

            cbTypeBed.Text = listDetails[0];

            int j = 1;
            for (int i = 0; i < clbAmenities.Items.Count; i++)
            {
                if (clbAmenities.Items[i].ToString() == listDetails[j])
                {
                    clbAmenities.SetItemCheckState(i, CheckState.Checked);
                    j++;
                }    
            }    
        }

        private void loadImageRoom(string roomID)
        {
            alist = new ArrayList();
            alist = RoomDAO.Instance.LoadListImages(roomID); pictureBox1.Image.Dispose();
            pictureBox1.Image = System.Drawing.Image.FromFile(alist[0].ToString());
            index = 0;
            lbCountImage.Text =  alist.Count.ToString();
        }

        private string[] GetListCheckedItem()
        {
            string[] lstCheckedItem = new string[8];
            lstCheckedItem[0] = cbTypeBed.Text;
            int j = 1;
            for (int i = 0; i < clbAmenities.Items.Count; i++)
            {
                if (clbAmenities.GetItemChecked(i))
                {
                    lstCheckedItem[j] = clbAmenities.Items[i].ToString();
                    j++;
                }    
            }
            return convertDetailID(lstCheckedItem, j);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                if (index + 1 < Int32.Parse(lbCountImage.Text))
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(alist[index + 1].ToString());
                    index +=  1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                if (index - 1 >= 0)
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(alist[index - 1].ToString());
                    index -= 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lst = GetListCheckedItem();

                if (!checkPrice(tbPrice.Texts))
                    MessageBox.Show("Không được nhập kí tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {

                    if (checkButton == true)
                    {
                        Room room = new Room(tbRoomID.Texts, cbType.Text, cbPerson.Text, int.Parse(tbPrice.Texts), "Phòng trống");
                        RoomBUS.Instance.InsertRoom(room);
                        RoomDAO.Instance.InsertDetailRoom(lst, tbRoomID.Texts);
                        RoomDAO.Instance.InsertListImageRoom(tbRoomID.Texts, alist, count);
                        MessageBox.Show("Thêm phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Room room = new Room(tbRoomID.Texts, cbType.Text, cbPerson.Text, int.Parse(tbPrice.Texts), status);
                        RoomBUS.Instance.UpdateRoom(room);
                        RoomDAO.Instance.DeleteDetailRoom(tbRoomID.Texts);
                        RoomDAO.Instance.InsertDetailRoom(lst, tbRoomID.Texts);
                        MessageBox.Show("Cập nhật phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    tabControl.TabPages.Add(tabPageList);
                    tabControl.TabPages.Remove(tabPageEdit);
                    tbRoomID.Texts = "";
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabPageEdit);
            tabControl.TabPages.Add(tabPageList);
            tbRoomID.Texts = "";
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "Tìm kiếm")
            {
                if (cbSearch.Text == " Mã phòng")
                {
                    dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("RoomID", tbSearch.Text);
                }
                else if (cbSearch.Text == " Loại phòng")
                {
                    dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Type", tbSearch.Text);
                }
                else if (cbSearch.Text == " Số người")
                {
                    dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Person", tbSearch.Text);
                }
                else if (cbSearch.Text == " Giá")
                {
                    dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Price", tbSearch.Text);
                }
                else if (cbSearch.Text == " Tình trạng")
                {
                    dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Status", tbSearch.Text);
                }
            }
        }
      
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg; *.bmp; *.wmf; *.png)| *.jpg; *.bmp; *.wmf; *.png"; ;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                if (checkButton == true)
                {
                    alist.Add(dlg.FileName);
                    pictureBox1.ImageLocation = dlg.FileName;
                    count += 1;
                    lbCountImage.Text = count.ToString();
                }
                else
                {
                    RoomDAO.Instance.InsertImageRoom(tbRoomID.Texts, dlg.FileName);
                    loadImageRoom(tbRoomID.Texts);
                    MessageBox.Show("Thêm ảnh thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
     
        #region Event

        private void cbTypeBed_Enter(object sender, EventArgs e)
        {
            tbBed.BorderSize = 2;
            tbBed.BorderColor = yellow;
            lbBed.ForeColor = yellow;
        }

        private void cbTypeBed_Leave(object sender, EventArgs e)
        {
            tbBed.BorderSize = 1;
            tbBed.BorderColor = Color.DimGray;
            lbBed.ForeColor = Color.DarkGray;
        }
        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Tìm kiếm")
                tbSearch.Text = "";
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
                tbSearch.Text = "Tìm kiếm";
        }

        private void tbPrice_Enter(object sender, EventArgs e)
        {
            tbPrice.BorderSize = 2;
            tbPrice.BorderColor = yellow;
            lbPrice.Text = "Giá phòng";
            lbPrice.ForeColor = yellow;

            if (tbPrice.Texts == "Giá phòng")
                tbPrice.Texts = "";
            tbPrice.ForeColor = Color.WhiteSmoke;
        }

        private void tbPrice_Leave(object sender, EventArgs e)
        {
            tbPrice.BorderSize = 1;
            tbPrice.BorderColor = Color.DimGray;
            lbPrice.ForeColor = Color.DarkGray;

            if (tbPrice.Texts == "")
            {
                tbPrice.Texts = "Giá phòng";
                tbPrice.ForeColor = Color.DimGray;
                lbPrice.Text = "";
            }
        }


        private void cbType_Enter(object sender, EventArgs e)
        {
            tbType.BorderSize = 2;
            tbType.BorderColor = yellow;
            lbType.ForeColor = yellow;
        }

        private void cbType_Leave(object sender, EventArgs e)
        {
            tbType.BorderSize = 1;
            tbType.BorderColor = Color.DimGray;
            lbType.ForeColor = Color.DarkGray;
        }
        private void cbPerson_Enter(object sender, EventArgs e)
        {
            tbPerson.BorderSize = 2;
            tbPerson.BorderColor = yellow;
            lbPerson.ForeColor = yellow;
        }
        private void cbPerson_Leave(object sender, EventArgs e)
        {
            tbPerson.BorderSize = 1;
            tbPerson.BorderColor = Color.DimGray;
            lbPerson.ForeColor = Color.DarkGray;
        }

        #endregion

    }
}
