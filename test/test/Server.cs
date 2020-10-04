using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

/***
 * 
 * #Haitham Wehbi
 * #start date 01/10/2020
 * #end date 04/10/2020
 * 
 * */

namespace test
{
    public class Server
    {

        public string myServer { get; set; } = ConfigurationManager.AppSettings["Server"].ToString();
        public string myDataBase { get; set; } = ConfigurationManager.AppSettings["DataBase"].ToString();
        public string ConnectString => string.Format("Server={0}; DataBase={1}; Integrated Security=SSPI;", myServer, myDataBase);

        #region "connection"



        public bool Connected()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString =
                  @"Data Source=DESKTOP-N9GFFK8\SQLEXPRESS01;" +
                  "Initial Catalog=test;" +
                  "Integrated Security=SSPI;";

                conn.Open();
                conn.Close();

                return true;
            }
            catch(Exception e)
            {

                MessageBox.Show(e.Message, "Error Connecting to server.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }


        #endregion


        #region "Data table"

        public DataTable GetData(string command)
        {
            try
            {
                using (var conn = new SqlConnection(ConnectString))
                {
                    conn.Open();
                    var dataTable = new DataTable();
                    var dataAdapter = new SqlDataAdapter(command, conn);
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error Getting Data.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        #endregion






    }
}
