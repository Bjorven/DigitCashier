using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databastestLocal
{
    public partial class frmMain : Form
    {
        private User user;
        public frmMain(User user)
        {
            InitializeComponent();
            this.user = user;



            //DbAcess db = new DbAcess();


            // får ut datan ur ds
            //Int32 passcode = Convert.ToInt32(ds.Tables[0].Rows[0]["passwordPIN"].ToString());
            //Int32 acesslvl = Convert.ToInt32(ds.Tables[0].Rows[0]["acessLvl"].ToString());
            //Int32 postalCode = Convert.ToInt32(ds.Tables[0].Rows[0]["postCode"].ToString());
            //Int32 username = Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
            //Int32 salary = Convert.ToInt32(ds.Tables[0].Rows[0]["Salary"].ToString());
            //Int32 age = Convert.ToInt32(ds.Tables[0].Rows[0]["age"].ToString());
            //Int32 reportsTo = Convert.ToInt32(ds.Tables[0].Rows[0]["reportsTo"].ToString());
            //
            //
            //string fname = Convert.ToString(ds.Tables[0].Rows[0]["fName"].ToString());
            //string sname = Convert.ToString(ds.Tables[0].Rows[0]["sName"].ToString());
            //string dob = Convert.ToString(ds.Tables[0].Rows[0]["dob"].ToString());
            //string adress = Convert.ToString(ds.Tables[0].Rows[0]["adress"].ToString());
            //string companyId = Convert.ToString(ds.Tables[0].Rows[0]["CompanyId"].ToString());
            //DateTime hoursWorked = Convert.ToDateTime(ds.Tables[0].Rows[0]["hoursWorked"].ToString());

        }


        private void btn_cashier_Click(object sender, EventArgs e)
        {

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {

        }

        private void btn_boss_Click(object sender, EventArgs e)
        {

        }


        private void frmMain_Load(object sender, EventArgs e)
        {

            switch (this.user.RoleId)
            {
                case 2:






                    btn_admin.Hide();
                    btn_boss.Hide();
                    break;
                case 3:
                    //Admin admin = new Admin(username);
                    //admin.Acesslevel = acesslvl.ToString();
                    //admin.Fname = fname;
                    btn_cashier.Hide();
                    btn_boss.Hide();
                    break;
                case 5:
                    //Boss boss = new Boss(username);
                    //boss.Acesslevel = acesslvl.ToString();
                    //boss.Fname = fname;
                    btn_cashier.Hide();
                    btn_admin.Hide();
                    break;
                default:
                    break;
            }
        }
    }
}
