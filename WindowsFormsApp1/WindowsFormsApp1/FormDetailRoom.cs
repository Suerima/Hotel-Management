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

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try 
            {
                if (i + 1 < alist.Count)
                {
                    pictureBox1.Image = Image.FromFile(alist[i + 1].ToString());
                    i = i + 1;
                }
                else
                    btnLeft_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                if (i - 1 >= 0)
                {
                    pictureBox1.Image = Image.FromFile(alist[i - 1].ToString());
                    i = i - 1;
                    //label1.Text = i.ToString();
                }
                else 
                    btnRight_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {

        }
    }
}
