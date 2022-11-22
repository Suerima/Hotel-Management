using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class FormCN_ThuePhong : Form
    {
        public FormCN_ThuePhong()
        {
            InitializeComponent();
            loadListCustomer();
            loadListRoom();
            loadListBooking();
            loadBookingID();
            lbDateCreated.Text = DateTime.Now.ToString("yyyy-MM-dd");
            tabControl.TabPages.Remove(tabPageDetail);
        }
        void loadListCustomer()
        {
            dgvListCustomer.DataSource = CustomerBUS.Instance.GetCustomerInBooking();
        }

        void loadListRoom()
        {
            dgvListRoom.DataSource = RoomBUS.Instance.GetRoomInBooking();
        }

        void loadListBooking()
        {
            dgvListBooking.DataSource = BookingBUS.Instance.GetBooking();
        }

        void loadBookingID()
        {
            tbBookingID.Text = GetNextBookingID();
        }

        public string GetNextBookingID()
        {
    
            string lastID = BookingBUS.Instance.GetLastBookingID();

            if (lastID == null)
                return "BK001";

            int nextID = int.Parse(lastID.Remove(0, 2)) + 1; // Ex: BK012 ->  13
            string zeroNumber = "";
            for (int i = 1; i <= 3; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= 3 - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return "BK" + zeroNumber + nextID.ToString();
                }
            }
            return "BK" + nextID;
        }

        private void dgvListCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow r = dgvListCustomer.Rows[e.RowIndex];
                if (r != null)
                {
                    tbCustomerID.Text = r.Cells[0].Value.ToString();
                    tbName.Text = r.Cells[1].Value.ToString();
                }
            }         
        }
        private void dgvListBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow r = dgvListBooking.Rows[e.RowIndex];
                if (r != null)
                {
                    lbBookingID.Text = r.Cells[0].Value.ToString();
                    lbManagerID.Text = r.Cells[1].Value.ToString();
                    lbCustomerID.Text = r.Cells[2].Value.ToString();
                    lbRoomID.Text = r.Cells[3].Value.ToString();

                    string x = r.Cells[4].Value.ToString();
                    DateTime arrive = DateTime.Parse(x);
                    lbArrival.Text = arrive.ToString("yyyy-MM-dd");
                }
            }
        }

        private void dgvListRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow r = dgvListRoom.Rows[e.RowIndex];
                if (r != null)
                {
                    tbRoomID.Text = r.Cells[0].Value.ToString();
                    tbType.Text = r.Cells[1].Value.ToString();
                }
            }
        }

        private int checkBookingID(string bookingid)
        {
            for (int i = 0; i < dgvListBooking.Rows.Count; i++)
                if (dgvListBooking.Rows[i].Cells[0].Value != null && dgvListBooking.Rows[i].Cells[0].Value.ToString() == bookingid)
                    return i;
            return -1;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime arrival = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
             
                if (CustomerBUS.Instance.GetCustomerIDInBooking(tbCustomerID.Text) == null) 
                    MessageBox.Show("Invalid CustomerID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (tbRoomID.Text == "None")
                    MessageBox.Show("Invalid RoomID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Booking booking = new Booking(tbBookingID.Text, FormLogin.username, tbCustomerID.Text, tbRoomID.Text, arrival);
                    
                    BookingBUS.Instance.InsertBooking(booking);
                    BookingBUS.Instance.UpdateStatusRoom(tbRoomID.Text, "Full");
                    
                    loadListCustomer();
                    loadListRoom();
                    loadBookingID();
                    
                    MessageBox.Show("Inserted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            loadListBooking();
            tabControl.TabPages.Remove(tabPageBooking);
            tabControl.TabPages.Add(tabPageDetail);
            tabPageDetail.Text = "Detail";
            lbNumber.Text = dgvListBooking.Rows.Count.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBooking();
        }

        public void DeleteBooking()
        {
            try
            {
                if (checkBookingID(lbBookingID.Text) == -1)
                    MessageBox.Show("Vui lòng chọn mã đơn muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var result = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        BookingBUS.Instance.UpdateStatusRoom(lbRoomID.Text, "Available");

                        BookingBUS.Instance.DeleteBooking(lbBookingID.Text);

                        loadListBooking();

                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadListCustomer();
            loadListRoom();
            loadBookingID();
      
            tabControl.TabPages.Remove(tabPageDetail);
            tabControl.TabPages.Add(tabPageBooking);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "Search")
                dgvListBooking.DataSource = BookingBUS.Instance.SearchBooking(tbSearch.Text);
        }
        #region Event
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Search")
            {
                tbSearch.Text = "";
                tbSearch.ForeColor = Color.White;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = "Search";
                tbSearch.ForeColor = Color.DarkGray;
            }
        }


        private void txtBookingID_Enter(object sender, EventArgs e)
        {
            if (tbBookingID.Text == "None")
            {
                tbBookingID.Text = "";
                tbBookingID.ForeColor = Color.CornflowerBlue;
            }
        }

        private void txtBookingID_Leave(object sender, EventArgs e)
        {
            if (tbBookingID.Text == "")
            {
                tbBookingID.Text = "None";
                tbBookingID.ForeColor = Color.CornflowerBlue;
            }
        }
        #endregion
    }
}
