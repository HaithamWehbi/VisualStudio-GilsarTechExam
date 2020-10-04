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
    public partial class Update_um_Btn : Form
    {
        public Update_um_Btn()
        {
            InitializeComponent();
        }

        //update button event
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (UM_update_txt.Text == "")
            {
                MessageBox.Show("Type ItemU_M");
                return;
            }

            if (new_ium_txt.Text == "")
            {
                MessageBox.Show("Type New ItemU_M");
                return;
            }

            var res = UpdateItem();

            if (res == true)
            {
                MessageBox.Show("updated ItemU_M");
                Close();
            }
            else
            {
                MessageBox.Show("error updating itemU_M");

            }
        }

        //update itemU_M by replacing it with given text
        public bool UpdateItem()
        {
            try
            {
                var svr = new Server();
                using (var Conn = new SqlConnection(svr.ConnectString))
                {
                    Conn.Open();
                    using (var cmd = new SqlCommand("UPDATE t_ItemU_M SET ItemU_M = @ium WHERE ItemU_M = @newium", Conn))
                    {
                        cmd.CommandType = CommandType.Text;
                       

                        if (UM_update_txt.Text.ToString() != "")
                        {
                            cmd.Parameters.AddWithValue("@ium", new_ium_txt.Text.ToString());
                        }


                        cmd.Parameters.AddWithValue("@newium", UM_update_txt.Text.ToString());
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



    }
}
