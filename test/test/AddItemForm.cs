using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void DescBox_TextChanged(object sender, EventArgs e)
        {

        }

        //function to check if the string only digits or not
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        //saving new item event
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(IDTextBox.Text == "")
            {
                MessageBox.Show("Type OrderID");
                return;
            }

            if(IsDigitsOnly(IDTextBox.Text) == false)
            {
                MessageBox.Show("OrderID have to be only numbers");
                return;
            }

            if (DescBox.Text == "" || DescBox.Text.Length > 80)
            {
                MessageBox.Show("Type Item Description up to 80 letters");
                return;
            }

            if (AmountBox.Text == "")
            {
                MessageBox.Show("Type Item Amount");
                return;
            }

            if (IsDigitsOnly(AmountBox.Text) == false)
            {
                MessageBox.Show("Amount have to be only numbers");
                return;
            }

            if (PriceBox.Text == "")
            {
                MessageBox.Show("Type Item Price");
                return;
            }

            if (IsDigitsOnly(PriceBox.Text) == false)
            {
                MessageBox.Show("Price have to be only numbers");
                return;
            }

            if (U_MBox.Text == "" || U_MBox.Text.Length > 10)
            {
                MessageBox.Show("Type Item U_M up to 10 letters");
                return;
            }

            




            var res = SaveNewItem();

            //if adding new item equals true show msg and close form
            if(res == true)
            {
                MessageBox.Show("Added Item");
                Close();
            }
            else
            {
                MessageBox.Show("error adding item");
                
            }

        }

        //function to save new item
        public bool SaveNewItem()
        {
            try
            {
                var svr = new Server();
                using (var Conn = new SqlConnection(svr.ConnectString))
                {
                    Conn.Open();
                    using (var cmd = new SqlCommand("INSERT INTO t_Items (OrderID, ItemDescription, ItemAmount, ItemPrice, ItemU_M) VALUES (@id, @desc, @amount, @price, @um)", Conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@id", IDTextBox.Text.ToString());
                        cmd.Parameters.AddWithValue("@desc", DescBox.Text.ToString());
                        cmd.Parameters.AddWithValue("@amount", AmountBox.Text.ToString());
                        cmd.Parameters.AddWithValue("@price", PriceBox.Text.ToString());
                        cmd.Parameters.AddWithValue("@um", U_MBox.Text.ToString());
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error adding new item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void U_M_Click(object sender, EventArgs e)
        {

        }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void AmountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void descLabel_Click(object sender, EventArgs e)
        {

        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void U_MBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
