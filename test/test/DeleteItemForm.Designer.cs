﻿namespace test
{
    partial class DeleteItemForm
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
            this.OrderIDBoxD = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.BtnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderIDBoxD
            // 
            this.OrderIDBoxD.Location = new System.Drawing.Point(98, 24);
            this.OrderIDBoxD.Name = "OrderIDBoxD";
            this.OrderIDBoxD.Size = new System.Drawing.Size(186, 20);
            this.OrderIDBoxD.TabIndex = 13;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(10, 31);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(44, 13);
            this.lb.TabIndex = 12;
            this.lb.Text = "OrderID";
            // 
            // BtnDel
            // 
            this.BtnDel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnDel.Location = new System.Drawing.Point(209, 61);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 11;
            this.BtnDel.Text = "Delete Item";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // DeleteItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 111);
            this.Controls.Add(this.OrderIDBoxD);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.BtnDel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeleteItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrderIDBoxD;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button BtnDel;
    }
}