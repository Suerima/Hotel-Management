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
    public partial class FormCN_TraPhong : Form
    {
        public FormCN_TraPhong()
        {
            InitializeComponent();
            loadListBooking();
            loadListServiceInvoice();
        }

        private void loadListBooking()
        {
            QuanLyDB db = new QuanLyDB();
            DataTable dt = db.GetAllListBooking();
            dgvListBooking.DataSource = dt;
        }

        private void loadListServiceInvoice()
        {
            QuanLyDB db = new QuanLyDB();
            DataTable dt = db.GetAllListServiceInvoice();
            dgvListServiceInvoice.DataSource = dt;
        }

        DateTime arrive;
        string roomid;
        int price = 0;

        private string ServiceTotal()
        {
            int sum = 0;
            for (int i = 0; i < dgvListServiceInvoice.Rows.Count; i++)
                sum += int.Parse(dgvListServiceInvoice.Rows[i].Cells[3].Value.ToString());
            return sum.ToString();
        }

        private void dgvListBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = new DataGridViewRow();
                r = dgvListBooking.Rows[e.RowIndex];

                //txtCustomerID.Text = r.Cells[2].Value.ToString();

                roomid = r.Cells[2].Value.ToString();
                price = Convert.ToInt32(r.Cells[3].Value.ToString());

                string x = r.Cells[4].Value.ToString();
                arrive = DateTime.Parse(x);
                lbArrival.Text = arrive.ToString("yyyy-MM-dd");

                if (r.Cells[5].Value.ToString() == "")
                    lbDeparture.Text = "None";
                else
                {
                    string y = r.Cells[5].Value.ToString();
                    DateTime departure = DateTime.Parse(y);
                    lbDeparture.Text = departure.ToString("yyyy-MM-dd");
                }
               
                lbTotalBooking.Text = r.Cells[6].Value.ToString();
              //  lbTotalCost.Text = (int.Parse(lbTotalBooking.Text) + int.Parse(lbTotalService.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvListServiceInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbTotalService.Text = dgvListServiceInvoice.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private int checkCustomer(string cusID)
        {
            for (int i = 0; i < dgvListBooking.Rows.Count; i++)
                if (dgvListBooking.Rows[i].Cells[1].Value != null && dgvListBooking.Rows[i].Cells[1].Value.ToString() == cusID)
                    return i;
            return -1;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (checkCustomer(txtCustomerID.Text) == -1)
            {
                MessageBox.Show("Invalid Customer ID.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(lbTotalBooking.Text == "")
            {
                //DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                DateTime departure = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                int days = (departure.Date - arrive.Date).Days;
                if (days == 0)
                    days = 1;

                lbDeparture.Text = DateTime.Now.ToString("yyyy-MM-dd");
                lbTotalBooking.Text = (days * price).ToString();
                lbTotalCost.Text = (int.Parse(lbTotalBooking.Text) + int.Parse(lbTotalService.Text)).ToString();

                // Update
                QuanLyDB bill = new QuanLyDB();
                bill.UpdateListBooking(departure, txtCustomerID.Text, roomid);


                // Insert Into Report
                for (int i = 0; i < dgvListServiceInvoice.Rows.Count; i++)
                {
                    DateTime dateT = DateTime.Parse(dgvListServiceInvoice.Rows[i].Cells[2].Value.ToString());
                    int total = int.Parse(dgvListServiceInvoice.Rows[i].Cells[3].Value.ToString());

                    bill.InsertListServiceReport(dateT, departure, total);
                }

                bill.InsertListListBookingReport(arrive, departure, int.Parse(lbTotalBooking.Text));

                // Delete Customer
                bill.DeleteCustomer(txtCustomerID.Text);

                loadListBooking();
                loadListServiceInvoice();


                MessageBox.Show("Bill payment successful.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This bill has been paid.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = "None";
            lbArrival.Text = "None";
            lbDeparture.Text = "None";
            lbTotalBooking.Text = "0";
            lbTotalService.Text = "0";
            lbTotalCost.Text = "0";
            loadListBooking();
            loadListServiceInvoice();
        }
        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (checkCustomer(txtCustomerID.Text) != -1)
            {
                QuanLyDB db = new QuanLyDB();
                DataTable dt;

                dt = db.SearchCustomerInBooking(txtCustomerID.Text);
                dgvListBooking.DataSource = dt;

                dt = db.SearchCustomerInSI(txtCustomerID.Text);
                dgvListServiceInvoice.DataSource = dt;

                lbTotalService.Text = ServiceTotal();

            }
            else 
            {
                lbTotalService.Text = "0";
                loadListBooking();
                loadListServiceInvoice();
            }
        }

        private void txtCustomerID_Enter(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "None")
                txtCustomerID.Text = "";
        }

        private void txtCustomerID_Leave(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "")
                txtCustomerID.Text = "None";
        }
    }
}
