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
        }

        private string idRoom;
        private string price;
        private string status;
        private Image image;

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

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            FormDetailRoom f = new FormDetailRoom(this.IdRoom);
            f.ShowDialog();
        }
    }
}
