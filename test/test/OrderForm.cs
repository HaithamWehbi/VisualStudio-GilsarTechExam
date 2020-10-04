using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            var form3 = new AddOrderForm();
            form3.ShowDialog();

            refreshGrid();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            refreshGrid();
            refreshMenu();
        }

        //function to refresh data in order history gridview
        void refreshGrid(string SearchText = "")
        {
            var svr = new Server();
            var dt = svr.GetData(string.Format("EXEC Search_Order '{0}'", SearchText.Replace("'", "''")));
            OrderGridView.DataSource = null;
            OrderGridView.DataSource = dt;
        }

        //function to refresh data in Menu gridview
        void refreshMenu(string SearchText = "")
        {
            var svr = new Server();
            var dt = svr.GetData(string.Format("EXEC SP_Search_Items '{0}'", SearchText.Replace("'", "''")));
            MenuGridView.DataSource = null;
            MenuGridView.DataSource = dt;
        }



        private void UpdateOrderBtn_Click(object sender, EventArgs e)
        {
            var form4 = new UpdateOrderForm();
            form4.ShowDialog();

            refreshGrid();
        }

        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            var form5 = new DeleteOrderForm();
            form5.ShowDialog();

            refreshGrid();
        }

        //searching procdure by ID or CustomerCity
        private void SearchOrderBtn_Click(object sender, EventArgs e)
        {
            refreshGrid(SearchOrderTxt.Text);
        }

        private void MenuGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
