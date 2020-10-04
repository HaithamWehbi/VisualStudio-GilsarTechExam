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
    public partial class DeleteOrderForm : Form
    {
        public DeleteOrderForm()
        {
            InitializeComponent();
        }


        //delete order event button
        private void delOrder_Click(object sender, EventArgs e)
        {
            if (delOrder.Text == "")
            {
                MessageBox.Show("Type ID");
                return;
            }


            var res = DeleteOrder();

            if (res == true)
            {
                MessageBox.Show("Deleted Order");
                Close();
            }
            else
            {
                MessageBox.Show("Error deleting Order");

            }
        }


        //function to delete order from database if the given id exist
        public bool DeleteOrder()
        {
            try
            {
                var svr = new Server();


                using (var Conn = new SqlConnection(svr.ConnectString))
                {
                    Conn.Open();
                    using (var cmd = new SqlCommand("DELETE FROM t_Orders WHERE ID = @id", Conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@id", delOrderTxt.Text.ToString());
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
