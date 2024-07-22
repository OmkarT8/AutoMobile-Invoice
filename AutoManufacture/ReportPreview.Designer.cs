
namespace AutoManufacture
{
    partial class ReportPreview
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
            this.orderReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_generateBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderReportViewer
            // 
            this.orderReportViewer.Location = new System.Drawing.Point(98, 83);
            this.orderReportViewer.Name = "orderReportViewer";
            this.orderReportViewer.ServerReport.BearerToken = null;
            this.orderReportViewer.Size = new System.Drawing.Size(997, 594);
            this.orderReportViewer.TabIndex = 0;
            // 
            // btn_generateBill
            // 
            this.btn_generateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.btn_generateBill.FlatAppearance.BorderSize = 0;
            this.btn_generateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generateBill.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generateBill.ForeColor = System.Drawing.Color.Black;
            this.btn_generateBill.Location = new System.Drawing.Point(98, 26);
            this.btn_generateBill.Name = "btn_generateBill";
            this.btn_generateBill.Size = new System.Drawing.Size(159, 33);
            this.btn_generateBill.TabIndex = 2;
            this.btn_generateBill.Text = "Generate Bill";
            this.btn_generateBill.UseVisualStyleBackColor = false;
            this.btn_generateBill.Click += new System.EventHandler(this.btn_generateBill_Click);
            // 
            // ReportPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1202, 701);
            this.Controls.Add(this.btn_generateBill);
            this.Controls.Add(this.orderReportViewer);
            this.Name = "ReportPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportPreview";
            this.Load += new System.EventHandler(this.ReportPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer orderReportViewer;
        private System.Windows.Forms.Button btn_generateBill;
    }
}