using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace databastestLocal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }


        private void frmLogin_Load(object sender, EventArgs e)
        {



        }



        //btn_Submit Click event
        private void btn_Submit_Click(object sender, EventArgs e)
        {



            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                DbAcess db = new DbAcess();
                // vi tar först och skapar ett data set av inmatade information i textboxen
                DataSet ds = db.getdataset(txt_UserName.Text, txt_Password.Text);




                


                MessageBox.Show("Login Successful!");
                this.Hide();
                frmMain fm = new frmMain(ds);
                fm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed!");
                //goggla how to stacktrace print
                //ex.StackTrace
            }
        }












    }
}



//        private void btn_Submit_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
