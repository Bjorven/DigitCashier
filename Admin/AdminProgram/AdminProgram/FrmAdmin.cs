using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashierClasses;

namespace AdminProgram
{
    public partial class FrmAdmin : Form
    {
        
        public FrmAdmin()
        {
            InitializeComponent();
            pnl_Employee.Hide();
            pnl_Product.Hide();
            
        }
        
        private void arkivToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnl_Start.Show();

        }

        private void employee_NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            pnl_Employee.Show();
            pnl_Start.Hide();
            pnl_Product.Hide();
        }

        private void product_NewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnl_Employee.Hide();
            pnl_Start.Hide();
            pnl_Product.Show();
        }
    }
}
