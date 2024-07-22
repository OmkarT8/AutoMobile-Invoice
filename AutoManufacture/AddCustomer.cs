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
    public partial class AddCustomer : Form
    {
        customerClassMaster ccm = new customerClassMaster();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void GetCustomer()
        {
            try
            {
                dataGVCustomer.DataSource = ccm.getCustomers();
                dataGVCustomer.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            GetCustomer();
            dataGVCustomer.Columns[0].HeaderText = "Customer Name";
            dataGVCustomer.Columns[1].HeaderText = "Customer Address";
            dataGVCustomer.Columns[2].HeaderText = "GST/PAN No.";
            dataGVCustomer.Columns[3].HeaderText = "Date Created";

            txtInstructions.Text = "If you want to UPDATE or DELETE item you have to double" +
                " click on the item in Table and the click on " +
                "appropriate button";
        }

        void clear()
        {
            txtcustname.Clear();
            txtxcustaddress.Clear();
            txtGstPan.Clear();        
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_addcust_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcustname.Text) && !string.IsNullOrEmpty(txtxcustaddress.Text) && !string.IsNullOrEmpty(txtGstPan.Text))
            {
                if (ccm.AddCustomer(txtcustname.Text,txtxcustaddress.Text,txtGstPan.Text) == true)
                    MessageBox.Show("Data Inserted!");
                else
                    MessageBox.Show("Error!");
            }
            else
            {
                MessageBox.Show("Enter Values !");
            }
            GetCustomer();
            clear();
            txtcustname.Focus();
        }

        private void btn_updatecust_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcustname.Text) && !string.IsNullOrEmpty(txtxcustaddress.Text) && !string.IsNullOrEmpty(txtGstPan.Text))
            {
                if (ccm.UpdateCustomer(txtxcustaddress.Text,txtGstPan.Text,txtcustname.Text) == true)
                    MessageBox.Show("Data Updated !");
                else
                    MessageBox.Show("Error !");
            }
            else
            {
                MessageBox.Show("Please double click on row that you want to update !");
            }
            GetCustomer();
            clear();
        }

        private void btn_delcust_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcustname.Text) && !string.IsNullOrEmpty(txtxcustaddress.Text) && !string.IsNullOrEmpty(txtGstPan.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (ccm.RemoveCustomer(txtcustname.Text)== true)
                        MessageBox.Show("Data Deleted !");
                    else
                        MessageBox.Show("Error !");
                }
            }
            else
            {
                MessageBox.Show("Please double click on row that you want to delete !");
            }
            GetCustomer();
            clear();
        }

        private void dataGVCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVCustomer.Rows.Count > 0)
            {
                int index = dataGVCustomer.SelectedRows[0].Index;
                if (dataGVCustomer.Rows[index].Cells[1].Value != null)
                {
                    foreach (DataGridViewRow row in dataGVCustomer.Rows)
                    {
                        txtcustname.Text = dataGVCustomer.Rows[index].Cells[0].Value.ToString();
                        txtxcustaddress.Text = dataGVCustomer.Rows[index].Cells[1].Value.ToString();
                        txtGstPan.Text = dataGVCustomer.Rows[index].Cells[2].Value.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Please choose correct row !");
                }
            }
        }
    }
}
