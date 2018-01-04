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

namespace Calculator2
{
    public partial class GoodsListGridView : Form
    {
        private BindingSource goodsGridBinding = new BindingSource();

        public GoodsListGridView(DataTable dtable)
        {
            this.Controls.Add(GoodsDataGridView);
            InitializeComponent();

            GoodsDataGridView.AutoGenerateColumns = true;
            
            //DataBindings dataBindings1 = new DataBindings();

            goodsGridBinding.DataSource = dtable;
            GoodsDataGridView.DataSource = goodsGridBinding;

            GoodsDataGridView.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            GoodsDataGridView.BorderStyle = BorderStyle.Fixed3D;
        }

       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GoodsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GoodsDataGridView.Rows[e.RowIndex].ReadOnly = true;
            if (GoodsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                GoodsDataGridView.Rows[e.RowIndex].ReadOnly = false;
            }
        }
    }
}
