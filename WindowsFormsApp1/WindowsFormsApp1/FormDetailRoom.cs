using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class FormDetailRoom : Form
    {
        private int i = 0;
        private string roomID; 
        ArrayList alist = new ArrayList();

        public FormDetailRoom()
        {
            InitializeComponent();
        }

        public FormDetailRoom(string RoomID):this()
        {
            roomID = RoomID;
            alist = RoomDAO.Instance.LoadListImages(roomID); pictureBox1.Image.Dispose();
            pictureBox1.Image = Image.FromFile(alist[0].ToString());  //Display intially first image in picture box as sero index file path

            label1.Text = alist[1].ToString();
        }
        bool IsValidImg(string filename)
        {
            try
            {
                using (Image newImg = Image.FromFile(filename))
                { }
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Lỗi");
                return false;
            }
            return true;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (IsValidImg(alist[i + 1].ToString()) && (i + 1 < alist.Count))
            {

                pictureBox1.Image = Image.FromFile(alist[i + 1].ToString());
                i = i + 1;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (i - 1 >= 0 && IsValidImg(alist[i].ToString()))

            {

                pictureBox1.Image = Image.FromFile(alist[i - 1].ToString());

                i = i - 1;

            }
        }
    }
}
