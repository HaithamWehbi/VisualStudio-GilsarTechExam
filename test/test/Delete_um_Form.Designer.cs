namespace test
{
    partial class Delete_um_Form
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
            this.Delete_um_box = new System.Windows.Forms.TextBox();
            this.nn1 = new System.Windows.Forms.Label();
            this.Del_UM_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Delete_um_box
            // 
            this.Delete_um_box.Location = new System.Drawing.Point(99, 12);
            this.Delete_um_box.Name = "Delete_um_box";
            this.Delete_um_box.Size = new System.Drawing.Size(186, 20);
            this.Delete_um_box.TabIndex = 16;
            // 
            // nn1
            // 
            this.nn1.AutoSize = true;
            this.nn1.Location = new System.Drawing.Point(12, 19);
            this.nn1.Name = "nn1";
            this.nn1.Size = new System.Drawing.Size(50, 13);
            this.nn1.TabIndex = 15;
            this.nn1.Text = "ItemU_M";
            // 
            // Del_UM_Btn
            // 
            this.Del_UM_Btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Del_UM_Btn.Location = new System.Drawing.Point(189, 49);
            this.Del_UM_Btn.Name = "Del_UM_Btn";
            this.Del_UM_Btn.Size = new System.Drawing.Size(96, 23);
            this.Del_UM_Btn.TabIndex = 14;
            this.Del_UM_Btn.Text = "Delete ItemU_M";
            this.Del_UM_Btn.UseVisualStyleBackColor = true;
            this.Del_UM_Btn.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // Delete_um_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 108);
            this.Controls.Add(this.Delete_um_box);
            this.Controls.Add(this.nn1);
            this.Controls.Add(this.Del_UM_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Delete_um_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete_um_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Delete_um_box;
        private System.Windows.Forms.Label nn1;
        private System.Windows.Forms.Button Del_UM_Btn;
    }
}