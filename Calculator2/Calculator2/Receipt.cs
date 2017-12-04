using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void searchReceptButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(" KVITTO " + " ID: 25060 " + " 20170325 " + " 723.50 KR");
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("printing Receipt");
        }
    }
}
