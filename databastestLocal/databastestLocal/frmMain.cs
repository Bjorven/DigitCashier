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
        public frmMain(DataSet ds)
        {
            InitializeComponent();
            // får ut datan ur ds
            Int32 First = Convert.ToInt32(ds.Tables[0].Rows[0]["employeeID"].ToString());
            Int32 Second = Convert.ToInt32(ds.Tables[0].Rows[0]["password"].ToString());
            Int32 Third = Convert.ToInt32(ds.Tables[0].Rows[0]["acesslvl"].ToString());
            string Fourth = Convert.ToString(ds.Tables[0].Rows[0]["fname"].ToString());
            if (Third == 2)
            {
                btn_admin.Hide();
                btn_boss.Hide();   
            }
            else if (Third == 3)
            {
                btn_cashier.Hide();
                btn_boss.Hide();
            }
            else if (Third == 5)
            {
                btn_admin.Hide();
                btn_cashier.Hide();
            }
            
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

        }
    }
}
