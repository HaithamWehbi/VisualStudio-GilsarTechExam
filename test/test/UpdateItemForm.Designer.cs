namespace test
{
    partial class UpdateItemForm
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
            this.PriceBoxU = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AmountBoxU = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.DescBoxU = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.IDTextBoxU = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.UMUpdateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadItemBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PriceBoxU
            // 
            this.PriceBoxU.Location = new System.Drawing.Point(101, 142);
            this.PriceBoxU.Name = "PriceBoxU";
            this.PriceBoxU.Size = new System.Drawing.Size(186, 20);
            this.PriceBoxU.TabIndex = 19;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(13, 149);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(51, 13);
            this.PriceLabel.TabIndex = 18;
            this.PriceLabel.Text = "ItemPrice";
            // 
            // AmountBoxU
            // 
            this.AmountBoxU.Location = new System.Drawing.Point(101, 98);
            this.AmountBoxU.Name = "AmountBoxU";
            this.AmountBoxU.Size = new System.Drawing.Size(186, 20);
            this.AmountBoxU.TabIndex = 17;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(13, 105);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(63, 13);
            this.AmountLabel.TabIndex = 16;
            this.AmountLabel.Text = "ItemAmount";
            // 
            // DescBoxU
            // 
            this.DescBoxU.Location = new System.Drawing.Point(101, 57);
            this.DescBoxU.Name = "DescBoxU";
            this.DescBoxU.Size = new System.Drawing.Size(186, 20);
            this.DescBoxU.TabIndex = 15;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(13, 64);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(80, 13);
            this.descLabel.TabIndex = 14;
            this.descLabel.Text = "ItemDescription";
            // 
            // IDTextBoxU
            // 
            this.IDTextBoxU.Location = new System.Drawing.Point(101, 17);
            this.IDTextBoxU.Name = "IDTextBoxU";
            this.IDTextBoxU.Size = new System.Drawing.Size(186, 20);
            this.IDTextBoxU.TabIndex = 13;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(13, 24);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(44, 13);
            this.IDLabel.TabIndex = 12;
            this.IDLabel.Text = "OrderID";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UpdateBtn.Location = new System.Drawing.Point(212, 228);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 11;
            this.UpdateBtn.Text = "Update Item";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // UMUpdateBox
            // 
            this.UMUpdateBox.Location = new System.Drawing.Point(101, 184);
            this.UMUpdateBox.Name = "UMUpdateBox";
            this.UMUpdateBox.Size = new System.Drawing.Size(186, 20);
            this.UMUpdateBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ItemU_M";
            // 
            // LoadItemBtn
            // 
            this.LoadItemBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoadItemBtn.Location = new System.Drawing.Point(121, 228);
            this.LoadItemBtn.Name = "LoadItemBtn";
            this.LoadItemBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadItemBtn.TabIndex = 22;
            this.LoadItemBtn.Text = "Load Item";
            this.LoadItemBtn.UseVisualStyleBackColor = true;
            this.LoadItemBtn.Click += new System.EventHandler(this.LoadItemBtn_Click);
            // 
            // UpdateItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 264);
            this.Controls.Add(this.LoadItemBtn);
            this.Controls.Add(this.UMUpdateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceBoxU);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.AmountBoxU);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.DescBoxU);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.IDTextBoxU);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.UpdateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateItemForm";
            this.Load += new System.EventHandler(this.UpdateItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PriceBoxU;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox AmountBoxU;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox DescBoxU;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox IDTextBoxU;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox UMUpdateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadItemBtn;
    }
}