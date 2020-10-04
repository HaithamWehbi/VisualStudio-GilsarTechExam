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
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
        }

        //add button event
        private void AddBtn_Click(object sender, EventArgs e)
        {
            var form3 = new AddItemForm();
            form3.ShowDialog();

            refreshGrid();

        }

        //when this form is loaded refresh the gridview
        private void ItemsForm_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        //function to refresh the data in gridview
        
        void refreshGrid(string SearchText = "")
        {
            var svr = new Server();
            var dt = svr.GetData(string.Format("EXEC SP_Search_Items '{0}'", SearchText.Replace("'", "''"))); 
            itemGridView.DataSource = null;
            itemGridView.DataSource = dt;
        }

        private void itemGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        //update button event
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var form4 = new UpdateItemForm();
            form4.ShowDialog();

            refreshGrid();
        }

        //delete button event
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var form5 = new DeleteItemForm();
            form5.ShowDialog();

            refreshGrid();
        }

        //search button to find data by the procdure written in database 
        //proc to find data by orderID or itemDescription
        private void searchBtn_Click(object sender, EventArgs e)
        {
            refreshGrid(SearchTxt.Text);
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
