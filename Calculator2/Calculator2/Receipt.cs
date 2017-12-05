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
using System.Data;
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

        private void addItemButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchItemButton_Click(object sender, EventArgs e)
        {
            pnl_Search.BringToFront();



        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing receipt");
        }

        private void btn_SubmitSearch_Click(object sender, EventArgs e)
        {

            if (txtb_SearchBar.Text == "")
            {
                MessageBox.Show("Enter Search parameter");
            }
            try
            {
                Dbaccess db = new Dbaccess();
                //DataTable dt = db.getReceipt(txtb_SearchBar.Text);

                //listV_searchResult.Items.Clear();



                //dG_List.Dock = DockStyle.Fill;
                dG_List.AutoGenerateColumns = true;
                bindingSource1.DataSource = db.getReceipt(txtb_SearchBar.Text);
                dG_List.DataSource = bindingSource1;

                dG_List.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                dG_List.BorderStyle = BorderStyle.Fixed3D;



                //{
                //    ListViewItem item = new ListViewItem(dt.Rows[i][0].ToString());
                //    item.SubItems.Add(dt.Rows[i][1].ToString());
                //    item.SubItems.Add(dt.Rows[i][2].ToString());
                //    item.SubItems.Add(dt.Rows[i][3].ToString());
                //    item.SubItems.Add(dt.Rows[i][4].ToString());
                //    item.SubItems.Add(dt.Rows[i][5].ToString());
                //    item.SubItems.Add(dt.Rows[i][6].ToString());
                //    item.SubItems.Add(dt.Rows[i][7].ToString());
                //    item.SubItems.Add(dt.Rows[i][8].ToString());
                //    item.SubItems.Add(dt.Rows[i][9].ToString());
                //
                //    listV_searchResult.Items.Add(item);
      
            














                pnl_Search.SendToBack();

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
