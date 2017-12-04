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

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchItemButton_Click(object sender, EventArgs e)
        {
            pnl_Search.BringToFront();
            
            
            
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing receipt");
        }

        private void btn_SubmitSearch_Click(object sender, EventArgs e)
        {

            if (txtb_SearchBar.Text == "")
            {
                MessageBox.Show("Enter Search parameter");
            }
            try
            {
                Dbaccess db = new Dbaccess();
                DataSet ds = db.getReceipt(txtb_SearchBar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_CancelSearch_Click(object sender, EventArgs e)
        {
            pnl_Search.SendToBack();
        }
    }
}
