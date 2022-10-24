using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class FormQL_Phong : Form
    {

        public FormQL_Phong()
        {
            InitializeComponent();
            tabControl.TabPages.Remove(tabPageEdit);
            loadData();
        }

        void loadData()
        {
            dgvListRoom.DataSource = RoomBUS.Instance.GetRoom();
            lbRecord.Text = "Records: " + dgvListRoom.RowCount.ToString();
        }

        private void dgvListInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvListRoom.Rows[e.RowIndex];
            if (r != null)
            {
                tbRoomID.Text = r.Cells[0].Value.ToString();
                cbType.Text = r.Cells[1].Value.ToString();
                tbPerson.Text = r.Cells[2].Value.ToString();
                tbPrice.Text = r.Cells[3].Value.ToString();
                cbStatus.Text = r.Cells[4].Value.ToString();
                tbDescription.Text = r.Cells[5].Value.ToString();
            }
        }

        public string GetNextRoomID()
        {
            string lastID = RoomBUS.Instance.GetLastRoomID();

            if (lastID == null)
                return "Room001";

            int nextID = int.Parse(lastID.Remove(0, 4)) + 1; // Ex: BK012 ->  13

            string zeroNumber = "";

            for (int i = 1; i <= 3; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= 3 - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return "Room" + zeroNumber + nextID.ToString();
                }
            }
            return "Room" + nextID;
        }

        private void reset()
        {
            tbRoomID.Text = GetNextRoomID();
            cbType.Text = "";
            tbPerson.Text = "";
            tbPrice.Text = "";
            cbStatus.Text = "";
            tbDescription.Text = "";
        }
    
        private bool checkButton;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabPageList);
            tabControl.TabPages.Add(tabPageEdit);
            tabPageEdit.Text = "ADD";
            reset();
            checkButton = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbRoomID.Text == "")
            {
                MessageBox.Show("Please select the room you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tabControl.TabPages.Remove(tabPageList);
                tabControl.TabPages.Add(tabPageEdit);
                tabPageEdit.Text = "UPDATE";
                checkButton = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRoom();
        }
        public void DeleteRoom()
        {
            try
            {
                if (tbRoomID.Text == "")
                    MessageBox.Show("Please select the room you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var result = MessageBox.Show("Are you sure you want to delete this room?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        RoomBUS.Instance.DeleteRoom(tbRoomID.Text);
                        loadData();
                        MessageBox.Show("Delete successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbRoomID.Text = "";
                    }
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
                if (cbType.Text == "" || tbPerson.Text == "" || tbPrice.Text == "" || cbStatus.Text == "" || tbDescription.Text == "")
                {
                    MessageBox.Show("Enter missing room information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    Room room = new Room(tbRoomID.Text, cbType.Text, int.Parse(tbPerson.Text), int.Parse(tbPrice.Text), cbStatus.Text, tbDescription.Text);

                    if (checkButton)
                    {
                        RoomBUS.Instance.InsertRoom(room);
                        loadData();
                        MessageBox.Show("Insert successful!.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        RoomBUS.Instance.UpdateRoom(room);
                        loadData();
                        MessageBox.Show("Update successful!.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    tabControl.TabPages.Add(tabPageList);
                    tabControl.TabPages.Remove(tabPageEdit);
                    tbRoomID.Text = "";
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
            tbRoomID.Text = "";
        }

        #region Event
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "Search")
            {
                if (cbSearch.Text == " Room ID")
                {
                    dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Room_ID", tbSearch.Text);
                }
                else if (cbSearch.Text == " Type")
                {
                    dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Type", tbSearch.Text);
                }
                else if (cbSearch.Text == " Person")
                {
                    dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Person", tbSearch.Text);
                }
                else if (cbSearch.Text == " Price")
                {
                    dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Price", tbSearch.Text);
                }
                else if (cbSearch.Text == " Status")
                {
                    dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Status", tbSearch.Text);
                }
                else if (cbSearch.Text == " Description")
                {
                    dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Description", tbSearch.Text);
                }
            }
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Search")
                tbSearch.Text = "";
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
                tbSearch.Text = "Search";
        }
        #endregion
    }
}
