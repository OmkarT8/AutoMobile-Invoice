
namespace AutoManufacture
{
    partial class AddCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.txtxcustaddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addcust = new System.Windows.Forms.Button();
            this.dataGVCustomer = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_updatecust = new System.Windows.Forms.Button();
            this.btn_delcust = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGstPan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcustname
            // 
            this.txtcustname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcustname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustname.Location = new System.Drawing.Point(30, 149);
            this.txtcustname.Multiline = true;
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(244, 44);
            this.txtcustname.TabIndex = 0;
            // 
            // txtxcustaddress
            // 
            this.txtxcustaddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtxcustaddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxcustaddress.Location = new System.Drawing.Point(293, 149);
            this.txtxcustaddress.Multiline = true;
            this.txtxcustaddress.Name = "txtxcustaddress";
            this.txtxcustaddress.Size = new System.Drawing.Size(247, 44);
            this.txtxcustaddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Address :";
            // 
            // btn_addcust
            // 
            this.btn_addcust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_addcust.FlatAppearance.BorderSize = 0;
            this.btn_addcust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addcust.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addcust.Location = new System.Drawing.Point(761, 214);
            this.btn_addcust.Name = "btn_addcust";
            this.btn_addcust.Size = new System.Drawing.Size(139, 38);
            this.btn_addcust.TabIndex = 4;
            this.btn_addcust.Text = "Add Customer";
            this.btn_addcust.UseVisualStyleBackColor = false;
            this.btn_addcust.Click += new System.EventHandler(this.btn_addcust_Click);
            // 
            // dataGVCustomer
            // 
            this.dataGVCustomer.AllowUserToAddRows = false;
            this.dataGVCustomer.AllowUserToDeleteRows = false;
            this.dataGVCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dataGVCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVCustomer.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGVCustomer.EnableHeadersVisualStyles = false;
            this.dataGVCustomer.Location = new System.Drawing.Point(27, 214);
            this.dataGVCustomer.Name = "dataGVCustomer";
            this.dataGVCustomer.ReadOnly = true;
            this.dataGVCustomer.RowHeadersVisible = false;
            this.dataGVCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVCustomer.Size = new System.Drawing.Size(722, 399);
            this.dataGVCustomer.TabIndex = 7;
            this.dataGVCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVCustomer_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add Customer :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoManufacture.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(27, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_updatecust
            // 
            this.btn_updatecust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_updatecust.FlatAppearance.BorderSize = 0;
            this.btn_updatecust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatecust.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatecust.ForeColor = System.Drawing.Color.Black;
            this.btn_updatecust.Location = new System.Drawing.Point(761, 286);
            this.btn_updatecust.Name = "btn_updatecust";
            this.btn_updatecust.Size = new System.Drawing.Size(139, 38);
            this.btn_updatecust.TabIndex = 5;
            this.btn_updatecust.Text = "Update";
            this.btn_updatecust.UseVisualStyleBackColor = false;
            this.btn_updatecust.Click += new System.EventHandler(this.btn_updatecust_Click);
            // 
            // btn_delcust
            // 
            this.btn_delcust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_delcust.FlatAppearance.BorderSize = 0;
            this.btn_delcust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delcust.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delcust.ForeColor = System.Drawing.Color.Black;
            this.btn_delcust.Location = new System.Drawing.Point(761, 358);
            this.btn_delcust.Name = "btn_delcust";
            this.btn_delcust.Size = new System.Drawing.Size(139, 38);
            this.btn_delcust.TabIndex = 6;
            this.btn_delcust.Text = "Delete";
            this.btn_delcust.UseVisualStyleBackColor = false;
            this.btn_delcust.Click += new System.EventHandler(this.btn_delcust_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(761, 149);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(139, 38);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear Fields";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(755, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Instructions :";
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.Color.White;
            this.txtInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstructions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructions.Location = new System.Drawing.Point(758, 446);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.Size = new System.Drawing.Size(225, 167);
            this.txtInstructions.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(556, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "GST/PAN No :";
            // 
            // txtGstPan
            // 
            this.txtGstPan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGstPan.Location = new System.Drawing.Point(559, 149);
            this.txtGstPan.Multiline = true;
            this.txtGstPan.Name = "txtGstPan";
            this.txtGstPan.Size = new System.Drawing.Size(180, 44);
            this.txtGstPan.TabIndex = 2;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 656);
            this.Controls.Add(this.txtGstPan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delcust);
            this.Controls.Add(this.btn_updatecust);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGVCustomer);
            this.Controls.Add(this.btn_addcust);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtxcustaddress);
            this.Controls.Add(this.txtcustname);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.TextBox txtxcustaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addcust;
        private System.Windows.Forms.DataGridView dataGVCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_updatecust;
        private System.Windows.Forms.Button btn_delcust;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGstPan;
    }
}