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
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class FormDetailRoom : Form
    {
        private int i = 0;
        private string roomID; 
        ArrayList alist = new ArrayList();
        string[] details = new string[8];

        public FormDetailRoom()
        {
            InitializeComponent();
        }
        

        public FormDetailRoom(string RoomID, bool bookCheck):this()
        {

            if (!bookCheck)
            {
                btnBooking.Visible = false;
                btnDetail.Visible = true;
            }
            else
            {
                btnBooking.Visible = true;
                btnDetail.Visible = false;
            }    
            
            roomID = RoomID;
            alist = RoomDAO.Instance.LoadListImages(roomID); 
            pictureBox1.Image.Dispose();
           
            pictureBox1.Image = System.Drawing.Image.FromFile(alist[0].ToString());  //Display intially first image in picture box as sero index file path
            
            DetailDAO.Instance.GetDetailsRoom(roomID).CopyTo(details, 0);
            
            lbType.Text = RoomDAO.Instance.GetTypeRoom(roomID);
           
            lbPerson.Text = RoomDAO.Instance.GetPersonRoom(roomID);
           
            lbBed.Text = details[0];
           
            for(int i = 1; i < details.Count(); i++)
                lbDetails.Text += details[i] + System.Environment.NewLine;

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try 
            {
                if (i + 1 < alist.Count)
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(alist[i + 1].ToString());
                    i = i + 1;
                }

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
                    pictureBox1.Image = System.Drawing.Image.FromFile(alist[i - 1].ToString());
                    i = i - 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string GetNextBookingID()
        {

            string lastID = BookingBUS.Instance.GetLastBookingID();

            if (lastID == null)
                return "BK001";

            int nextID = int.Parse(lastID.Remove(0, 2)) + 1; // Ex: BK012 ->  13
            string zeroNumber = "";
            for (int i = 1; i <= 3; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= 3 - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return "BK" + zeroNumber + nextID.ToString();
                }
            }
            return "BK" + nextID;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            try
            {

                    string bookingid = GetNextBookingID();
                    DateTime arrival = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));

                    Booking booking = new Booking(bookingid, FormLogin.username, textBox1.Text, roomID, arrival);

                    BookingBUS.Instance.InsertBooking(booking);
                    BookingBUS.Instance.UpdateStatusRoom(roomID, "Phòng đang thuê");
                    MessageBox.Show("Đặt phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
