﻿using System;
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
        //här får ut variablarna till ett objekt vi kan använda i resten av formappen
        private User user;
        // --
        public frmMain(User user)
        {
            InitializeComponent();
            //--
            this.user = user;
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
            // vi kollar vilken roll som User.user har och visar respektiv knapp.
            switch (this.user.RoleId)
            {
                case 2:
                    btn_admin.Hide();
                    btn_boss.Hide();
                    break;
                case 3:
                    btn_cashier.Hide();
                    btn_boss.Hide();
                    break;
                case 5:
                    btn_cashier.Hide();
                    btn_admin.Hide();
                    break;
                default:
                    break;
            }
        }
    }
}