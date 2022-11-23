using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class FormBooking : Form
    {
        public FormBooking()
        {
            InitializeComponent();
            LoadRoom();
        }

         void LoadRoom()
        {
            List<Room> roomList = RoomDAO.Instance.LoadRoomList();

            foreach (Room item in roomList)
            {
                ListRoom ptb = new ListRoom() { Width = 273, Height = 200 };
                ptb.Tag = item;
                ptb.IdRoom = item.RoomID;
                ptb.Price = item.Price.ToString();
                ptb.Status = item.Status; //Display intially first image in picture box as sero index file path
                string path = RoomDAO.Instance.GetFirstPath(ptb.IdRoom);
                ptb.Image = System.Drawing.Image.FromFile(path);
                flpRoom.Controls.Add(ptb);
            }

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstBed.SelectedIndex;
            int count = lstBed.Items.Count;

            for (int x = 0; x < count; x++)
            {
                if(index != x)
                {
                    lstBed.SetItemCheckState(x, CheckState.Unchecked);
                }    
            }    
        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstTypeRoom.SelectedIndex;
            int count = lstTypeRoom.Items.Count;

            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    lstTypeRoom.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
        }
    }
}
