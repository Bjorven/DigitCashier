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
using CashierClasses;
using System.Globalization;

namespace Calculator2
{
    public partial class Receipt : Form
    {
        private double sum;
        private int qty;

        private BindingSource bindingSource1 = new BindingSource();

        public Receipt()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dG_List.Columns.Clear();

        }

        private void SearchItemButton_Click(object sender, EventArgs e)
        {
            pnl_Search.BringToFront();



        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Printing receipt");

            //List<CashierClasses.Receipt> ReceiptList = new List<CashierClasses.Receipt>();
            //ReceiptList = (from DataRow dr in dt.Rows
            //               select new CashierClasses.Receipt()
            //               {
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

            //               }).ToList();





        }
        //***************************************************************************************************************************************************
        
        private void btn_SubmitSearch_Click(object sender, EventArgs e)
        {

            if (txtb_SearchBar.Text == "")
            {
                MessageBox.Show("Enter Search parameter");
            }
            try
            {
                CashierClasses.DbAcess db = new CashierClasses.DbAcess();

                dG_List.AutoGenerateColumns = true;
                DataTable dt = db.getReceipt(txtb_SearchBar.Text);
                bindingSource1.DataSource = dt;
                dG_List.DataSource = bindingSource1;

                dG_List.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                dG_List.BorderStyle = BorderStyle.Fixed3D;


                DataSet ds = db.getTotalPriceAndQty(txtb_SearchBar.Text);


                txtb_TotalPrice.Text = ds.Tables[0].Rows[0][0].ToString();

                //CashierClasses.Receipt receipt = new CashierClasses.Receipt(
                    //dt.Rows[0]["Cname"].ToString(),
                    //Convert.ToInt16(dt.Rows[0]["CorgNr"].ToString()),
                    //Convert.ToInt16(dt.Rows[0]["receiptId"].ToString()),
                    //Convert.ToInt16(ds.Tables[0].Rows[0][1],
                    //Convert.ToDateTime(dt.Rows[0]["receiptDate"].ToString()),





                    //);

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

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}
