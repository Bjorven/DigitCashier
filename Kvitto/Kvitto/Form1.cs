using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kvitto
{
    public partial class Kvittosystem : Form
    {
        public Kvittosystem()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Björn\Documents\kvittodelar.txt");

            listBox1.Items.AddRange(lines);
            listBox2.Items.Add(" ÄPPLEN");
            listBox3.Items.Add(" 650 KR ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnl_Search.BringToFront();
            //lBox_display.Items.Add(" KVITTO "+ " ID: 25060 " + " 20170325 " + " 723.50 KR");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing receipt");
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_SearchRId_Click(object sender, EventArgs e)
        {
            if (txtb_Search.Text == "")
            {
                MessageBox.Show("Please Enter Value");
                return;
            }
            try
            {
                Dbacess db = new Dbacess();
                DataSet ds = db.getReceipt(txtb_Search.Text);
                List<receiptinfo> myReceipt = new List<receiptinfo>();
                foreach (DataRow r in ds)
                {

                }

            }
            catch (Exception ex)
            {

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
