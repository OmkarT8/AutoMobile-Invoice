using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;
using System.Data.OleDb;

namespace AutoManufacture
{
    public partial class AddParts : Form
    {
        AddPartClassMaster apc = new AddPartClassMaster();
        public AddParts()
        {
            InitializeComponent();
        }

        private void GetPart()
        {
            try
            {
                dataGVParts.DataSource = apc.GetParts();
                dataGVParts.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void AddParts_Load(object sender, EventArgs e)
        {
            GetPart();
            dataGVParts.Columns[0].HeaderText = "Part No.";
            dataGVParts.Columns[1].HeaderText = "Part Description";
            dataGVParts.Columns[2].HeaderText = "HSN Code";
            dataGVParts.Columns[3].HeaderText = "CGST";
            dataGVParts.Columns[4].HeaderText = "SGST";
            dataGVParts.Columns[5].HeaderText = "MRP(INR)";
            
            txtInstructions.Text = "If you want to UPDATE or DELETE item you have to double" +
                " click on the item in Table and the click on " +
                "appropriate button";
            ExceldataGV.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPartno.Text) && !string.IsNullOrEmpty(txtPartDesc.Text) && !string.IsNullOrEmpty(txtHsnCode.Text) && !string.IsNullOrEmpty(txtMRP.Text))
            {
                if (apc.AddPart(txtPartno.Text,txtPartDesc.Text,txtHsnCode.Text,txtcgst.Text,txtsgst.Text,txtMRP.Text) == true)
                    MessageBox.Show("Data Inserted!");
                else
                    MessageBox.Show("Error!");
            }
            else
            {
                MessageBox.Show("Enter Values !");
            }
            GetPart();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPartno.Text) && !string.IsNullOrEmpty(txtPartDesc.Text) && !string.IsNullOrEmpty(txtHsnCode.Text) && !string.IsNullOrEmpty(txtMRP.Text))
            {
                if (apc.UpdatePart(txtPartDesc.Text,txtHsnCode.Text,txtcgst.Text,txtsgst.Text, txtMRP.Text, txtPartno.Text) == true)
                    MessageBox.Show("Data Updated !");
                else
                    MessageBox.Show("Error !");
            }
            else
            {
                MessageBox.Show("Please double click on row that you want to update !");
            }
            GetPart();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPartno.Text) && !string.IsNullOrEmpty(txtPartDesc.Text) && !string.IsNullOrEmpty(txtHsnCode.Text) && !string.IsNullOrEmpty(txtMRP.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (apc.RemovePart(txtPartno.Text) == true)
                        MessageBox.Show("Data Deleted !");
                    else
                        MessageBox.Show("Error !");
                }
            }
            else
            {
                MessageBox.Show("Please double click on row that you want to delete !");
            }
            GetPart();
            ClearFields();
        }

        private void dataGVParts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVParts.Rows.Count > 0)
            {
                int index = dataGVParts.SelectedRows[0].Index;
                if (dataGVParts.Rows[index].Cells[1].Value != null)
                {
                    foreach (DataGridViewRow row in dataGVParts.Rows)
                    {
                        txtPartno.Text = dataGVParts.Rows[index].Cells[0].Value.ToString();
                        txtPartDesc.Text = dataGVParts.Rows[index].Cells[1].Value.ToString();
                        txtHsnCode.Text = dataGVParts.Rows[index].Cells[2].Value.ToString();
                        txtcgst.Text= dataGVParts.Rows[index].Cells[3].Value.ToString();
                        txtsgst.Text= dataGVParts.Rows[index].Cells[4].Value.ToString();
                        txtMRP.Text = dataGVParts.Rows[index].Cells[5].Value.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Please choose correct row !");
                }
            }
        }
        public void ClearFields()
        {
            txtHsnCode.Text = "";
            txtPartno.Text = "";
            txtPartDesc.Text = "";
            txtcgst.Text = "";
            txtsgst.Text = "";
            txtMRP.Text = "";
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtMRP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar!='.')&&(e.KeyChar)!=(char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Allows only numbers and decimal point!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboSheetName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheetName.SelectedItem.ToString()];
            if (dt != null)
            {
                List<Parts> partsList = new List<Parts>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Parts pr = new Parts();
                    pr.PartNo = dt.Rows[i]["PartNo"].ToString();
                    pr.PartDes = dt.Rows[i]["PartDes"].ToString();
                    pr.HSNCode = dt.Rows[i]["HSNCode"].ToString();
                    pr.CGST = dt.Rows[i]["CGST"].ToString();
                    pr.SGST = dt.Rows[i]["SGST"].ToString();
                    pr.MRP = dt.Rows[i]["MRP"].ToString();
                    partsList.Add(pr);
                }
                partsBindingSource.DataSource = partsList;
                ExceldataGV.Visible = true;
            }

        }

        DataTableCollection tableCollection;

        private void btn_browse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtFileName.Text = openFileDialog.FileName;
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollection = result.Tables;
                                cboSheetName.Items.Clear();
                                foreach (DataTable table in tableCollection)
                                {
                                    cboSheetName.Items.Add(table.TableName);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {



                string maincon = ConfigurationManager.ConnectionStrings["autoManufacture"].ConnectionString;
                DapperPlusManager.Entity<Parts>().Table("tbl_PartsMaster");
                List<Parts> partList = partsBindingSource.DataSource as List<Parts>;
                if (partList != null)
                {
                    using (IDbConnection db = new SqlConnection(maincon))
                    {
                        db.BulkInsert(partList);
                    }
                }
                MessageBox.Show("Data Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ExceldataGV.Visible = false;
            GetPart();
        }

        private void btndeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete? This will delete all the records from datatabse.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (apc.TruncateAllRecords() == true)
                    {
                        MessageBox.Show("All Data Deleted !");
                    }
                    GetPart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
