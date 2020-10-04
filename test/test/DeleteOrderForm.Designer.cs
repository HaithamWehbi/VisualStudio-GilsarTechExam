namespace test
{
    partial class DeleteOrderForm
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
            this.delOrderTxt = new System.Windows.Forms.TextBox();
            this.nn4 = new System.Windows.Forms.Label();
            this.delOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delOrderTxt
            // 
            this.delOrderTxt.Location = new System.Drawing.Point(103, 19);
            this.delOrderTxt.Name = "delOrderTxt";
            this.delOrderTxt.Size = new System.Drawing.Size(186, 20);
            this.delOrderTxt.TabIndex = 16;
            // 
            // nn4
            // 
            this.nn4.AutoSize = true;
            this.nn4.Location = new System.Drawing.Point(15, 26);
            this.nn4.Name = "nn4";
            this.nn4.Size = new System.Drawing.Size(18, 13);
            this.nn4.TabIndex = 15;
            this.nn4.Text = "ID";
            // 
            // delOrder
            // 
            this.delOrder.ForeColor = System.Drawing.SystemColors.Highlight;
            this.delOrder.Location = new System.Drawing.Point(214, 56);
            this.delOrder.Name = "delOrder";
            this.delOrder.Size = new System.Drawing.Size(75, 23);
            this.delOrder.TabIndex = 14;
            this.delOrder.Text = "Delete Order";
            this.delOrder.UseVisualStyleBackColor = true;
            this.delOrder.Click += new System.EventHandler(this.delOrder_Click);
            // 
            // DeleteOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 116);
            this.Controls.Add(this.delOrderTxt);
            this.Controls.Add(this.nn4);
            this.Controls.Add(this.delOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeleteOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox delOrderTxt;
        private System.Windows.Forms.Label nn4;
        private System.Windows.Forms.Button delOrder;
    }
}