using Microsoft.Reporting.WinForms;
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
    public partial class ReportPreview : Form
    {
        
        Form1 f1;
        public ReportPreview(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
        }

        private void ReportPreview_Load(object sender, EventArgs e)
        {
            this.orderReportViewer.RefreshReport();
        }

        private void btn_generateBill_Click(object sender, EventArgs e)
        {
            try
            {
                List<OrderDetailsClass> orderList = new List<OrderDetailsClass>();
                orderList.Clear();
                for (int i = 0; i < f1.orderGridView.Rows.Count; i++)
                {
                    orderList.Add(new OrderDetailsClass
                    {
                        partno = f1.orderGridView.Rows[i].Cells[0].Value.ToString(),
                        hsncode = f1.orderGridView.Rows[i].Cells[1].Value.ToString(),
                        mrp = float.Parse(f1.orderGridView.Rows[i].Cells[2].Value.ToString()),
                        qnty = float.Parse(f1.orderGridView.Rows[i].Cells[3].Value.ToString()),
                        netmrp = float.Parse(f1.orderGridView.Rows[i].Cells[4].Value.ToString()),
                        discPercnt=float.Parse(f1.orderGridView.Rows[i].Cells[5].Value.ToString()),
                        discount = float.Parse(f1.orderGridView.Rows[i].Cells[6].Value.ToString()),
                        taxAmt = float.Parse(f1.orderGridView.Rows[i].Cells[7].Value.ToString()),
                        cgstPercnt=float.Parse(f1.orderGridView.Rows[i].Cells[8].Value.ToString()),
                        cgst = float.Parse(f1.orderGridView.Rows[i].Cells[9].Value.ToString()),
                        sgstPercnt=float.Parse(f1.orderGridView.Rows[i].Cells[10].Value.ToString()),
                        sgst = float.Parse(f1.orderGridView.Rows[i].Cells[11].Value.ToString()),
                        total = float.Parse(f1.orderGridView.Rows[i].Cells[12].Value.ToString())
                    });
                }
                this.orderReportViewer.LocalReport.ReportPath = "orderBill.rdlc";
                string date;
                ReportParameterCollection param = new ReportParameterCollection();
                param.Add(new ReportParameter("custName", f1.comboBoxCustomerN.Text));
                param.Add(new ReportParameter("invoiceNo", f1.txtinvoice.Text));
                param.Add(new ReportParameter("billtoAddress", f1.txtcustAddress.Text));
                param.Add(new ReportParameter("pod", f1.txtcustAddress.Text));
                param.Add(new ReportParameter("gstpanno", f1.txtGstPanNo.Text));
                if (string.IsNullOrEmpty(f1.txtinvDate.Text))
                {
                    param.Add(new ReportParameter("invDate", DateTime.Now.ToString("dd/MM/yyyy")));
                }
                else
                {
                    param.Add(new ReportParameter("invDate",f1.txtinvDate.Text));
                }
                orderReportViewer.LocalReport.SetParameters(param);
                ReportDataSource rds = new ReportDataSource("ODataSet", orderList);
                this.orderReportViewer.LocalReport.DataSources.Add(rds);
                this.orderReportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}
