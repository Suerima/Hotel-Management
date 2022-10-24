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
    public partial class FormCN_TraPhong : Form
    {
        public FormCN_TraPhong()
        {
            InitializeComponent();
            loadListTable();
            lbDeparture.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void loadListTable()
        {
            dgvListBooking.DataSource = BookingBUS.Instance.GetBookingInCheckOut();
            dgvListServiceInvoice.DataSource = ServiceInvoiceBUS.Instance.GetServiceInvoiceInCheckOut();
        }

        private DateTime arrive;
        private int price = 0;

        private string ServiceTotal()
        {
            int sum = 0;
            for (int i = 0; i < dgvListServiceInvoice.Rows.Count; i++)
                sum += int.Parse(dgvListServiceInvoice.Rows[i].Cells["Total"].Value.ToString());
            return sum.ToString();
        }

        private string BookingTotal()
        {

            DateTime departure = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
            int days = (departure.Date - arrive.Date).Days;

            if (days == 0)
                days = 1;

            return (days * price).ToString();
        }

        private void dgvListBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = new DataGridViewRow();
                r = dgvListBooking.Rows[e.RowIndex];

                price = Convert.ToInt32(r.Cells["Pricee"].Value.ToString());

              //  string x = r.Cells["Arrival"].Value.ToString();
                arrive = DateTime.Parse(r.Cells["Arrival"].Value.ToString());
                
                tbCustomerID.Text = r.Cells["Customer_ID"].Value.ToString();
                lbArrival.Text = arrive.ToString("yyyy-MM-dd");
                lbTotalBooking.Text = BookingTotal();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvListServiceInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbTotalService.Text = dgvListServiceInvoice.Rows[e.RowIndex].Cells["Total"].Value.ToString();
        }

        private bool checkCustomer(string customerID)
        {
            for (int i = 0; i < dgvListBooking.Rows.Count; i++)
                if (dgvListBooking.Rows[i].Cells[1].Value != null && dgvListBooking.Rows[i].Cells[1].Value.ToString() == customerID)
                    return true;
            return false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!checkCustomer(tbCustomerID.Text))
            {
                MessageBox.Show("Invalid Customer ID.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(lbTotalCost.Text == "0")
            {
                DateTime departure = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                int days = (departure.Date - arrive.Date).Days;

                if (days == 0)
                    days = 1;

                lbTotalBooking.Text = (days * price).ToString();
                lbTotalCost.Text = (int.Parse(lbTotalBooking.Text) + int.Parse(lbTotalService.Text)).ToString();

                // Insert Into Report
                QuanLyDB bill = new QuanLyDB();

                for (int i = 0; i < dgvListServiceInvoice.Rows.Count; i++)
                {
                    DateTime dateT = DateTime.Parse(dgvListServiceInvoice.Rows[i].Cells["Date_Created"].Value.ToString());
                    int total = int.Parse(dgvListServiceInvoice.Rows[i].Cells["Total"].Value.ToString());

                    bill.InsertListServiceReport(dateT, departure, total);
                }

                bill.InsertListListBookingReport(arrive, departure, int.Parse(lbTotalBooking.Text));

                // Delete Customer
                CustomerBUS.Instance.DeleteCustomer(tbCustomerID.Text);

                loadListTable();
                MessageBox.Show("Bill payment successful.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
/*            else
            {
                MessageBox.Show("This bill has been paid.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/

        }

        private void reset()
        {
            tbCustomerID.Text = "None";
            lbArrival.Text = "None";
            lbTotalBooking.Text = "0";
            lbTotalService.Text = "0";
            lbTotalCost.Text = "0";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
            loadListTable();
        }

        private void tbCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (checkCustomer(tbCustomerID.Text))
            {
                dgvListBooking.DataSource = CustomerBUS.Instance.SearchCustomerInBookingCheckOut(tbCustomerID.Text);

                dgvListServiceInvoice.DataSource = CustomerBUS.Instance.SearchCustomerInServiceInvoiceCheckOut(tbCustomerID.Text);

                lbTotalService.Text = ServiceTotal();
                lbTotalBooking.Text = BookingTotal();
            }
            else
            {
                lbTotalService.Text = "0";
                lbTotalService.Text = "0";
                loadListTable();
            }
        }

        private void tbCustomerID_Enter(object sender, EventArgs e)
        {
            if (tbCustomerID.Text == "None")
                tbCustomerID.Text = "";
        }

        private void tbCustomerID_Leave(object sender, EventArgs e)
        {
            if (tbCustomerID.Text == "")
                tbCustomerID.Text = "None";
        }
    }
}
