namespace test
{
    partial class ItemU_M_form
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
            this.umAddBtn = new System.Windows.Forms.Button();
            this.umUpdateBtn = new System.Windows.Forms.Button();
            this.umDeleteBtn = new System.Windows.Forms.Button();
            this.umSearchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.umSearchBox = new System.Windows.Forms.TextBox();
            this.umGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.umGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // umAddBtn
            // 
            this.umAddBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.umAddBtn.Location = new System.Drawing.Point(13, 9);
            this.umAddBtn.Name = "umAddBtn";
            this.umAddBtn.Size = new System.Drawing.Size(75, 23);
            this.umAddBtn.TabIndex = 0;
            this.umAddBtn.Text = "Add";
            this.umAddBtn.UseVisualStyleBackColor = true;
            this.umAddBtn.Click += new System.EventHandler(this.umAddBtn_Click);
            // 
            // umUpdateBtn
            // 
            this.umUpdateBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.umUpdateBtn.Location = new System.Drawing.Point(13, 38);
            this.umUpdateBtn.Name = "umUpdateBtn";
            this.umUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.umUpdateBtn.TabIndex = 1;
            this.umUpdateBtn.Text = "Update";
            this.umUpdateBtn.UseVisualStyleBackColor = true;
            this.umUpdateBtn.Click += new System.EventHandler(this.umUpdateBtn_Click);
            // 
            // umDeleteBtn
            // 
            this.umDeleteBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.umDeleteBtn.Location = new System.Drawing.Point(13, 67);
            this.umDeleteBtn.Name = "umDeleteBtn";
            this.umDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.umDeleteBtn.TabIndex = 2;
            this.umDeleteBtn.Text = "Delete";
            this.umDeleteBtn.UseVisualStyleBackColor = true;
            this.umDeleteBtn.Click += new System.EventHandler(this.umDeleteBtn_Click);
            // 
            // umSearchBtn
            // 
            this.umSearchBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.umSearchBtn.Location = new System.Drawing.Point(415, 7);
            this.umSearchBtn.Name = "umSearchBtn";
            this.umSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.umSearchBtn.TabIndex = 3;
            this.umSearchBtn.Text = "Search";
            this.umSearchBtn.UseVisualStyleBackColor = true;
            this.umSearchBtn.Click += new System.EventHandler(this.umSearchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.umSearchBox);
            this.panel1.Controls.Add(this.umAddBtn);
            this.panel1.Controls.Add(this.umSearchBtn);
            this.panel1.Controls.Add(this.umUpdateBtn);
            this.panel1.Controls.Add(this.umDeleteBtn);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 120);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(520, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "U_M Form";
            // 
            // umSearchBox
            // 
            this.umSearchBox.Location = new System.Drawing.Point(496, 9);
            this.umSearchBox.Name = "umSearchBox";
            this.umSearchBox.Size = new System.Drawing.Size(136, 20);
            this.umSearchBox.TabIndex = 4;
            // 
            // umGridView
            // 
            this.umGridView.AllowUserToAddRows = false;
            this.umGridView.AllowUserToDeleteRows = false;
            this.umGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.umGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.umGridView.Location = new System.Drawing.Point(12, 129);
            this.umGridView.Name = "umGridView";
            this.umGridView.Size = new System.Drawing.Size(644, 236);
            this.umGridView.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(556, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gilsar Technologies";
            // 
            // ItemU_M_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.umGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ItemU_M_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemU_M_form";
            this.Load += new System.EventHandler(this.ItemU_M_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.umGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button umAddBtn;
        private System.Windows.Forms.Button umUpdateBtn;
        private System.Windows.Forms.Button umDeleteBtn;
        private System.Windows.Forms.Button umSearchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox umSearchBox;
        private System.Windows.Forms.DataGridView umGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}