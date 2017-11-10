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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Connection string
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Björn\source\repos\databastestLocal\databastestLocal\Database1.mdf;Integrated Security=True";

        //Display name from DB
        private void EmployeeName_text()
        {

            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select * from Employees where name=@name and surname=@surname", con);
            cmd.Parameters.AddWithValue("@name", EmployeeName.Text);
            cmd.Parameters.AddWithValue("@surname", Surname.Text);
            //EmployeeName.text = "@name";
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
        }
        //btn_LogOut Click Event
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fl = new frmLogin();
            fl.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet2.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter2.Fill(this.database1DataSet2.Employees);
            

        }



        private void EmployeeName_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

//        private void btn_LogOut_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
