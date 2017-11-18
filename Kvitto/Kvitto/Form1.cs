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
            string[] lines = File.ReadAllLines(@"C:\Users\Anders\Documents\kvittodelar.txt");
            listBox1.Items.AddRange(lines);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("BUTIKENS NAMN "+ " ADRESS " + "TELEFON " + "ORG NUMMER");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print receipt");
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
