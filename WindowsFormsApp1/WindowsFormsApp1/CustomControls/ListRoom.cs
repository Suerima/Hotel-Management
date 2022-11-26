using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ListRoom : UserControl
    {
        public ListRoom()
        {
            InitializeComponent();
            if (lbStatus.Text == "Phòng đang thuê")
                panelBot.BackColor = Color.FromArgb(138, 182, 205);
            else if (lbStatus.Text == "Phòng trống")
                panelBot.BackColor = Color.FromArgb(112, 214, 146);
        }

        private string idRoom;
        private string price;
        private string status;
        private Image image;
        private Color color;

        public string IdRoom
        {
            get => idRoom;
            set { idRoom = value; lbRoom.Text = value; }
        }
        public string Price
        {
            get => price;
            set
            {
                price = value; lbPrice.Text = value;
            }
        }
        public string Status
        {
            get => status;
            set
            {
                status = value; lbStatus.Text = value;
            }
        }
        public Image Image
        {
            get => image;
            set
            {
                image = value; pictureBox1.Image = value;
            }
        }

        public Color Color
        {
            get => color;
            set
            {
                color = value;  panelBot.BackColor = value;
            } 
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lbStatus.Text == "Phòng trống")
            {

                FormDetailRoom f = new FormDetailRoom(this.IdRoom, true);
                f.ShowDialog();
            }
            else
            {
                FormDetailRoom f = new FormDetailRoom(this.IdRoom, false);
                f.ShowDialog();
            }                
        }


    }
}
