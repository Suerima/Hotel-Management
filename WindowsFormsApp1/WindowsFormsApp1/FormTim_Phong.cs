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

namespace WindowsFormsApp1
{
    public partial class FormTim_Phong : Form
    {
        public FormTim_Phong()
        {
            InitializeComponent();
            dgvListRoom.DataSource = RoomBUS.Instance.GetRoom();
            lbNumber.Text = dgvListRoom.Rows.Count.ToString(); 
        }


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text == "Room ID")
            {
                dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Room_ID", tbSearch.Text);
            }
            else if (cbSearch.Text == "Room Type")
            {
                dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Type", tbSearch.Text);
            }
            else if (cbSearch.Text == "Person")
            {
                dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Person", tbSearch.Text);
            }
            else if (cbSearch.Text == "Price")
            {
                dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Price", tbSearch.Text);
            }
            else if (cbSearch.Text == "Status")
            {
                dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Status", tbSearch.Text);
            }
            else if (cbSearch.Text == "Description")
            {
                dgvListRoom.DataSource = RoomBUS.Instance.SearchRoom("Description", tbSearch.Text);
            }
        }
    }
}
