using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class FormQL_Phong : Form
    {
        private bool checkButton = false;
        Color yellow = Color.FromArgb(247, 206, 69);

        private string status;
        public FormQL_Phong()
        {
            InitializeComponent();
            tabControl.TabPages.Remove(tabPageEdit);

            loadData();
            if (FormLogin.authority == "Cashier")
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false; 
            }
        }

        void loadData()
        {
            dgvListRoom.DataSource = RoomBUS.Instance.GetRoom();
            lbRecord.Text = "Records: " + dgvListRoom.RowCount.ToString();
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
            tbPrice.Texts = "Price";
            tbDescription.Texts = "Description";
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
                    tbDescription.Texts = r.Cells[5].Value.ToString();
                }
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
            if (tbRoomID.Texts == "")
            {
                MessageBox.Show("Please select the room you want to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tabControl.TabPages.Remove(tabPageList);
                tabControl.TabPages.Add(tabPageEdit);
                tabPageEdit.Text = "UPDATE";
                checkButton = false;
            }
        }
        public void DeleteRoom()
        {
            try
            {
                if (tbRoomID.Texts == "")
                    MessageBox.Show("Please select the room you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var result = MessageBox.Show("Are you sure you want to delete this room?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        RoomBUS.Instance.DeleteRoom(tbRoomID.Texts);
                        loadData();
                        MessageBox.Show("Delete successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (!checkPrice(tbPrice.Texts))
                {
                    MessageBox.Show("Invalid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tbDescription.Texts == "Description")
                {
                    MessageBox.Show("Description cannot be left blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Room room = new Room(tbRoomID.Texts, cbType.Text, int.Parse(cbPerson.Text), int.Parse(tbPrice.Texts), status, tbDescription.Texts);

                    if (checkButton == true)
                    {
                        RoomBUS.Instance.InsertRoom(room);
                        MessageBox.Show("Insert successful!.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        RoomBUS.Instance.UpdateRoom(room);
                        MessageBox.Show("Update successful!.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #region Event
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "Search")
            {
                if (cbSearch.Text == " RoomID")
                {
                    dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("RoomID", tbSearch.Text);
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

        private void tbPrice_Enter(object sender, EventArgs e)
        {
            tbPrice.BorderSize = 2;
            tbPrice.BorderColor = yellow;
            lbPrice.Text = "Price";
            lbPrice.ForeColor = yellow;

            if (tbPrice.Texts == "Price")
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
                tbPrice.Texts = "Price";
                tbPrice.ForeColor = Color.DimGray;
                lbPrice.Text = "";
            }
        }
        private void tbDescription_Enter(object sender, EventArgs e)
        {
            tbDescription.BorderSize = 2;
            tbDescription.BorderColor = yellow;
            lbDescription.Text = "Description";
            lbDescription.ForeColor = yellow;

            if (tbDescription.Texts == "Description")
                tbDescription.Texts = "";
            tbDescription.ForeColor = Color.WhiteSmoke;
        }

        private void tbDescription_Leave(object sender, EventArgs e)
        {
            tbDescription.BorderSize = 1;
            tbDescription.BorderColor = Color.DimGray;
            lbDescription.ForeColor = Color.DarkGray;

            if (tbDescription.Texts == "")
            {
                tbDescription.Texts = "Description";
                tbDescription.ForeColor = Color.DimGray;
                lbDescription.Text = "";
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
