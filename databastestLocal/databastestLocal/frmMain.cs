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

        private void frmMain_Load(object sender, EventArgs e)
        {


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




       
         
     
        private void EmployeeName_Click(object sender, EventArgs e)
        {


        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

////////////////////////////////////////////////////////
        // här gör vi så att bara admin ser knappen!!

        private void btn_adminSys_Click(object sender, EventArgs e)
        {
            //if (.Acesslevel !=3)
            //{
            //    this.Hide();
            //}


        }

        private void btn_bossSys_Click(object sender, EventArgs e)
        {
            //if (User().Acesslevel != 5)
            //{
            //    this.Hide();
            //}

        }

        private void btn_cashierSys_Click_1(object sender, EventArgs e)
        {
            //if (User().Acesslevel != 2)
            //{
            //    this.Hide();
            //}

        }

//////////////////////////////////////////////////////////////







    }
}