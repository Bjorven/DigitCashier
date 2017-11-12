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
        User nw = new User();

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


        //Connection String
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\skola\GIT\Digitcashier\databastestLocal\databastestLocal\databasen\Empolees.mdf;Integrated Security=True";
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
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from EmployeeUsers where employeeID=@employeeID and password=@password", con);
                cmd.Parameters.AddWithValue("@employeeID", txt_UserName.Text);
                cmd.Parameters.AddWithValue("@password", txt_Password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();

                

                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, then show frmMain form
                if (count == 1)
                {
                    
                    SqlCommand call = new SqlCommand("Select * from EmployeeUsers where in row = txt_UserName.text employeeID=@employeeID and acesslvl=@acesslvl and forname=@forename", con);
                    call.Parameters.AddWithValue("@employeeID", nw.UserName);
                    call.Parameters.AddWithValue("@acesslvl", nw.Acesslevel);
                    call.Parameters.AddWithValue("@forename", nw.Fname);

                    

                    MessageBox.Show(nw.Fname);
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

        private static void NewMethod()
        {
            



        }

    }
}
//        private void btn_Submit_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
