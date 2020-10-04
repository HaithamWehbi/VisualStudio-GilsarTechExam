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
    public partial class ItemU_M_form : Form
    {
        public ItemU_M_form()
        {
            InitializeComponent();
        }

        private void umAddBtn_Click(object sender, EventArgs e)
        {
            var form3 = new Add_um_Form();
            form3.ShowDialog();

            refreshGrid();
        }

        //function to refresh data in gridview
        void refreshGrid(string SearchText = "")
        {
            var svr = new Server();
            var dt = svr.GetData(string.Format("EXEC ium_Search '{0}'", SearchText.Replace("'", "''")));
            umGridView.DataSource = null;
            umGridView.DataSource = dt;
        }

        private void umUpdateBtn_Click(object sender, EventArgs e)
        {
            var form4 = new Update_um_Btn();
            form4.ShowDialog();

            refreshGrid();
        }

        private void umDeleteBtn_Click(object sender, EventArgs e)
        {
            var form5 = new Delete_um_Form();
            form5.ShowDialog();

            refreshGrid();
        }

        

        //searching procdure by itemU_M
        private void umSearchBtn_Click(object sender, EventArgs e)
        {
            refreshGrid(umSearchBox.Text);
        }

        private void ItemU_M_form_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }
    }
}
