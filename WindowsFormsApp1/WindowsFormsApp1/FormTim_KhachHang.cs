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
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class FormTim_KhachHang : Form
    {

        public FormTim_KhachHang()
        {
            InitializeComponent();
            dgvListCustomer.DataSource = CustomerBUS.Instance.GetCustomer();
            lbNumber.Text = dgvListCustomer.Rows.Count.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(cbSearch.Text == "Fullname")
            {
                dgvListCustomer.DataSource = CustomerBUS.Instance.SearchCustomer("Name", tbSearch.Text);
            }
            else if (cbSearch.Text == "Phone number")
            {
                dgvListCustomer.DataSource = CustomerBUS.Instance.SearchCustomer("Phone", tbSearch.Text);

            }
            else if (cbSearch.Text == "ID Card")
            {
                dgvListCustomer.DataSource = CustomerBUS.Instance.SearchCustomer("IDCard", tbSearch.Text);

            }
            else if(cbSearch.Text == "Customer ID")
            {
                dgvListCustomer.DataSource = CustomerBUS.Instance.SearchCustomer("Customer_ID", tbSearch.Text);

            }
        }
    }
}
