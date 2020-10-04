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
    public partial class UpdateItemForm : Form
    {
        public UpdateItemForm()
        {
            InitializeComponent();
        }


        //update button event
        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            if (IDTextBoxU.Text == "")
            {
                MessageBox.Show("Type OrderID");
                return;
            }

            if (DescBoxU.Text == "")
            {
                MessageBox.Show("Type Item Description");
                return;
            }

            if (AmountBoxU.Text == "")
            {
                MessageBox.Show("Type Item Amount");
                return;
            }

            if (PriceBoxU.Text == "")
            {
                MessageBox.Show("Type Item Price");
                return;
            }

            if (UMUpdateBox.Text == "")
            {
                MessageBox.Show("Type Item U_M");
                return;
            }

            var res = UpdateItem();

            if (res == true)
            {
                MessageBox.Show("updated Item");
                Close();
            }
            else
            {
                MessageBox.Show("error updating item");

            }

        }

      
        //update when all the textbox's arent empty if the given id exist in database
        public bool UpdateItem()
        {
            try
            {
                var svr = new Server();
                using (var Conn = new SqlConnection(svr.ConnectString))
                {
                    Conn.Open();
                    using (var cmd = new SqlCommand("UPDATE t_Items SET ItemDescription = @desc, ItemAmount = @amount, ItemPrice = @price, ItemU_M = @um WHERE OrderID = @itemid", Conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        if(IDTextBoxU.Text.ToString().Equals(""))
                        {
                            MessageBox.Show("type OrderID");
                            return false;
                        }

                        if (DescBoxU.Text.ToString() != "")
                        {
                            cmd.Parameters.AddWithValue("@desc", DescBoxU.Text.ToString());
                        }

                        if (AmountBoxU.Text.ToString() != "")
                        {
                            cmd.Parameters.AddWithValue("@amount", AmountBoxU.Text.ToString());
                        }

                        if (PriceBoxU.Text.ToString() != "")
                        {
                            cmd.Parameters.AddWithValue("@price", PriceBoxU.Text.ToString());
                        }

                        if (UMUpdateBox.Text.ToString() != "")
                        {
                            cmd.Parameters.AddWithValue("@um", UMUpdateBox.Text.ToString());
                        }


                        cmd.Parameters.AddWithValue("@itemid", IDTextBoxU.Text.ToString());
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //load button event
        private void LoadItemBtn_Click(object sender, EventArgs e)
        {

            if (IDTextBoxU.Text.Equals(""))
            {
                MessageBox.Show("Enter ID");
                return;
            }

            LoadItem();
        }



        //function to load info from database after given the ID
        //so the user doesnt have to write anything else but the new info hes going to update
        public void LoadItem()
        {
            string cmd = IDTextBoxU.Text;
            string temp = "SELECT * FROM t_Items WHERE OrderID = " + cmd;
            var svr = new Server();
            var dt = svr.GetData(temp);

            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("No Match for the givin ID");
                return;
            }

            var ItemDescription = dt.Rows[0][2];
            DescBoxU.Text = ItemDescription.ToString();

            var ItemAmount = dt.Rows[0][3];
            AmountBoxU.Text = ItemAmount.ToString();

            var ItemPrice = dt.Rows[0][4];
            PriceBoxU.Text = ItemPrice.ToString();

            var ItemU_M = dt.Rows[0][5];
            UMUpdateBox.Text = ItemU_M.ToString();

        }

        private void UpdateItemForm_Load(object sender, EventArgs e)
        {

        }
    }

}
