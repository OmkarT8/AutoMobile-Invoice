
namespace AutoManufacture
{
    partial class AddParts
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHsnCode = new System.Windows.Forms.TextBox();
            this.txtPartno = new System.Windows.Forms.TextBox();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGVParts = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.cboSheetName = new System.Windows.Forms.ComboBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.ExceldataGV = new System.Windows.Forms.DataGridView();
            this.partNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hSNCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btndeleteAll = new System.Windows.Forms.Button();
            this.txtPartDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcgst = new System.Windows.Forms.TextBox();
            this.txtsgst = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExceldataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Parts :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "HSN Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Part No. :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1003, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "MRP (INR) :";
            // 
            // txtHsnCode
            // 
            this.txtHsnCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHsnCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHsnCode.Location = new System.Drawing.Point(555, 140);
            this.txtHsnCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtHsnCode.Name = "txtHsnCode";
            this.txtHsnCode.Size = new System.Drawing.Size(155, 27);
            this.txtHsnCode.TabIndex = 2;
            // 
            // txtPartno
            // 
            this.txtPartno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartno.Location = new System.Drawing.Point(60, 140);
            this.txtPartno.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartno.Name = "txtPartno";
            this.txtPartno.Size = new System.Drawing.Size(212, 27);
            this.txtPartno.TabIndex = 0;
            // 
            // txtMRP
            // 
            this.txtMRP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRP.Location = new System.Drawing.Point(1004, 143);
            this.txtMRP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(100, 27);
            this.txtMRP.TabIndex = 5;
            this.txtMRP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMRP_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(1153, 204);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(189, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(1153, 272);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(189, 38);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(1153, 340);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGVParts
            // 
            this.dataGVParts.AllowUserToAddRows = false;
            this.dataGVParts.AllowUserToDeleteRows = false;
            this.dataGVParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVParts.BackgroundColor = System.Drawing.Color.White;
            this.dataGVParts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVParts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGVParts.EnableHeadersVisualStyles = false;
            this.dataGVParts.GridColor = System.Drawing.Color.Silver;
            this.dataGVParts.Location = new System.Drawing.Point(57, 178);
            this.dataGVParts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGVParts.Name = "dataGVParts";
            this.dataGVParts.ReadOnly = true;
            this.dataGVParts.RowHeadersVisible = false;
            this.dataGVParts.RowHeadersWidth = 51;
            this.dataGVParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVParts.Size = new System.Drawing.Size(1048, 401);
            this.dataGVParts.TabIndex = 9;
            this.dataGVParts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVParts_CellDoubleClick);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(1151, 140);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(189, 38);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear Fields";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoManufacture.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(57, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1152, 388);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Instructions :";
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.Color.White;
            this.txtInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstructions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructions.Location = new System.Drawing.Point(1151, 417);
            this.txtInstructions.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.Size = new System.Drawing.Size(313, 94);
            this.txtInstructions.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 601);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Excel File Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(815, 603);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sheet Name :";
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.Color.White;
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(207, 597);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(439, 29);
            this.txtFileName.TabIndex = 10;
            // 
            // cboSheetName
            // 
            this.cboSheetName.BackColor = System.Drawing.Color.White;
            this.cboSheetName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSheetName.FormattingEnabled = true;
            this.cboSheetName.Location = new System.Drawing.Point(968, 597);
            this.cboSheetName.Margin = new System.Windows.Forms.Padding(4);
            this.cboSheetName.Name = "cboSheetName";
            this.cboSheetName.Size = new System.Drawing.Size(160, 29);
            this.cboSheetName.TabIndex = 12;
            this.cboSheetName.SelectedIndexChanged += new System.EventHandler(this.cboSheetName_SelectedIndexChanged);
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_import.FlatAppearance.BorderSize = 0;
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_import.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.ForeColor = System.Drawing.Color.Black;
            this.btn_import.Location = new System.Drawing.Point(1157, 597);
            this.btn_import.Margin = new System.Windows.Forms.Padding(4);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(125, 31);
            this.btn_import.TabIndex = 13;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_browse.FlatAppearance.BorderSize = 0;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.Color.Black;
            this.btn_browse.Location = new System.Drawing.Point(655, 597);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(147, 31);
            this.btn_browse.TabIndex = 11;
            this.btn_browse.Text = "Browse File..";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // ExceldataGV
            // 
            this.ExceldataGV.AllowUserToAddRows = false;
            this.ExceldataGV.AllowUserToDeleteRows = false;
            this.ExceldataGV.AutoGenerateColumns = false;
            this.ExceldataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExceldataGV.BackgroundColor = System.Drawing.Color.White;
            this.ExceldataGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExceldataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ExceldataGV.ColumnHeadersHeight = 28;
            this.ExceldataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partNoDataGridViewTextBoxColumn,
            this.partDesDataGridViewTextBoxColumn,
            this.hSNCodeDataGridViewTextBoxColumn,
            this.cGSTDataGridViewTextBoxColumn,
            this.sGSTDataGridViewTextBoxColumn,
            this.mRPDataGridViewTextBoxColumn});
            this.ExceldataGV.DataSource = this.partsBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExceldataGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.ExceldataGV.EnableHeadersVisualStyles = false;
            this.ExceldataGV.GridColor = System.Drawing.Color.Black;
            this.ExceldataGV.Location = new System.Drawing.Point(57, 635);
            this.ExceldataGV.Margin = new System.Windows.Forms.Padding(4);
            this.ExceldataGV.Name = "ExceldataGV";
            this.ExceldataGV.ReadOnly = true;
            this.ExceldataGV.RowHeadersVisible = false;
            this.ExceldataGV.RowHeadersWidth = 51;
            this.ExceldataGV.Size = new System.Drawing.Size(1225, 207);
            this.ExceldataGV.TabIndex = 19;
            // 
            // partNoDataGridViewTextBoxColumn
            // 
            this.partNoDataGridViewTextBoxColumn.DataPropertyName = "PartNo";
            this.partNoDataGridViewTextBoxColumn.HeaderText = "PartNo";
            this.partNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partNoDataGridViewTextBoxColumn.Name = "partNoDataGridViewTextBoxColumn";
            this.partNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partDesDataGridViewTextBoxColumn
            // 
            this.partDesDataGridViewTextBoxColumn.DataPropertyName = "PartDes";
            this.partDesDataGridViewTextBoxColumn.HeaderText = "PartDes";
            this.partDesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partDesDataGridViewTextBoxColumn.Name = "partDesDataGridViewTextBoxColumn";
            this.partDesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hSNCodeDataGridViewTextBoxColumn
            // 
            this.hSNCodeDataGridViewTextBoxColumn.DataPropertyName = "HSNCode";
            this.hSNCodeDataGridViewTextBoxColumn.HeaderText = "HSNCode";
            this.hSNCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hSNCodeDataGridViewTextBoxColumn.Name = "hSNCodeDataGridViewTextBoxColumn";
            this.hSNCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cGSTDataGridViewTextBoxColumn
            // 
            this.cGSTDataGridViewTextBoxColumn.DataPropertyName = "CGST";
            this.cGSTDataGridViewTextBoxColumn.HeaderText = "CGST";
            this.cGSTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cGSTDataGridViewTextBoxColumn.Name = "cGSTDataGridViewTextBoxColumn";
            this.cGSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sGSTDataGridViewTextBoxColumn
            // 
            this.sGSTDataGridViewTextBoxColumn.DataPropertyName = "SGST";
            this.sGSTDataGridViewTextBoxColumn.HeaderText = "SGST";
            this.sGSTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sGSTDataGridViewTextBoxColumn.Name = "sGSTDataGridViewTextBoxColumn";
            this.sGSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mRPDataGridViewTextBoxColumn
            // 
            this.mRPDataGridViewTextBoxColumn.DataPropertyName = "MRP";
            this.mRPDataGridViewTextBoxColumn.HeaderText = "MRP";
            this.mRPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mRPDataGridViewTextBoxColumn.Name = "mRPDataGridViewTextBoxColumn";
            this.mRPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataSource = typeof(AutoManufacture.Parts);
            // 
            // btndeleteAll
            // 
            this.btndeleteAll.BackColor = System.Drawing.Color.Brown;
            this.btndeleteAll.FlatAppearance.BorderSize = 0;
            this.btndeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteAll.Location = new System.Drawing.Point(1151, 518);
            this.btndeleteAll.Margin = new System.Windows.Forms.Padding(4);
            this.btndeleteAll.Name = "btndeleteAll";
            this.btndeleteAll.Size = new System.Drawing.Size(192, 33);
            this.btndeleteAll.TabIndex = 15;
            this.btndeleteAll.Text = "Delete All";
            this.btndeleteAll.UseVisualStyleBackColor = false;
            this.btndeleteAll.Click += new System.EventHandler(this.btndeleteAll_Click);
            // 
            // txtPartDesc
            // 
            this.txtPartDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartDesc.Location = new System.Drawing.Point(291, 140);
            this.txtPartDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartDesc.Name = "txtPartDesc";
            this.txtPartDesc.Size = new System.Drawing.Size(244, 27);
            this.txtPartDesc.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(287, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Part Description :";
            // 
            // txtcgst
            // 
            this.txtcgst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcgst.Location = new System.Drawing.Point(735, 140);
            this.txtcgst.Margin = new System.Windows.Forms.Padding(4);
            this.txtcgst.Name = "txtcgst";
            this.txtcgst.Size = new System.Drawing.Size(109, 27);
            this.txtcgst.TabIndex = 3;
            // 
            // txtsgst
            // 
            this.txtsgst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsgst.Location = new System.Drawing.Point(871, 140);
            this.txtsgst.Margin = new System.Windows.Forms.Padding(4);
            this.txtsgst.Name = "txtsgst";
            this.txtsgst.Size = new System.Drawing.Size(104, 27);
            this.txtsgst.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(731, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "CGST :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(867, 114);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "SGST :";
            // 
            // AddParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1496, 863);
            this.Controls.Add(this.txtsgst);
            this.Controls.Add(this.txtcgst);
            this.Controls.Add(this.txtPartDesc);
            this.Controls.Add(this.btndeleteAll);
            this.Controls.Add(this.ExceldataGV);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.cboSheetName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dataGVParts);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMRP);
            this.Controls.Add(this.txtPartno);
            this.Controls.Add(this.txtHsnCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddParts";
            this.Load += new System.EventHandler(this.AddParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExceldataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHsnCode;
        private System.Windows.Forms.TextBox txtPartno;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGVParts;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.ComboBox cboSheetName;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.DataGridView ExceldataGV;
        private System.Windows.Forms.Button btndeleteAll;
        private System.Windows.Forms.TextBox txtPartDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcgst;
        private System.Windows.Forms.TextBox txtsgst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hSNCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRPDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partsBindingSource;
    }
}