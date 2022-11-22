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

        void load()
        {
            ListRoom[] listItems = new ListRoom[20];
 
            for (int i = 0; i < 20 ; i++)
            {

            }    
        }
        private void ptb_Click(object sender, EventArgs e)
        {
            string roomID = ((sender as ListRoom).Tag as Room).RoomID;
            FormDetailRoom f = new FormDetailRoom();
            f.Show();
        }

        async void LoadRoom()
        {
            List<Room> roomList = RoomDAO.Instance.LoadRoomList();

            foreach (Room item in roomList)
            {
                ListRoom ptb = new ListRoom() { Width = 275, Height = 200 };
                ptb.Tag = item;
                ptb.IdRoom = item.RoomID;
                ptb.Price = item.Price.ToString();
                ptb.Status = item.Status;
                /*  switch (item.Status)
                  {
                      case "Trống":
                          btn.BackColor = Color.Aqua;
                          break;
                      default:
                          btn.BackColor = Color.Blue;
                          break;
                  }*/

                flpRoom.Controls.Add(ptb);
            }

        }
    }
}
