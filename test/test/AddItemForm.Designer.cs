namespace test
{
    partial class AddItemForm
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.U_MBox = new System.Windows.Forms.TextBox();
            this.U_M = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SaveBtn.Location = new System.Drawing.Point(211, 223);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save Item";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(12, 25);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(44, 13);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "OrderID";
            this.IDLabel.Click += new System.EventHandler(this.IDLabel_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(100, 18);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(186, 20);
            this.IDTextBox.TabIndex = 2;
            this.IDTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(100, 58);
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(186, 20);
            this.DescBox.TabIndex = 4;
            this.DescBox.TextChanged += new System.EventHandler(this.DescBox_TextChanged);
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(12, 65);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(80, 13);
            this.descLabel.TabIndex = 3;
            this.descLabel.Text = "ItemDescription";
            this.descLabel.Click += new System.EventHandler(this.descLabel_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(100, 99);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(186, 20);
            this.AmountBox.TabIndex = 6;
            this.AmountBox.TextChanged += new System.EventHandler(this.AmountBox_TextChanged);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(12, 106);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(63, 13);
            this.AmountLabel.TabIndex = 5;
            this.AmountLabel.Text = "ItemAmount";
            this.AmountLabel.Click += new System.EventHandler(this.AmountLabel_Click);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(100, 143);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(186, 20);
            this.PriceBox.TabIndex = 8;
            this.PriceBox.TextChanged += new System.EventHandler(this.PriceBox_TextChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(12, 150);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(51, 13);
            this.PriceLabel.TabIndex = 7;
            this.PriceLabel.Text = "ItemPrice";
            this.PriceLabel.Click += new System.EventHandler(this.PriceLabel_Click);
            // 
            // U_MBox
            // 
            this.U_MBox.Location = new System.Drawing.Point(100, 186);
            this.U_MBox.Name = "U_MBox";
            this.U_MBox.Size = new System.Drawing.Size(186, 20);
            this.U_MBox.TabIndex = 10;
            this.U_MBox.TextChanged += new System.EventHandler(this.U_MBox_TextChanged);
            // 
            // U_M
            // 
            this.U_M.AutoSize = true;
            this.U_M.Location = new System.Drawing.Point(12, 193);
            this.U_M.Name = "U_M";
            this.U_M.Size = new System.Drawing.Size(50, 13);
            this.U_M.TabIndex = 9;
            this.U_M.Text = "ItemU_M";
            this.U_M.Click += new System.EventHandler(this.U_M_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 254);
            this.Controls.Add(this.U_MBox);
            this.Controls.Add(this.U_M);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.SaveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox U_MBox;
        private System.Windows.Forms.Label U_M;
    }
}