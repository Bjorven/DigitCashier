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

namespace dbFileTest
{
    public partial class LogInGUI : Form
    {
        public LogInGUI()
        {
            InitializeComponent();
        }
        // TA INT BORT DETTA!!

        private void LogInGUI_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // TA INT BORT DETTA!!


        private void btn_logIn_click(object sender, EventArgs e)
        {
            if (txtb_UserName.Text == "" || txtb_Password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            string un;
            foreach (Int32 i in Cashier.getusername)
            {
                ToString()
            }





        }   


    }
}



// this.Hide();
//new welcomePage().Show();