namespace test
{
    partial class Add_um_Form
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
            this.UM_Txt = new System.Windows.Forms.TextBox();
            this.um = new System.Windows.Forms.Label();
            this.umSaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UM_Txt
            // 
            this.UM_Txt.Location = new System.Drawing.Point(107, 26);
            this.UM_Txt.Name = "UM_Txt";
            this.UM_Txt.Size = new System.Drawing.Size(186, 20);
            this.UM_Txt.TabIndex = 17;
            // 
            // um
            // 
            this.um.AutoSize = true;
            this.um.Location = new System.Drawing.Point(19, 33);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(50, 13);
            this.um.TabIndex = 16;
            this.um.Text = "ItemU_M";
            // 
            // umSaveBtn
            // 
            this.umSaveBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.umSaveBtn.Location = new System.Drawing.Point(200, 87);
            this.umSaveBtn.Name = "umSaveBtn";
            this.umSaveBtn.Size = new System.Drawing.Size(93, 23);
            this.umSaveBtn.TabIndex = 11;
            this.umSaveBtn.Text = "Save ItemU_M";
            this.umSaveBtn.UseVisualStyleBackColor = true;
            this.umSaveBtn.Click += new System.EventHandler(this.umSaveBtn_Click);
            // 
            // Add_um_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 136);
            this.Controls.Add(this.UM_Txt);
            this.Controls.Add(this.um);
            this.Controls.Add(this.umSaveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add_um_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_um_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UM_Txt;
        private System.Windows.Forms.Label um;
        private System.Windows.Forms.Button umSaveBtn;
    }
}