using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashierClasses;

namespace AdminProgram
{
    public partial class FrmAdmin : Form
    {
        
        public FrmAdmin()
        {
            InitializeComponent();
            pnl_Employee.Hide();
            pnl_Product.Hide();
            
            
            

            





        }


        private void ArkivToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pnl_Start.Show();
            //txtb_ENewAdress.Clear();
            //txtb_ENewAge.Clear();
            //txtb_ENewDob.Clear();
            //txtb_ENewEmpnr.Clear();
            //txtb_ENewFname.Clear();
            //txtb_ENewHiredDate.Clear();
            //txtb_ENewHoursWorked.Clear();
            //txtb_ENewLastActivityDate.Clear();
            //txtb_ENewPostcode.Clear();
            //txtb_ENewReportsTo.Clear();
            //txtb_ENewRole.Clear();
            //txtb_ENewSalary.Clear();
            //txtb_ENewSname.Clear();
            //txtb_ENewTerminationDate.Clear();
            //txtb_PNewManufacturer.Clear();
            DbAcess db = new DbAcess();
            DataSet ds = db.GetAllUser();
            employee_EdittoolStripComboBox.ComboBox.DataSource = ds.DefaultViewManager;
            employee_EdittoolStripComboBox.ComboBox.DisplayMember = "fname";
            employee_EdittoolStripComboBox.ComboBox.ValueMember = "id";

        }

        private void Employee_NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            pnl_Employee.Show();
            pnl_Start.Hide();
            pnl_Product.Hide();
            
        }

        private void Product_NewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnl_Employee.Hide();
            pnl_Start.Hide();
            pnl_Product.Show();
        }
    }
}
