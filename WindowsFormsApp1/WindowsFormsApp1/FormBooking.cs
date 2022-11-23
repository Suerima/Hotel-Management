using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        async void LoadRoom()
        {
            List<Room> roomList = RoomDAO.Instance.LoadRoomList();

            foreach (Room item in roomList)
            {
                ListRoom ptb = new ListRoom() { Width = 273, Height = 200 };
                ptb.Tag = item;
                ptb.IdRoom = item.RoomID;
                ptb.Price = item.Price.ToString();
                ptb.Status = item.Status;
                flpRoom.Controls.Add(ptb);
            }

        }
    }
}
