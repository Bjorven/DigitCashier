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

using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.Common;

namespace Calculator2
{
    public partial class Receipt : Form
    {
        private BindingSource bindingSource1 = new BindingSource();

        public Receipt()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listV_searchResult.Items.Clear();
            listV_searchResult.Items.Clear();
            listV_searchResult.Items.Clear();
        }

        private void SearchItemButton_Click(object sender, EventArgs e)
        {
            pnl_Search.BringToFront();



        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Printing receipt");

            List<Reeipt> ReceiptList = new List<Reeipt>();
            ReceiptList = (from DataRow dr in dt.Rows
                           select new Reeipt()
                           {
                               //Foretagsnamn = dr[""].ToString(),
                               //Orgnr = Convert.ToInt32(dr[]),
                               //ReceiptId = Convert.ToInt32(dr["id"]),
                               //ProductQty = Convert.ToInt32(dt.Rows.Count),
                               //Issuedate = Convert.ToDateTime(dr["receiptDate"]),
                               //ProductWeight = Convert.ToDecimal(dr[]),
                               //TotalPrice = Convert.ToDouble(dr[]),
                               //Vat1 = Convert.ToDouble(dr[]),
                               //SumOfItems = Convert.ToDouble(dr[]),
                               //Cash = Convert.ToBoolean(dr[]),
                               //Credit = Convert.ToBoolean(dr[]),
                               //Coupon = Convert.ToBoolean(dr[]),
                               
                           }).ToList();

            
        }
        //***************************************************************************************************************************************************
        //***************************************************************************************************************************************************
        DataTable dt = new DataTable();
        private void btn_SubmitSearch_Click(object sender, EventArgs e)
        {

            if (txtb_SearchBar.Text == "")
            {
                MessageBox.Show("Enter Search parameter");
            }
            try
            {
                DbAccess db = new DbAccess();

                dG_List.AutoGenerateColumns = true;
                DataTable dt = db.getReceipt(txtb_SearchBar.Text);
                bindingSource1.DataSource = dt;
                dG_List.DataSource = bindingSource1;

                dG_List.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                dG_List.BorderStyle = BorderStyle.Fixed3D;

                this.dt = dt;
                pnl_Search.SendToBack();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //***************************************************************************************************************************************************
            //***************************************************************************************************************************************************
        }

        private void btn_CancelSearch_Click(object sender, EventArgs e)
        {
            pnl_Search.SendToBack();
        }

        private void listV_searchResult_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
