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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void manageBtn_Click(object sender, EventArgs e)
        {
            var manager = new ItemsForm();
            manager.ShowDialog();
        }

        private void U_MBtn_Click(object sender, EventArgs e)
        {
            var form2 = new ItemU_M_form();
            form2.ShowDialog();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            var form3 = new OrderForm();
            form3.ShowDialog();
        }
    }
}
