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
    public partial class DeleteItemForm : Form
    {
        public DeleteItemForm()
        {
            InitializeComponent();
        }


        //delete item event
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (OrderIDBoxD.Text == "")
            {
                MessageBox.Show("Type OrderID");
                return;
            }


            var res = DeleteItem();

            if (res == true)
            {
                MessageBox.Show("Deleted Item");
                Close();
            }
            else
            {
                MessageBox.Show("Error deleting item");

            }


        }

        //function to delete item from database if the given id exist
        public bool DeleteItem()
        {
            try
            {
                var svr = new Server();
                

                using (var Conn = new SqlConnection(svr.ConnectString))
                {
                    Conn.Open();
                    using (var cmd = new SqlCommand("DELETE FROM t_Items WHERE OrderID = @id", Conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@id", OrderIDBoxD.Text.ToString());
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
