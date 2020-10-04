namespace test
{
    partial class OrderForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchOrderBtn = new System.Windows.Forms.Button();
            this.DeleteOrderBtn = new System.Windows.Forms.Button();
            this.UpdateOrderBtn = new System.Windows.Forms.Button();
            this.addOrderBtn = new System.Windows.Forms.Button();
            this.SearchOrderTxt = new System.Windows.Forms.TextBox();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SearchOrderBtn);
            this.panel1.Controls.Add(this.DeleteOrderBtn);
            this.panel1.Controls.Add(this.UpdateOrderBtn);
            this.panel1.Controls.Add(this.addOrderBtn);
            this.panel1.Controls.Add(this.SearchOrderTxt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 124);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(496, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Orders Form";
            // 
            // SearchOrderBtn
            // 
            this.SearchOrderBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SearchOrderBtn.Location = new System.Drawing.Point(404, 9);
            this.SearchOrderBtn.Name = "SearchOrderBtn";
            this.SearchOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchOrderBtn.TabIndex = 4;
            this.SearchOrderBtn.Text = "Search";
            this.SearchOrderBtn.UseVisualStyleBackColor = true;
            this.SearchOrderBtn.Click += new System.EventHandler(this.SearchOrderBtn_Click);
            // 
            // DeleteOrderBtn
            // 
            this.DeleteOrderBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DeleteOrderBtn.Location = new System.Drawing.Point(13, 87);
            this.DeleteOrderBtn.Name = "DeleteOrderBtn";
            this.DeleteOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteOrderBtn.TabIndex = 3;
            this.DeleteOrderBtn.Text = "Delete";
            this.DeleteOrderBtn.UseVisualStyleBackColor = true;
            this.DeleteOrderBtn.Click += new System.EventHandler(this.DeleteOrderBtn_Click);
            // 
            // UpdateOrderBtn
            // 
            this.UpdateOrderBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UpdateOrderBtn.Location = new System.Drawing.Point(13, 49);
            this.UpdateOrderBtn.Name = "UpdateOrderBtn";
            this.UpdateOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateOrderBtn.TabIndex = 2;
            this.UpdateOrderBtn.Text = "Update";
            this.UpdateOrderBtn.UseVisualStyleBackColor = true;
            this.UpdateOrderBtn.Click += new System.EventHandler(this.UpdateOrderBtn_Click);
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addOrderBtn.Location = new System.Drawing.Point(13, 13);
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.addOrderBtn.TabIndex = 1;
            this.addOrderBtn.Text = "Add";
            this.addOrderBtn.UseVisualStyleBackColor = true;
            this.addOrderBtn.Click += new System.EventHandler(this.addOrderBtn_Click);
            // 
            // SearchOrderTxt
            // 
            this.SearchOrderTxt.Location = new System.Drawing.Point(499, 12);
            this.SearchOrderTxt.Name = "SearchOrderTxt";
            this.SearchOrderTxt.Size = new System.Drawing.Size(129, 20);
            this.SearchOrderTxt.TabIndex = 0;
            // 
            // OrderGridView
            // 
            this.OrderGridView.AllowUserToAddRows = false;
            this.OrderGridView.AllowUserToDeleteRows = false;
            this.OrderGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Location = new System.Drawing.Point(12, 360);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.Size = new System.Drawing.Size(641, 172);
            this.OrderGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(553, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gilsar Technologies";
            // 
            // MenuGridView
            // 
            this.MenuGridView.AllowUserToAddRows = false;
            this.MenuGridView.AllowUserToDeleteRows = false;
            this.MenuGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuGridView.Location = new System.Drawing.Point(12, 166);
            this.MenuGridView.Name = "MenuGridView";
            this.MenuGridView.Size = new System.Drawing.Size(641, 150);
            this.MenuGridView.TabIndex = 9;
            this.MenuGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuGridView_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(313, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(293, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Order History";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(665, 579);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MenuGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchOrderBtn;
        private System.Windows.Forms.Button DeleteOrderBtn;
        private System.Windows.Forms.Button UpdateOrderBtn;
        private System.Windows.Forms.Button addOrderBtn;
        private System.Windows.Forms.TextBox SearchOrderTxt;
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MenuGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}