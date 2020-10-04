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
    public partial class Add_um_Form : Form
    {
        public Add_um_Form()
        {
            InitializeComponent();
        }

        //saving itemU_M click button
        private void umSaveBtn_Click(object sender, EventArgs e)
        {
           
            //if box doesnt contain text or the text is more than 10 chars show msg
            if (UM_Txt.Text == "" || UM_Txt.Text.Length > 10)
            {
                MessageBox.Show("Type ItemU_M up to 10 letters");
                return;
            }

            
            var res = SaveNewItemUM();
            // if adding new itemu-m work or not show msg
            if (res == true)
            {
                MessageBox.Show("Added ItemU_M");
                Close();
            }
            else
            {
                MessageBox.Show("error adding itemU_M");

            }
        }

        //function to save new itemu-m
        public bool SaveNewItemUM()
        {
            try
            {
                var svr = new Server();
                using (var Conn = new SqlConnection(svr.ConnectString))
                {
                    Conn.Open();
                    using (var cmd = new SqlCommand("INSERT INTO t_ItemU_M (ItemU_M) VALUES (@ium)", Conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        
                        cmd.Parameters.AddWithValue("@ium", UM_Txt.Text.ToString());
                        
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error adding new itemU_M", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



    }
}
