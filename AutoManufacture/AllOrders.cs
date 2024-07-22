using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoManufacture
{
    public partial class AllOrders : Form
    {
        OrderClassMaster ocm = new OrderClassMaster();
        public AllOrders()
        {
            InitializeComponent();
        }

        private void GetOrders()
        {
            dataGVAllOrders.DataSource = ocm.GetAllOrders();
            dataGVAllOrders.ClearSelection();
        }

        private void AllOrders_Load(object sender, EventArgs e)
        {
            GetOrders();
            dataGVAllOrders.Columns[0].HeaderText = "Name";
            dataGVAllOrders.Columns[1].HeaderText = "Invoice No.";
            dataGVAllOrders.Columns[2].HeaderText = "Part No.";
            dataGVAllOrders.Columns[3].HeaderText = "Quantity";
            dataGVAllOrders.Columns[4].HeaderText = "Discount %";
            dataGVAllOrders.Columns[5].HeaderText = "Discount";
            dataGVAllOrders.Columns[6].HeaderText = "Total";
            dataGVAllOrders.Columns[7].HeaderText = "Date";
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string cname = txtSearchCustomer.Text;
            dataGVAllOrders.DataSource = ocm.GetOrderDetails(cname);
        }
    }
}
