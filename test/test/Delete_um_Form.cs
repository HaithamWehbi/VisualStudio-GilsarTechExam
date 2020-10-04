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
    public partial class Delete_um_Form : Form
    {
        public Delete_um_Form()
        {
            InitializeComponent();
        }

        //delete itemu-m event
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (Delete_um_box.Text == "")
            {
                MessageBox.Show("Type itemU_M");
                return;
            }


            var res = DeleteItem();

            if (res == true)
            {
                MessageBox.Show("Deleted ItemU_M");
                Close();
            }
            else
            {
                MessageBox.Show("Error deleting itemU_M");

            }
        }

        //delete itemu-m if the given id exists in database
        public bool DeleteItem()
        {
            try
            {
                var svr = new Server();


                using (var Conn = new SqlConnection(svr.ConnectString))
                {
                    Conn.Open();
                    using (var cmd = new SqlCommand("DELETE FROM t_ItemU_M WHERE ItemU_M = @ium", Conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@ium", Delete_um_box.Text.ToString());
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
