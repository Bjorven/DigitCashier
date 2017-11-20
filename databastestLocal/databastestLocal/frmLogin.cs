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
                dbAcess db = new dbAcess();
                // vi tar först och skapar ett data set av inmatade information i textboxen
                DataSet ds = db.getdataset(txt_UserName.Text, txt_Password.Text);

                int count = ds.Tables[0].Rows.Count;

               



                //    //If count == 1 then go to next formApp
                if (count == 1)
                {

                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    frmMain fm = new frmMain (ds);
                    fm.Show();
                    

                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        









    }
}



//        private void btn_Submit_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
