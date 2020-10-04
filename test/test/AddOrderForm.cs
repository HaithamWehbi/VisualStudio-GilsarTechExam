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
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }


        //saving new order event
        //each col has it own input checker
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (OrderNumberTxt.Text == "")
            {
                MessageBox.Show("Type Order Number");
                return;
            }

            if(IsDigitsOnly(OrderNumberTxt.Text) == false)
            {
                MessageBox.Show("type Order Number with numbers only");
                return;
            }

            if (OrderDateTxt.Text == "")
            {
                MessageBox.Show("Type Order Date");
                return;
            }

            //if the writen text contains a date format
            if(DateTime.TryParse(OrderDateTxt.Text, out DateTime resu) == false)
            {
                MessageBox.Show("Type Order Date as Date Format only");
                return;
            }

            if (CostumerNameTxt.Text == "" || CostumerNameTxt.Text.Length > 50)
            {
                MessageBox.Show("Type Costumer Name up to 50 letters");
                return;
            }

            if (cosAddressTxt.Text == "" || cosAddressTxt.Text.Length > 80)
            {
                MessageBox.Show("Type Costumer Address up to 80 letters");
                return;
            }

            if (cosPhoneTxt.Text == "" || cosPhoneTxt.Text.Length > 22)
            {
                MessageBox.Show("Type Costumer Phone up to 22 digits");
                return;
            }

            if (IsDigitsOnly(cosPhoneTxt.Text) == false)
            {
                MessageBox.Show("type Phone Number with numbers only");
                return;
            }

            if (TotalAmountTxt.Text == "")
            {
                MessageBox.Show("Type Total Amount");
                return;
            }

            if (IsDigitsOnly(TotalAmountTxt.Text) == false)
            {
                MessageBox.Show("type Total Amount with numbers only");
                return;
            }

            if (refaundTxt.Text == "")
            {
                MessageBox.Show("Type Refaund Amount");
                return;
            }

            if (IsDigitsOnly(refaundTxt.Text) == false)
            {
                MessageBox.Show("type Refaund with numbers only");
                return;
            }

            if (cosCityTxt.Text == "" || cosCityTxt.Text.Length > 30)
            {
                MessageBox.Show("Type Costumer City up to 30 letters");
                return;
            }


            var res = SaveNewOrder();

            if (res == true)
            {
                MessageBox.Show("Added Order");
                Close();
            }
            else
            {
                MessageBox.Show("error adding Order");

            }
        }


        //function to save new order
        public bool SaveNewOrder()
        {
            try
            {
                var svr = new Server();
                using (var Conn = new SqlConnection(svr.ConnectString))
                {
                    Conn.Open();
                    using (var cmd = new SqlCommand("INSERT INTO t_Orders (ID ,OrderNumber, OrderDate, CustomerName, CustomerAddress, CustomerPhone, TotalAmount, RefaundAmount, CustomerCity) VALUES (@id, @num, @date, @name, @addr, @phone, @amount, @refaund, @city)", Conn))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@num", OrderNumberTxt.Text.ToString());
                        cmd.Parameters.AddWithValue("@date", OrderDateTxt.Text.ToString());
                        cmd.Parameters.AddWithValue("@name", CostumerNameTxt.Text.ToString());
                        cmd.Parameters.AddWithValue("@addr", cosAddressTxt.Text.ToString());
                        cmd.Parameters.AddWithValue("@phone", cosPhoneTxt.Text.ToString());
                        cmd.Parameters.AddWithValue("@amount", TotalAmountTxt.Text.ToString());
                        cmd.Parameters.AddWithValue("@refaund", refaundTxt.Text.ToString());
                        cmd.Parameters.AddWithValue("@city", cosCityTxt.Text.ToString());

                        cmd.Parameters.AddWithValue("@id", OrderIDForm.Text.ToString());

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error adding new Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //function to check if text contains digits only
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }



    }
}
