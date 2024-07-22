using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoManufacture
{
    public partial class Form1 : Form
    {
        AddPartClassMaster apc = new AddPartClassMaster();
        OrderClassMaster corder = new OrderClassMaster();
        public Form1()
        {
            InitializeComponent();
        }

        private void PartList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string partno = PartList.Text;
                comboBoxHSNCode.DataSource = corder.GetPartList(partno);
                comboBoxHSNCode.DisplayMember = "hsncode";

                try
                {
                    string maincon = ConfigurationManager.ConnectionStrings["autoManufacture"].ConnectionString;
                    SqlConnection con = new SqlConnection(maincon);
                    con.Open();
                    string query;
                    query = "select partdes,cgst,sgst,mrp from tbl_PartsMaster where partno='" + PartList.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        txtPartDescr.Text = (string)sdr["partdes"].ToString();                        
                        txtCgst.Text= (string)sdr["cgst"].ToString();
                        txtsgst.Text= (string)sdr["sgst"].ToString();
                        txtmrp.Text = (string)sdr["mrp"].ToString();
                    }
                    con.Close();

                    txtQuantity.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillpartno()
        {
            try
            {
                string maincon = ConfigurationManager.ConnectionStrings["autoManufacture"].ConnectionString;
                SqlConnection con = new SqlConnection(maincon);
                con.Open();
                string query;
                query = "select partno from tbl_PartsMaster where partno like '" + PartList.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    PartList.Items.Add(row["partno"]).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillcust()
        {
            try
            {
                string maincon = ConfigurationManager.ConnectionStrings["autoManufacture"].ConnectionString;
                SqlConnection con = new SqlConnection(maincon);
                con.Open();
                string query;
                query = "Select * from tbl_customerMaster";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach(DataRow row in dt.Rows)
                {
                    comboBoxCustomerN.Items.Add(row["custname"]).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PartList.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCustomerN.AutoCompleteMode = AutoCompleteMode.Suggest;
            orderGridView.ColumnCount = 13;
            orderGridView.Columns[0].Name = "Part No.";
            orderGridView.Columns[1].Name = "HSN Code";
            orderGridView.Columns[2].Name = "MRP";
            orderGridView.Columns[3].Name = "Quantity";
            orderGridView.Columns[4].Name = "Net MRP";
            orderGridView.Columns[5].Name = "Discount(%)";
            orderGridView.Columns[6].Name = "Trade Discount";
            orderGridView.Columns[7].Name = "Taxable Amount";
            orderGridView.Columns[8].Name = " CGST%";
            orderGridView.Columns[9].Name = "CGST";
            orderGridView.Columns[10].Name = "SGST%";
            orderGridView.Columns[11].Name = "SGST";
            orderGridView.Columns[12].Name = "Total Amount";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(comboBoxHSNCode.Text)&&!string.IsNullOrEmpty(txtTotalAmt.Text))
                {
                    orderGridView.Rows.Add(PartList.Text+" "+txtPartDescr.Text, comboBoxHSNCode.Text, txtmrp.Text, txtQuantity.Text, txtnetprice.Text, txtTDisc.Text, CalcDisc, txtTaxAmt.Text, txtCgst.Text, CGST, txtsgst.Text, SGST, txtTotalAmt.Text);
                    orderGridView.ClearSelection();
                    finalCalc();
                }
                else
                {
                    MessageBox.Show("Please enter all values","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                PartList.Text = "";
                txtPartDescr.Clear();
                PartList.Items.Clear();
                txtQuantity.Text = "1";
                comboBoxHSNCode.Text = "";
                txtmrp.Clear();
                txtnetprice.Clear();
                txtTDisc.Clear();
                txtTaxAmt.Clear();
                txtCgst.Clear();
                txtsgst.Clear();
                txtTotalAmt.Clear();
                PartList.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        public void finalCalc()
        {
            int Tqty=0;
            float Tmrp = 0;
            float Tnetmrp = 0;
            float tax = 0;
            float cgst = 0;
            float sgst = 0;
            float total = 0;
            float Tdisc = 0;
            if (orderGridView.Rows.Count > 0)
            {
                for (int i = 0; i < orderGridView.Rows.Count; i++)
                {
                    Tqty = Tqty + int.Parse(orderGridView.Rows[i].Cells[3].Value.ToString());
                    labelqty.Text = Tqty.ToString();

                    Tmrp = Tmrp + float.Parse(orderGridView.Rows[i].Cells[2].Value.ToString());
                    labelmrp.Text = Tmrp.ToString();

                    Tnetmrp = Tnetmrp + float.Parse(orderGridView.Rows[i].Cells[4].Value.ToString());
                    labelnetprice.Text = Tnetmrp.ToString();

                    Tdisc=Tdisc+ float.Parse(orderGridView.Rows[i].Cells[6].Value.ToString());
                    labelTDisc.Text = Tdisc.ToString();

                    tax = tax + float.Parse(orderGridView.Rows[i].Cells[7].Value.ToString());
                    labeltaxAmount.Text = tax.ToString();

                    cgst = cgst + float.Parse(orderGridView.Rows[i].Cells[9].Value.ToString());
                    labelCGST.Text = cgst.ToString();

                    sgst = sgst + float.Parse(orderGridView.Rows[i].Cells[11].Value.ToString());
                    labelSGST.Text = sgst.ToString();

                    total = total + float.Parse(orderGridView.Rows[i].Cells[12].Value.ToString());
                    labelTotalAmt.Text = total.ToString();
                }
            }
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in orderGridView.SelectedRows)
                {
                    int index = orderGridView.SelectedRows[0].Index;
                    if (orderGridView.Rows[index].Cells[0].Value != null)
                    {
                        orderGridView.Rows.RemoveAt(row.Index);
                    }

                }
                finalCalc();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in orderGridView.SelectedRows)
                {
                    int index = orderGridView.SelectedRows[0].Index;
                    if (orderGridView.Rows[index].Cells[0].Value != null)
                    {
                        QuantityPop qp = new QuantityPop(this);
                        qp.Show();
                    }
                }      
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int qty = int.Parse(txtQuantity.Text);
                    float mrp = float.Parse(txtmrp.Text);
                    float netmrp = qty * mrp;
                    txtnetprice.Text = netmrp.ToString();
                    txtTDisc.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public float CalcDisc;
        private void txtTDisc_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int qty = int.Parse(txtQuantity.Text);
                    float mrp = float.Parse(txtmrp.Text);
                    int disc = int.Parse(txtTDisc.Text);
                    //int cgst = int.Parse(txtCgst.Text);
                    //int sgst = int.Parse(txtsgst.Text);   
                    float Netmrp = qty * mrp;
                    CalcDisc = Netmrp * disc / 100;
                    float taxAmt = Netmrp - CalcDisc;
                    txtTaxAmt.Text = taxAmt.ToString();
                    //float CGST = taxAmt * cgst / 100;
                    //float SGST= taxAmt * sgst / 100;
                    //float total = taxAmt + CGST + SGST;
                    //txtTotalAmt.Text = total.ToString();
                    e.Handled = true;
                    e.SuppressKeyPress = true;

                    txtsgst.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderGridView.Rows.Count > 0)
                {
                    for (int i = 0; i < orderGridView.Rows.Count; i++)
                    {
                        string name = comboBoxCustomerN.Text;
                        string invoice = txtinvoice.Text;
                        string partno = orderGridView.Rows[i].Cells[0].Value.ToString();                      
                        string quantity = orderGridView.Rows[i].Cells[3].Value.ToString();
                        string discp = orderGridView.Rows[i].Cells[5].Value.ToString();
                        string disc = orderGridView.Rows[i].Cells[6].Value.ToString();                                         
                        string total = orderGridView.Rows[i].Cells[12].Value.ToString();
                        if (string.IsNullOrEmpty(txtinvDate.Text))
                        {
                            string date = DateTime.Now.ToString("dd/MM/yyyy");
                            if (corder.placeOrder(name, invoice, partno, quantity, discp, disc, total, date) == true)
                            {}
                            else
                            {
                                MessageBox.Show("Error while inserting Order data into database(NodateEnter) !");
                            }
                        }
                        else
                        {
                            string date = txtinvDate.Text;
                            if (corder.placeOrder(name, invoice, partno, quantity, discp, disc, total, date) == true)
                            {}
                            else
                            {
                                MessageBox.Show("Error while inserting Order data into database(DateEnter) !");
                            }
                        }

                    }
                    ReportPreview rp = new ReportPreview(this);
                    rp.Show();
                }
                
                labelmrp.Text = "";
                labelqty.Text = "";
                labelnetprice.Text = "";
                labelTDisc.Text = "";
                labeltaxAmount.Text = "";
                labelCGST.Text = "";
                labelSGST.Text = "";
                labelTotalAmt.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_AddPart_Click(object sender, EventArgs e)
        {
            AddParts ap = new AddParts();
            ap.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_SeeOrders_Click(object sender, EventArgs e)
        {
            AllOrders ao = new AllOrders();
            ao.Show();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar) != (char)Keys.Back && (e.KeyChar)!=(char)Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show("Allows only numbers and decimal point!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTDisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar) != (char)Keys.Back && (e.KeyChar) != (char)Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show("Allows only numbers and decimal point!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in orderGridView.SelectedRows)
                {
                    int index = orderGridView.SelectedRows[0].Index;
                    if (orderGridView.Rows[index].Cells[0].Value != null)
                    {
                        DiscountUpdatePop dup = new DiscountUpdatePop(this);
                        dup.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxCustomerN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string maincon = ConfigurationManager.ConnectionStrings["autoManufacture"].ConnectionString;
                SqlConnection con = new SqlConnection(maincon);
                con.Open();
                string query;
                query = "select address,gstpan from tbl_customerMaster where custname='" + comboBoxCustomerN.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtcustAddress.Text = (string)sdr["address"].ToString();
                    txtGstPanNo.Text = (string)sdr["gstpan"].ToString();
                }
                con.Close();

                PartList.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer();
            ac.Show();
        }

        private void comboBoxCustomerN_Enter(object sender, EventArgs e)
        {
            comboBoxCustomerN.Items.Clear();
            fillcust();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
            labelmrp.Text = "";
            labelqty.Text = "";
            labelnetprice.Text = "";
            labelTDisc.Text = "";
            labeltaxAmount.Text = "";
            labelCGST.Text = "";
            labelSGST.Text = "";
            labelTotalAmt.Text = "";
        }

        void clear()
        {
            comboBoxCustomerN.Text = "";
            comboBoxHSNCode.Text = "";
            PartList.Text = "";
            txtinvDate.Clear();
            txtPartDescr.Clear();
            txtinvoice.Clear();
            txtcustAddress.Clear();
            txtGstPanNo.Clear();
            PartList.Items.Clear();
            txtmrp.Clear();
            txtnetprice.Clear();
            txtTDisc.Clear();
            txtTaxAmt.Clear();
            txtCgst.Clear();
            txtsgst.Clear();
            txtTotalAmt.Clear();
            orderGridView.Rows.Clear();
            orderGridView.Refresh();
        }

        public float CGST;
        public float SGST;
        private void txtsgst_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if(!string.IsNullOrEmpty(txtCgst.Text)&& !string.IsNullOrEmpty(txtsgst.Text))
                    {
                        int cgst = int.Parse(txtCgst.Text);
                        int sgst = int.Parse(txtsgst.Text);
                        float taxAmt = float.Parse(txtTaxAmt.Text);
                        CGST = taxAmt * cgst / 100;
                        SGST = taxAmt * sgst / 100;
                        float total = taxAmt + CGST + SGST;
                        txtTotalAmt.Text = total.ToString();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        txtTotalAmt.Focus();
                    }           
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PartList_Enter(object sender, EventArgs e)
        {
            PartList.Items.Clear();
            //fillpartno();
        }

        private void btn_clearFields_Click(object sender, EventArgs e)
        {
            comboBoxHSNCode.Text = "";
            PartList.Text = "";
            txtPartDescr.Clear();
            PartList.Items.Clear();
            txtmrp.Clear();
            txtnetprice.Clear();
            txtTDisc.Clear();
            txtTaxAmt.Clear();
            txtCgst.Clear();
            txtsgst.Clear();
            txtTotalAmt.Clear();
        }

        private void PartList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    fillpartno();
                    //string pname = PartList.Text;
                    //PartList.DataSource = apc.GetPartNo(pname);
                    //PartList.DisplayMember = "partno";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTotalAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
