﻿
namespace AutoManufacture
{
    partial class QuantityPop
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdQty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Quantity :";
            // 
            // txtUpdQty
            // 
            this.txtUpdQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdQty.Location = new System.Drawing.Point(41, 64);
            this.txtUpdQty.Name = "txtUpdQty";
            this.txtUpdQty.Size = new System.Drawing.Size(101, 25);
            this.txtUpdQty.TabIndex = 1;
            this.txtUpdQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUpdQty_KeyDown);
            this.txtUpdQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdQty_KeyPress);
            // 
            // QuantityPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(194, 117);
            this.Controls.Add(this.txtUpdQty);
            this.Controls.Add(this.label1);
            this.Name = "QuantityPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuantityPop";
            this.Load += new System.EventHandler(this.QuantityPop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdQty;
    }
}