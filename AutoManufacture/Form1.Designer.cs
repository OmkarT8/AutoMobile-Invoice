
namespace AutoManufacture
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtmrp = new System.Windows.Forms.TextBox();
            this.txtnetprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PartList = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txtTDisc = new System.Windows.Forms.TextBox();
            this.txtTaxAmt = new System.Windows.Forms.TextBox();
            this.txtCgst = new System.Windows.Forms.TextBox();
            this.txtsgst = new System.Windows.Forms.TextBox();
            this.txtTotalAmt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelqty = new System.Windows.Forms.Label();
            this.labelmrp = new System.Windows.Forms.Label();
            this.labeltaxAmount = new System.Windows.Forms.Label();
            this.labelnetprice = new System.Windows.Forms.Label();
            this.labelCGST = new System.Windows.Forms.Label();
            this.labelSGST = new System.Windows.Forms.Label();
            this.labelTotalAmt = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.btn_AddPart = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.labelTDisc = new System.Windows.Forms.Label();
            this.txtcustAddress = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_SeeOrders = new System.Windows.Forms.Button();
            this.btnUpdateDiscount = new System.Windows.Forms.Button();
            this.pictureBoxOrdIcon = new System.Windows.Forms.PictureBox();
            this.comboBoxCustomerN = new System.Windows.Forms.ComboBox();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.comboBoxHSNCode = new System.Windows.Forms.ComboBox();
            this.btn_clearFields = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txtGstPanNo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtPartDescr = new System.Windows.Forms.TextBox();
            this.txtinvoice = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtinvDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrdIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmrp
            // 
            this.txtmrp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmrp.Location = new System.Drawing.Point(33, 218);
            this.txtmrp.Name = "txtmrp";
            this.txtmrp.Size = new System.Drawing.Size(86, 23);
            this.txtmrp.TabIndex = 7;
            // 
            // txtnetprice
            // 
            this.txtnetprice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetprice.Location = new System.Drawing.Point(257, 219);
            this.txtnetprice.Name = "txtnetprice";
            this.txtnetprice.Size = new System.Drawing.Size(100, 23);
            this.txtnetprice.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1123, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "HSN Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(711, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Part No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "MRP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Net Price";
            // 
            // PartList
            // 
            this.PartList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PartList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PartList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartList.FormattingEnabled = true;
            this.PartList.Location = new System.Drawing.Point(711, 141);
            this.PartList.Name = "PartList";
            this.PartList.Size = new System.Drawing.Size(139, 23);
            this.PartList.TabIndex = 4;
            this.PartList.SelectedIndexChanged += new System.EventHandler(this.PartList_SelectedIndexChanged);
            this.PartList.Enter += new System.EventHandler(this.PartList_Enter);
            this.PartList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartList_KeyDown);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(1133, 256);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(127, 38);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add Item";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "Place Order :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(137, 218);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 23);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.Text = "1";
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantity";
            // 
            // orderGridView
            // 
            this.orderGridView.AllowUserToAddRows = false;
            this.orderGridView.AllowUserToDeleteRows = false;
            this.orderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGridView.BackgroundColor = System.Drawing.Color.White;
            this.orderGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orderGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.orderGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.orderGridView.EnableHeadersVisualStyles = false;
            this.orderGridView.GridColor = System.Drawing.Color.Silver;
            this.orderGridView.Location = new System.Drawing.Point(32, 256);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.ReadOnly = true;
            this.orderGridView.RowHeadersVisible = false;
            this.orderGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.orderGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.orderGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.orderGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.orderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderGridView.Size = new System.Drawing.Size(1085, 325);
            this.orderGridView.TabIndex = 20;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.Black;
            this.btn_remove.Location = new System.Drawing.Point(1133, 320);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(127, 38);
            this.btn_remove.TabIndex = 16;
            this.btn_remove.Text = "Remove Item";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(1133, 384);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(127, 38);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Update Quantity";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txtTDisc
            // 
            this.txtTDisc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDisc.Location = new System.Drawing.Point(377, 219);
            this.txtTDisc.Name = "txtTDisc";
            this.txtTDisc.Size = new System.Drawing.Size(100, 23);
            this.txtTDisc.TabIndex = 10;
            this.txtTDisc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTDisc_KeyDown);
            this.txtTDisc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTDisc_KeyPress);
            // 
            // txtTaxAmt
            // 
            this.txtTaxAmt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxAmt.Location = new System.Drawing.Point(521, 219);
            this.txtTaxAmt.Name = "txtTaxAmt";
            this.txtTaxAmt.Size = new System.Drawing.Size(100, 23);
            this.txtTaxAmt.TabIndex = 11;
            // 
            // txtCgst
            // 
            this.txtCgst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCgst.Location = new System.Drawing.Point(645, 220);
            this.txtCgst.Name = "txtCgst";
            this.txtCgst.Size = new System.Drawing.Size(57, 23);
            this.txtCgst.TabIndex = 12;
            // 
            // txtsgst
            // 
            this.txtsgst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsgst.Location = new System.Drawing.Point(726, 219);
            this.txtsgst.Name = "txtsgst";
            this.txtsgst.Size = new System.Drawing.Size(55, 23);
            this.txtsgst.TabIndex = 13;
            this.txtsgst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsgst_KeyDown);
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmt.Location = new System.Drawing.Point(804, 219);
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.Size = new System.Drawing.Size(100, 23);
            this.txtTotalAmt.TabIndex = 14;
            this.txtTotalAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotalAmt_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Trade Discount in (%)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(518, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Taxable Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(642, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "CGST";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(723, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "SGST";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(801, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Total Amt.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(112, 602);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Quantity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(167, 610);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(219, 602);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Net Price";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(455, 602);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 16);
            this.label16.TabIndex = 15;
            this.label16.Text = "Taxable Amount";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(596, 602);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 16);
            this.label17.TabIndex = 15;
            this.label17.Text = "CGST";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(691, 602);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 16);
            this.label18.TabIndex = 15;
            this.label18.Text = "SGST";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(775, 602);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 16);
            this.label19.TabIndex = 15;
            this.label19.Text = "Total Amount";
            // 
            // labelqty
            // 
            this.labelqty.AutoSize = true;
            this.labelqty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelqty.Location = new System.Drawing.Point(126, 632);
            this.labelqty.Name = "labelqty";
            this.labelqty.Size = new System.Drawing.Size(15, 16);
            this.labelqty.TabIndex = 15;
            this.labelqty.Text = "0";
            // 
            // labelmrp
            // 
            this.labelmrp.AutoSize = true;
            this.labelmrp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmrp.Location = new System.Drawing.Point(45, 632);
            this.labelmrp.Name = "labelmrp";
            this.labelmrp.Size = new System.Drawing.Size(15, 16);
            this.labelmrp.TabIndex = 15;
            this.labelmrp.Text = "0";
            // 
            // labeltaxAmount
            // 
            this.labeltaxAmount.AutoSize = true;
            this.labeltaxAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltaxAmount.Location = new System.Drawing.Point(474, 632);
            this.labeltaxAmount.Name = "labeltaxAmount";
            this.labeltaxAmount.Size = new System.Drawing.Size(15, 16);
            this.labeltaxAmount.TabIndex = 15;
            this.labeltaxAmount.Text = "0";
            // 
            // labelnetprice
            // 
            this.labelnetprice.AutoSize = true;
            this.labelnetprice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnetprice.Location = new System.Drawing.Point(230, 632);
            this.labelnetprice.Name = "labelnetprice";
            this.labelnetprice.Size = new System.Drawing.Size(15, 16);
            this.labelnetprice.TabIndex = 15;
            this.labelnetprice.Text = "0";
            // 
            // labelCGST
            // 
            this.labelCGST.AutoSize = true;
            this.labelCGST.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCGST.Location = new System.Drawing.Point(605, 632);
            this.labelCGST.Name = "labelCGST";
            this.labelCGST.Size = new System.Drawing.Size(15, 16);
            this.labelCGST.TabIndex = 15;
            this.labelCGST.Text = "0";
            // 
            // labelSGST
            // 
            this.labelSGST.AutoSize = true;
            this.labelSGST.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSGST.Location = new System.Drawing.Point(700, 632);
            this.labelSGST.Name = "labelSGST";
            this.labelSGST.Size = new System.Drawing.Size(15, 16);
            this.labelSGST.TabIndex = 15;
            this.labelSGST.Text = "0";
            // 
            // labelTotalAmt
            // 
            this.labelTotalAmt.AutoSize = true;
            this.labelTotalAmt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmt.Location = new System.Drawing.Point(796, 632);
            this.labelTotalAmt.Name = "labelTotalAmt";
            this.labelTotalAmt.Size = new System.Drawing.Size(15, 16);
            this.labelTotalAmt.TabIndex = 15;
            this.labelTotalAmt.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(36, 602);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 16);
            this.label28.TabIndex = 15;
            this.label28.Text = "MRP";
            // 
            // btn_proceed
            // 
            this.btn_proceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_proceed.FlatAppearance.BorderSize = 0;
            this.btn_proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proceed.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proceed.ForeColor = System.Drawing.Color.Black;
            this.btn_proceed.Location = new System.Drawing.Point(1133, 512);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(127, 38);
            this.btn_proceed.TabIndex = 19;
            this.btn_proceed.Text = "Proceed";
            this.btn_proceed.UseVisualStyleBackColor = false;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // btn_AddPart
            // 
            this.btn_AddPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_AddPart.FlatAppearance.BorderSize = 0;
            this.btn_AddPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddPart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPart.ForeColor = System.Drawing.Color.Black;
            this.btn_AddPart.Location = new System.Drawing.Point(1050, 56);
            this.btn_AddPart.Name = "btn_AddPart";
            this.btn_AddPart.Size = new System.Drawing.Size(125, 25);
            this.btn_AddPart.TabIndex = 23;
            this.btn_AddPart.Text = "Add Parts";
            this.btn_AddPart.UseVisualStyleBackColor = false;
            this.btn_AddPart.Click += new System.EventHandler(this.btn_AddPart_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(320, 602);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Total Discount";
            // 
            // labelTDisc
            // 
            this.labelTDisc.AutoSize = true;
            this.labelTDisc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTDisc.Location = new System.Drawing.Point(339, 632);
            this.labelTDisc.Name = "labelTDisc";
            this.labelTDisc.Size = new System.Drawing.Size(15, 16);
            this.labelTDisc.TabIndex = 15;
            this.labelTDisc.Text = "0";
            // 
            // txtcustAddress
            // 
            this.txtcustAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcustAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustAddress.Location = new System.Drawing.Point(331, 141);
            this.txtcustAddress.Multiline = true;
            this.txtcustAddress.Name = "txtcustAddress";
            this.txtcustAddress.Size = new System.Drawing.Size(173, 44);
            this.txtcustAddress.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(157, 120);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 17);
            this.label20.TabIndex = 20;
            this.label20.Text = "Customer Name:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(328, 120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 17);
            this.label21.TabIndex = 21;
            this.label21.Text = "Delivery Address:";
            // 
            // btn_SeeOrders
            // 
            this.btn_SeeOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_SeeOrders.FlatAppearance.BorderSize = 0;
            this.btn_SeeOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SeeOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeeOrders.ForeColor = System.Drawing.Color.Black;
            this.btn_SeeOrders.Location = new System.Drawing.Point(914, 56);
            this.btn_SeeOrders.Name = "btn_SeeOrders";
            this.btn_SeeOrders.Size = new System.Drawing.Size(126, 25);
            this.btn_SeeOrders.TabIndex = 22;
            this.btn_SeeOrders.Text = "All Orders";
            this.btn_SeeOrders.UseVisualStyleBackColor = false;
            this.btn_SeeOrders.Click += new System.EventHandler(this.btn_SeeOrders_Click);
            // 
            // btnUpdateDiscount
            // 
            this.btnUpdateDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btnUpdateDiscount.FlatAppearance.BorderSize = 0;
            this.btnUpdateDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDiscount.Location = new System.Drawing.Point(1133, 448);
            this.btnUpdateDiscount.Name = "btnUpdateDiscount";
            this.btnUpdateDiscount.Size = new System.Drawing.Size(127, 38);
            this.btnUpdateDiscount.TabIndex = 18;
            this.btnUpdateDiscount.Text = "Update Discount";
            this.btnUpdateDiscount.UseVisualStyleBackColor = false;
            this.btnUpdateDiscount.Click += new System.EventHandler(this.btnUpdateDiscount_Click);
            // 
            // pictureBoxOrdIcon
            // 
            this.pictureBoxOrdIcon.Image = global::AutoManufacture.Properties.Resources.orderIcon;
            this.pictureBoxOrdIcon.Location = new System.Drawing.Point(31, 18);
            this.pictureBoxOrdIcon.Name = "pictureBoxOrdIcon";
            this.pictureBoxOrdIcon.Size = new System.Drawing.Size(81, 66);
            this.pictureBoxOrdIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOrdIcon.TabIndex = 16;
            this.pictureBoxOrdIcon.TabStop = false;
            // 
            // comboBoxCustomerN
            // 
            this.comboBoxCustomerN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxCustomerN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCustomerN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomerN.FormattingEnabled = true;
            this.comboBoxCustomerN.Location = new System.Drawing.Point(156, 141);
            this.comboBoxCustomerN.Name = "comboBoxCustomerN";
            this.comboBoxCustomerN.Size = new System.Drawing.Size(152, 23);
            this.comboBoxCustomerN.TabIndex = 1;
            this.comboBoxCustomerN.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerN_SelectedIndexChanged);
            this.comboBoxCustomerN.Enter += new System.EventHandler(this.comboBoxCustomerN_Enter);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_AddCustomer.FlatAppearance.BorderSize = 0;
            this.btn_AddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCustomer.ForeColor = System.Drawing.Color.Black;
            this.btn_AddCustomer.Location = new System.Drawing.Point(778, 56);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(126, 25);
            this.btn_AddCustomer.TabIndex = 21;
            this.btn_AddCustomer.Text = "Add Customer";
            this.btn_AddCustomer.UseVisualStyleBackColor = false;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(1133, 614);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(127, 25);
            this.btn_clear.TabIndex = 25;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // comboBoxHSNCode
            // 
            this.comboBoxHSNCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHSNCode.FormattingEnabled = true;
            this.comboBoxHSNCode.Location = new System.Drawing.Point(1127, 141);
            this.comboBoxHSNCode.Name = "comboBoxHSNCode";
            this.comboBoxHSNCode.Size = new System.Drawing.Size(131, 23);
            this.comboBoxHSNCode.TabIndex = 6;
            // 
            // btn_clearFields
            // 
            this.btn_clearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_clearFields.FlatAppearance.BorderSize = 0;
            this.btn_clearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearFields.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearFields.Location = new System.Drawing.Point(1133, 209);
            this.btn_clearFields.Name = "btn_clearFields";
            this.btn_clearFields.Size = new System.Drawing.Size(125, 25);
            this.btn_clearFields.TabIndex = 24;
            this.btn_clearFields.Text = "Clear Fields";
            this.btn_clearFields.UseVisualStyleBackColor = false;
            this.btn_clearFields.Click += new System.EventHandler(this.btn_clearFields_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(524, 120);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 17);
            this.label22.TabIndex = 21;
            this.label22.Text = "GST/PAN No :";
            // 
            // txtGstPanNo
            // 
            this.txtGstPanNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGstPanNo.Location = new System.Drawing.Point(527, 141);
            this.txtGstPanNo.Name = "txtGstPanNo";
            this.txtGstPanNo.Size = new System.Drawing.Size(162, 23);
            this.txtGstPanNo.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(871, 120);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(105, 17);
            this.label23.TabIndex = 1;
            this.label23.Text = "Part Description";
            // 
            // txtPartDescr
            // 
            this.txtPartDescr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartDescr.Location = new System.Drawing.Point(874, 141);
            this.txtPartDescr.Name = "txtPartDescr";
            this.txtPartDescr.Size = new System.Drawing.Size(232, 23);
            this.txtPartDescr.TabIndex = 5;
            // 
            // txtinvoice
            // 
            this.txtinvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoice.Location = new System.Drawing.Point(33, 141);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.Size = new System.Drawing.Size(100, 23);
            this.txtinvoice.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(32, 120);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 17);
            this.label24.TabIndex = 20;
            this.label24.Text = "Invoice No:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(930, 197);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(173, 17);
            this.label25.TabIndex = 1;
            this.label25.Text = "Invoice Date (dd/MM/yyyy)";
            // 
            // txtinvDate
            // 
            this.txtinvDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvDate.Location = new System.Drawing.Point(933, 219);
            this.txtinvDate.Name = "txtinvDate";
            this.txtinvDate.Size = new System.Drawing.Size(170, 23);
            this.txtinvDate.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1301, 670);
            this.Controls.Add(this.txtinvDate);
            this.Controls.Add(this.txtinvoice);
            this.Controls.Add(this.txtPartDescr);
            this.Controls.Add(this.txtGstPanNo);
            this.Controls.Add(this.btn_clearFields);
            this.Controls.Add(this.comboBoxHSNCode);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_AddCustomer);
            this.Controls.Add(this.comboBoxCustomerN);
            this.Controls.Add(this.btnUpdateDiscount);
            this.Controls.Add(this.btn_SeeOrders);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtcustAddress);
            this.Controls.Add(this.btn_AddPart);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.pictureBoxOrdIcon);
            this.Controls.Add(this.labelTotalAmt);
            this.Controls.Add(this.labelSGST);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.labelCGST);
            this.Controls.Add(this.labelnetprice);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labelTDisc);
            this.Controls.Add(this.labeltaxAmount);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelmrp);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labelqty);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotalAmt);
            this.Controls.Add(this.txtsgst);
            this.Controls.Add(this.txtCgst);
            this.Controls.Add(this.txtTaxAmt);
            this.Controls.Add(this.txtTDisc);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.orderGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.PartList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtnetprice);
            this.Controls.Add(this.txtmrp);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrdIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtmrp;
        private System.Windows.Forms.TextBox txtnetprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PartList;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.TextBox txtTDisc;
        private System.Windows.Forms.TextBox txtTaxAmt;
        private System.Windows.Forms.TextBox txtCgst;
        private System.Windows.Forms.TextBox txtsgst;
        private System.Windows.Forms.TextBox txtTotalAmt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.Label labelqty;
        public System.Windows.Forms.Label labelmrp;
        public System.Windows.Forms.Label labeltaxAmount;
        public System.Windows.Forms.Label labelnetprice;
        public System.Windows.Forms.Label labelCGST;
        public System.Windows.Forms.Label labelSGST;
        public System.Windows.Forms.Label labelTotalAmt;
        private System.Windows.Forms.PictureBox pictureBoxOrdIcon;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Button btn_AddPart;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label labelTDisc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox txtcustAddress;
        private System.Windows.Forms.Button btn_SeeOrders;
        private System.Windows.Forms.Button btnUpdateDiscount;
        public System.Windows.Forms.ComboBox comboBoxCustomerN;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox comboBoxHSNCode;
        private System.Windows.Forms.Button btn_clearFields;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox txtGstPanNo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtPartDescr;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.TextBox txtinvoice;
        private System.Windows.Forms.Label label25;
        public System.Windows.Forms.TextBox txtinvDate;
    }
}

