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
        public void btn_Submit_Click(object sender, EventArgs e)
        {


            //User nw = new User();
            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                bool svar = dbAcess.credentialcheckerLogin(txt_UserName.Text, txt_Password.Text);


                //    //If count is equal to 1, then show frmMain form


                if (svar == true)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    frmMain fm = new frmMain();
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
