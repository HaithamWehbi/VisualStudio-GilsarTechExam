namespace test
{
    partial class Update_um_Btn
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
            this.UM_update_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.new_ium_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UM_update_txt
            // 
            this.UM_update_txt.Location = new System.Drawing.Point(96, 12);
            this.UM_update_txt.Name = "UM_update_txt";
            this.UM_update_txt.Size = new System.Drawing.Size(186, 20);
            this.UM_update_txt.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ItemU_M";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UpdateBtn.Location = new System.Drawing.Point(182, 94);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(100, 23);
            this.UpdateBtn.TabIndex = 22;
            this.UpdateBtn.Text = "Update ItemU_M";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // new_ium_txt
            // 
            this.new_ium_txt.Location = new System.Drawing.Point(96, 50);
            this.new_ium_txt.Name = "new_ium_txt";
            this.new_ium_txt.Size = new System.Drawing.Size(186, 20);
            this.new_ium_txt.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "New ItemU_M";
            // 
            // Update_um_Btn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 131);
            this.Controls.Add(this.new_ium_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UM_update_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Update_um_Btn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_um_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UM_update_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox new_ium_txt;
        private System.Windows.Forms.Label label2;
    }
}