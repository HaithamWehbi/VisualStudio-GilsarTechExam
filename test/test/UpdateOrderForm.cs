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
    public partial class UpdateOrderForm : Form
    {
        public UpdateOrderForm()
        {
            InitializeComponent();
        }

        private void AmountLabel_Click(object sender, EventArgs e)
        {

        }

        //update order event
        private void ord_update_btn_Click(object sender, EventArgs e)
        {
            if (Ord_ID.Text == "")
            {
                MessageBox.Show("Type ID");
                return;
            }

            if (ord_number.Text == "")
            {
                MessageBox.Show("Type Order Number");
                return;
            }

            if (ord_date.Text == "")
            {
                MessageBox.Show("Type Order Date");
                return;
            }

            if (cus_name.Text == "")
            {
                MessageBox.Show("Type Customer Name");
                return;
            }

            if (cus_address.Text == "")
            {
                MessageBox.Show("Type Customer Address");
                return;
            }

            if (ord_totalamount.Text == "")
            {
                MessageBox.Show("Type Total Amount");
                return;
            }

            if (ord_refaund.Text == "")
            {
                MessageBox.Show("Type Order Refaund");
                return;
            }

            if (cus_city.Text == "")
            {
                MessageBox.Show("Type Customer City");
                return;
            }

            var res = UpdateOrder();

            if (res == true)
            {
                MessageBox.Show("updated Order");
                Close();
            }
            else
            {
                MessageBox.Show("error updating Order");

            }
        }


        //function to update order info if the given ID exist in database
        public bool UpdateOrder()
        {
            try
            {
                var svr = new Server();
                using (var Conn = new SqlConnection(svr.ConnectString))
                {
                    Conn.Open();
                    using (var cmd = new SqlCommand("UPDATE t_Orders SET OrderNumber = @num, OrderDate = @date, CustomerName = @name, CustomerAddress = @address, CustomerPhone = @phone, TotalAmount = @amount, RefaundAmount = @refaund, CustomerCity = @city WHERE ID = @id", Conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        if (Ord_ID.Text.ToString().Equals(""))
                        {
                            MessageBox.Show("type ID");
                            return false;
                        }

                        if (ord_number.Text.ToString() != "")
                        {
                            cmd.Parameters.AddWithValue("@num", ord_number.Text.ToString());
                        }

                        if (ord_date.Text.ToString() != "")
                        {
                            cmd.Parameters.AddWithValue("@date", ord_date.Text.ToString());
                        }

                        if (cus_name.Text.ToString() != "")
                        {
                            cmd.Parameters.AddWithValue("@name", cus_name.Text.ToString());
                        }

                        if (cus_address.Text.ToString() != "")
                        {
                            cmd.Parameters.AddWithValue("@address", cus_address.Text.ToString());
                        }

                        if (cus_phone.Text.ToString() != "")
                        {
                            cmd.Parameters.AddWithValue("@phone", cus_phone.Text.ToString());
                        }

                        if (ord_totalamount.Text.ToString() != "")
                        {
                            cmd.Parameters.AddWithValue("@amount", ord_totalamount.Text.ToString());
                        }

                        if (ord_refaund.Text.ToString() != "")
                        {
                            cmd.Parameters.AddWithValue("@refaund", ord_refaund.Text.ToString());
                        }

                        if (cus_city.Text.ToString() != "")
                        {
                            cmd.Parameters.AddWithValue("@city", cus_city.Text.ToString());
                        }


                        cmd.Parameters.AddWithValue("@id", Ord_ID.Text.ToString());
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

        //load info button event
        private void OrderLoadBtn_Click(object sender, EventArgs e)
        {

            if (Ord_ID.Text.Equals(""))
            {
                MessageBox.Show("Enter ID");
                return;
            }

            LoadOrder();
        }

        //function to load info from database after given the ID
        //so the user doesnt have to write anything else but the new info hes going to update
        public void LoadOrder()
        {
            string cmd = Ord_ID.Text;
            string temp = "SELECT * FROM t_Orders WHERE ID = " + cmd;
            var svr = new Server();
            var dt = svr.GetData(temp);

            if(dt.Rows.Count < 1)
            {
                MessageBox.Show("No Match for the givin ID");
                return;
            }

            var ordNum = dt.Rows[0][1];
            ord_number.Text = ordNum.ToString();

            var ordDate = dt.Rows[0][2];
            ord_date.Text = ordDate.ToString();

            var cusName = dt.Rows[0][3];
            cus_name.Text = cusName.ToString();

            var cusAd = dt.Rows[0][4];
            cus_address.Text = cusAd.ToString();

            var cusPhone = dt.Rows[0][5];
            cus_phone.Text = cusPhone.ToString();

            var TA = dt.Rows[0][6];
            ord_totalamount.Text = TA.ToString();

            var REF = dt.Rows[0][7];
            ord_refaund.Text = REF.ToString();

            var city = dt.Rows[0][8];
            cus_city.Text = city.ToString();

        }


    }
}
