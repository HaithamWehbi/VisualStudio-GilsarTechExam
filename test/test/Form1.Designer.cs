namespace test
{
    partial class form1
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
            this.manageBtn = new System.Windows.Forms.Button();
            this.U_MBtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // manageBtn
            // 
            this.manageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.manageBtn.Location = new System.Drawing.Point(197, 293);
            this.manageBtn.Name = "manageBtn";
            this.manageBtn.Size = new System.Drawing.Size(149, 41);
            this.manageBtn.TabIndex = 0;
            this.manageBtn.Text = "Items";
            this.manageBtn.UseVisualStyleBackColor = true;
            this.manageBtn.Click += new System.EventHandler(this.manageBtn_Click);
            // 
            // U_MBtn
            // 
            this.U_MBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.U_MBtn.Location = new System.Drawing.Point(197, 380);
            this.U_MBtn.Name = "U_MBtn";
            this.U_MBtn.Size = new System.Drawing.Size(149, 41);
            this.U_MBtn.TabIndex = 1;
            this.U_MBtn.Text = "ItemU_M";
            this.U_MBtn.UseVisualStyleBackColor = true;
            this.U_MBtn.Click += new System.EventHandler(this.U_MBtn_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OrderBtn.Location = new System.Drawing.Point(197, 207);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(149, 41);
            this.OrderBtn.TabIndex = 2;
            this.OrderBtn.Text = "Orders";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.welcome.Location = new System.Drawing.Point(207, 30);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(126, 31);
            this.welcome.TabIndex = 3;
            this.welcome.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gilsar Technologies";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.U_MBtn);
            this.Controls.Add(this.manageBtn);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gilsar Technologies";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manageBtn;
        private System.Windows.Forms.Button U_MBtn;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label label1;
    }
}

