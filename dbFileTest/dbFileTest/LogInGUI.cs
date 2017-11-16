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


        private void btn_logIn_click(object sender, EventArgs e)
        {
            if (txtb_UserName.Text == "" || txtb_Password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            string line;

            using (StreamReader reader = new StreamReader(@"H:\\skola\\GIT\\Digitcashier\\dbFileTest\\dbFileTest\\txtf_users\\EmployeeCredentials.txt"))

            {

                while ((line = reader.ReadLine()) != null) ;


            }

            string[] ss = line.Split(',');

            if (txtb_UserName.Text == ss[0])

            {

                if (txtb_Password.Text == ss[1])

                {

                    this.Hide();



                    welcomePage mf = new welcomePage();

                    mf.Show();

                }

                else

                {

                    MessageBox.Show("Sorry Wrong Password");

                }

            }
        }



        // TA INT BORT DETTA!!

        private void LogInGUI_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // TA INT BORT DETTA!!














        


    }
}



// this.Hide();
//new welcomePage().Show();