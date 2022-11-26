using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using System.Xml.XPath;

namespace WindowsFormsApp1
{

    public partial class FormBooking : Form
    {
        string result;

        public FormBooking()
        {
            InitializeComponent();
            LoadRoom();
            loadListBooking();
        }

        void loadListBooking()
        {
            dgvListBooking.DataSource = BookingBUS.Instance.GetBooking();
        }

        public void LoadRoom()
        {
            List<Room> roomList = RoomDAO.Instance.LoadRoomList();

            foreach (Room item in roomList)
            {
                ListRoom ptb = new ListRoom() { Width = 273, Height = 200 };
                ptb.Tag = item;
                ptb.IdRoom = item.RoomID;
                ptb.Price = item.Price.ToString();
                ptb.Status = item.Status; 

                string path = RoomDAO.Instance.GetFirstPath(ptb.IdRoom);
                ptb.Image = System.Drawing.Image.FromFile(path);
                flpRoom.Controls.Add(ptb);
            }

        }

        void loadRoomConditions(string result, int length, string type, string person)
        {
            List<Room> roomList = RoomDAO.Instance.LoadAmenitiesRoomList(result, length, type, person);

            foreach (Room item in roomList)
            {
                ListRoom ptb = new ListRoom() { Width = 273, Height = 200 };
                ptb.Tag = item;
                ptb.IdRoom = item.RoomID;
                ptb.Price = item.Price.ToString();
                ptb.Status = item.Status; 

                string path = RoomDAO.Instance.GetFirstPath(ptb.IdRoom);
                ptb.Image = System.Drawing.Image.FromFile(path);

                flpRoom.Controls.Add(ptb);
            }
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = clbBed.SelectedIndex;
            int count = clbBed.Items.Count;

            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    clbBed.SetItemCheckState(x, CheckState.Unchecked);
                }
            }

        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = clbTypeRoom.SelectedIndex;
            int count = clbTypeRoom.Items.Count;

            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    clbTypeRoom.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
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
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            flpRoom.Controls.Clear();

            int j = 0;

            string[] amenities = new string[8];

            // Get beds
            for (int i = 0; i < clbBed.Items.Count; i++)
            {
                if (clbBed.GetItemCheckState(i) == CheckState.Checked)
                {
                    amenities[j] = clbBed.Items[i].ToString();
                    j++;
                }
            }

            // Get amenities
            for (int i = 0; i < clbAmenities.Items.Count; i++)
            {
                if (clbAmenities.GetItemCheckState(i) == CheckState.Checked)
                {
                    amenities[j] = clbAmenities.Items[i].ToString();
                    j++;
                }
            }


            amenities = convertDetailID(amenities, j);
            result = "";
            for (int i = 0; i < j; i++)
            {
                result = result + " DetailID = '" + amenities[i] + "' ";
                if (i != j - 1)
                    result = result + "OR";
            }

            string type = "Standard' OR Type = 'Superior' OR Type = 'Deluxe";

            for (int i = 0; i < 3; i++)
            {
                if (clbTypeRoom.GetItemCheckState(i) == CheckState.Checked)
                {
                    type = clbTypeRoom.Items[i].ToString();
                    break;
                }
            }

            /*            // Get type room
                        int k = 0;
                        string[] type = new string[3];

                        for (int i = 0; i < clbTypeRoom.Items.Count; i++)
                        {
                            if (clbTypeRoom.GetItemCheckState(i) == CheckState.Checked)
                            {
                                type[k] = clbTypeRoom.Items[i].ToString();
                                k++;
                            }
                        }

                        result1 = "";
                        for (int i = 0; i < k; i++)
                        {
                            result1 = result1 + " Type = '" + type[i] + "' ";
                            if (i != k - 1)
                                result1 = result1 + "OR";
                        }*/

            string person = cbPerson.Text;
            if (person == "")
                person = "2' OR Person = '4";

            if (result == "")
                LoadRoom();
            else
                loadRoomConditions(result, j, type, cbPerson.Text);
            

        }
        private int checkBookingID(string bookingid)
        {
            for (int i = 0; i < dgvListBooking.Rows.Count; i++)
                if (dgvListBooking.Rows[i].Cells[0].Value != null && dgvListBooking.Rows[i].Cells[0].Value.ToString() == bookingid)
                    return i;
            return -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                        BookingBUS.Instance.UpdateStatusRoom(lbRoomID.Text, "Phòng trống");

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
                    DateTime amenitiesive = DateTime.Parse(x);
                    lbArrival.Text = amenitiesive.ToString("yyyy-MM-dd");
                }
            }
        }
    }
}
