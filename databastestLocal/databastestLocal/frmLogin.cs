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
                // sen kör vi  en boolmetod för att få true till nästa if statmennt.
                bool svar = db.credentialcheckerLogin(ds);


                //// får ut datan ur ds
                //Int32 First = Convert.ToInt32(ds.Tables[0].Rows[0]["employeeID"].ToString());
                //Int32 Second = Convert.ToInt32(ds.Tables[0].Rows[0]["password"].ToString());
                //Int32 Third = Convert.ToInt32(ds.Tables[0].Rows[0]["acesslvl"].ToString());
                //string  Fourth= Convert.ToString(ds.Tables[0].Rows[0]["fname"].ToString());
               
                
                
                //    //If bool is true then it askes if the dataset contains a 2,3 or a 5 in the acesslvl columm
                if (svar == true)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    frmMain fm = new frmMain(ds);
                    fm.Show();
                    //if (Third == 2)
                    //{
                    //    MessageBox.Show("Login Successful! cashier");
                    //    this.Hide();
                    //    frmCashier fc = new frmCashier();
                    //    fc.Show();
                    //}
                    //else if (Third == 3)
                    //{
                    //    MessageBox.Show("Login Successful! admin");
                    //    this.Hide();
                    //    frmAdmin fa = new frmAdmin();
                    //    fa.Show();
                    //}
                    //else if (Third == 5)
                    //{
                    //    MessageBox.Show("Login Successful! Boss");
                    //    this.Hide();
                    //    frmBoss fb = new frmBoss();
                    //    fb.Show();
                    //}


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
