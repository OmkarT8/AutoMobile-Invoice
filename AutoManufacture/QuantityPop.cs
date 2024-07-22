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
    public partial class QuantityPop : Form
    {
        Form1 f1;
        public QuantityPop(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
        }

        private void QuantityPop_Load(object sender, EventArgs e)
        {
            txtUpdQty.Text = "1";
        }

        private void txtUpdQty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int quantity = int.Parse(txtUpdQty.Text.ToString());

                    foreach (DataGridViewRow row in f1.orderGridView.SelectedRows)
                    {
                        int index = f1.orderGridView.SelectedRows[0].Index;

                        float mrp = float.Parse(f1.orderGridView.Rows[index].Cells[2].Value.ToString());
                        float netmrp = quantity * mrp;
                        float disc = float.Parse(f1.orderGridView.Rows[index].Cells[5].Value.ToString());
                        float calcDisc = netmrp * disc / 100;
                        float taxAmt = netmrp - calcDisc;
                        int cgst= int.Parse(f1.orderGridView.Rows[index].Cells[8].Value.ToString());
                        int sgst= int.Parse(f1.orderGridView.Rows[index].Cells[10].Value.ToString());
                        float CGST = taxAmt * cgst / 100;
                        float SGST = taxAmt * sgst / 100;
                        float total = taxAmt + CGST + SGST;
                        if (f1.orderGridView.Rows[index].Cells[3].Value != null)
                        {
                            f1.orderGridView.Rows[index].Cells[3].Value = quantity;
                            f1.orderGridView.Rows[index].Cells[4].Value = netmrp;
                            f1.orderGridView.Rows[index].Cells[5].Value = disc;
                            f1.orderGridView.Rows[index].Cells[6].Value = calcDisc;
                            f1.orderGridView.Rows[index].Cells[7].Value = taxAmt;
                            f1.orderGridView.Rows[index].Cells[8].Value = cgst;
                            f1.orderGridView.Rows[index].Cells[9].Value = CGST;
                            f1.orderGridView.Rows[index].Cells[10].Value = sgst;
                            f1.orderGridView.Rows[index].Cells[11].Value = SGST;
                            f1.orderGridView.Rows[index].Cells[12].Value = total;
                            finalCalc();
                        }
                        else
                        {
                            MessageBox.Show("Error!!!");
                        }
                    }
                    this.Close();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void finalCalc()
        {
            try
            {
                int Tqty = 0;
                float Tmrp = 0;
                float Tnetmrp = 0;
                float tax = 0;
                float cgst = 0;
                float sgst = 0;
                float total = 0;
                if (f1.orderGridView.Rows.Count > 0)
                {
                    for (int i = 0; i < f1.orderGridView.Rows.Count; i++)
                    {
                        Tqty = Tqty + int.Parse(f1.orderGridView.Rows[i].Cells[3].Value.ToString());
                        f1.labelqty.Text = Tqty.ToString();

                        Tmrp = Tmrp + float.Parse(f1.orderGridView.Rows[i].Cells[2].Value.ToString());
                        f1.labelmrp.Text = Tmrp.ToString();

                        Tnetmrp = Tnetmrp + float.Parse(f1.orderGridView.Rows[i].Cells[4].Value.ToString());
                        f1.labelnetprice.Text = Tnetmrp.ToString();

                        tax = tax + float.Parse(f1.orderGridView.Rows[i].Cells[7].Value.ToString());
                        f1.labeltaxAmount.Text = tax.ToString();

                        cgst = cgst + float.Parse(f1.orderGridView.Rows[i].Cells[9].Value.ToString());
                        f1.labelCGST.Text = cgst.ToString();

                        sgst = sgst + float.Parse(f1.orderGridView.Rows[i].Cells[11].Value.ToString());
                        f1.labelSGST.Text = sgst.ToString();

                        total = total + float.Parse(f1.orderGridView.Rows[i].Cells[12].Value.ToString());
                        f1.labelTotalAmt.Text = total.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void txtUpdQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar) != (char)Keys.Back && (e.KeyChar) != (char)Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show("Allows only numbers and decimal point!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}