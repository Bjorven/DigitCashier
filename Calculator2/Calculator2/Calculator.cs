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
    public partial class Calculator : Form
    {


        string input = string.Empty;
        string operation = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        double result = 0.0;
        double tal1 = 0;
        double tal2 = 0;
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        bool isSearchBtn = false;
        double Mresult = 1;
        public Calculator()

        {
            InitializeComponent();

        }

        Barcode barcode;
        RegisterNewCustomer customer;
        Existing_Customer oldcustomer;
        Receipt receipt;


        private void NrOneButton_Click_1(object sender, EventArgs e)
        {
            if (isSearchBtn)
            {
                searchTextBox.Text = "1";
            }
            else
            {
                if (totalTextBox.Text == "0.00")
                    totalTextBox.Clear();
                totalTextBox.Text = totalTextBox.Text + "1";
            }

        }

        private void NrTwoButton_Click_1(object sender, EventArgs e)
        {
            if (isSearchBtn)
            {
                searchTextBox.Text = "2";
            }
            else
            {
                if (totalTextBox.Text == "0.00")
                    totalTextBox.Clear();
                totalTextBox.Text = totalTextBox.Text + "2";
            }
        }

        private void NrThreeButton_Click(object sender, EventArgs e)
        {
            if (isSearchBtn)
            {
                searchTextBox.Text = "3";
            }
            else
            {
                if (totalTextBox.Text == "0.00")
                    totalTextBox.Clear();
                totalTextBox.Text = totalTextBox.Text + "3";
            }
        }

        private void NrFourButton_Click_1(object sender, EventArgs e)
        {
            if (isSearchBtn)
            {
                searchTextBox.Text = "4";
            }
            else
            {
                if (totalTextBox.Text == "0.00")
                    totalTextBox.Clear();
                totalTextBox.Text = totalTextBox.Text + "4";
            }
        }

        private void NrFiveButton_Click(object sender, EventArgs e)
        {
            if (isSearchBtn)
            {
                searchTextBox.Text = "5";
            }
            else
            {
                if (totalTextBox.Text == "0.00")
                    totalTextBox.Clear();
                totalTextBox.Text = totalTextBox.Text + "5";
            }
        }

        private void NrSixButton_Click(object sender, EventArgs e)
        {
            if (isSearchBtn)
            {
                searchTextBox.Text = "6";
            }
            else
            {
                if (totalTextBox.Text == "0.00")
                    totalTextBox.Clear();
                totalTextBox.Text = totalTextBox.Text + "6";
            }
        }

        private void NrSevenButton_Click(object sender, EventArgs e)
        {
            if (isSearchBtn)
            {
                searchTextBox.Text = "7";
            }
            else
            {
                if (totalTextBox.Text == "0.00")
                    totalTextBox.Clear();
                totalTextBox.Text = totalTextBox.Text + "7";
            }
        }

        private void NrEightButton_Click(object sender, EventArgs e)
        {
            if (isSearchBtn)
            {
                searchTextBox.Text = "8";
            }
            else
            {
                if (totalTextBox.Text == "0.00")
                    totalTextBox.Clear();
                totalTextBox.Text = totalTextBox.Text + "8";
            }
        }

        private void NrNineButton_Click(object sender, EventArgs e)
        {
            if (isSearchBtn)
            {
                searchTextBox.Text = "9";
            }
            else
            {
                if (totalTextBox.Text == "0.00")
                    totalTextBox.Clear();
                totalTextBox.Text = totalTextBox.Text + "9";
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            string operand1 = PlusButton.Text;
            result += double.Parse(totalTextBox.Text);
            totalTextBox.Text = "";
            operation = "+";

        }

        private void CommaButton_Click(object sender, EventArgs e)
        {
            if (totalTextBox.Text == "0.00")
                totalTextBox.Clear();
            totalTextBox.Text = totalTextBox.Text + ",";
        }

        private void DoubleZeroButton_Click(object sender, EventArgs e)
        {
            if (isSearchBtn)
            {
                searchTextBox.Text = "00";
            }
            else
            {
                if (totalTextBox.Text == "0.00")
                    totalTextBox.Clear();
                totalTextBox.Text = totalTextBox.Text + "00";
            }
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (isSearchBtn)
            {
                searchTextBox.Text = "0";
            }
            else
            {
                if (totalTextBox.Text == "0.00")
                    totalTextBox.Clear();
                totalTextBox.Text = totalTextBox.Text + "0";
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            cashTextBox.Clear();
            totalTextBox.Clear();
            discountTextBox.Clear();
            cardTextBox.Clear();
            couponTextBox.Clear();
            changeTextBox.Clear();
            toPayTextBox.Clear();
            momsTextBox.Clear();


        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            string operand2 = TimesButton.Text;
            Mresult *= double.Parse(totalTextBox.Text);
            totalTextBox.Text = "";
            operation = "*";
        }
        private void OkBotton__Click(object sender, EventArgs e)
        {
            //testing a method
            //tal1 = ;
            //tal2 = ;
            //double num1, num2;
            //double.TryParse(operand1, out num1);
            //double.TryParse(operand2, out num2);

            if (operation == "+")
            {
                result += result;
                totalTextBox.Text = result.ToString();
            }
            else if (operation == "*")
            {
                Mresult = Mresult * Convert.ToDouble(totalTextBox.Text);
                totalTextBox.Text = Mresult.ToString();
            }
            else
            {
                totalTextBox.Text = "";

            }

            //testing a method
            //switch (operationPerformed)
            //{
            //    case "+":
            //        totalTextBox.Text = (resultValue + Double.Parse(totalTextBox.Text)).ToString();
            //        break;
            //    case "*":
            //        totalTextBox.Text = (resultValue * Double.Parse(totalTextBox.Text)).ToString();
            //        break;

            //    default:
            //        break;
            //}
            //resultValue = Double.Parse(totalTextBox.Text);



        }

        private void DiscountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (discountTextBox.Text == "0.00")
                discountTextBox.Clear();

        }

        private void DiscountButton__Click(object sender, EventArgs e)
        {
            if (discountTextBox.Text == "0.00")
                discountTextBox.Clear();
            discountTextBox.Text = discountTextBox.Text + "%";
        }

        private void TotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TwentyPercentButton_Click(object sender, EventArgs e)
        {
            if (discountTextBox.Text == "0.00")
                discountTextBox.Clear();
            discountTextBox.Text = discountTextBox.Text + "20%";
            toPayTextBox.Text = (Convert.ToInt32(totalTextBox.Text) * 0.8).ToString();
        }

        private void TenPercentButton_Click(object sender, EventArgs e)
        {
            if (discountTextBox.Text == "0.00")
                discountTextBox.Clear();
            discountTextBox.Text = discountTextBox.Text + "10%";
            toPayTextBox.Text = (Convert.ToInt32(totalTextBox.Text) * 0.9).ToString();
        }

        private void ThertyPercentButton_Click(object sender, EventArgs e)
        {
            if (discountTextBox.Text == "0.00")
                discountTextBox.Clear();
            discountTextBox.Text = discountTextBox.Text + "30%";
            toPayTextBox.Text = (Convert.ToInt32(totalTextBox.Text) * 0.7).ToString();
        }

        private void NrSearchButton_Click(object sender, EventArgs e)
        {

            if (searchTextBox.Text == "Search")
                searchTextBox.Clear();
            searchTextBox.Text = searchTextBox.Text + "#";
            isSearchBtn = true;

        }

        private void SearchTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToPayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearBotton_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
        }

        private void momsButton_Click(object sender, EventArgs e)
        {
            if (momsTextBox.Text == "0.00")
                momsTextBox.Clear();
            momsTextBox.Text = toPayTextBox.Text;
            toPayTextBox.Text = (Convert.ToInt32(momsTextBox.Text) * 0.2).ToString();
        }
       
        
        //*************************************************************************************************************************************

        private void GoodsButton_Click(object sender, EventArgs e)
        {

            Dbaccess db = new Dbaccess();
            DataSet ds = db.GetGoodsList();
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No items found");
            }
            try
            {
                DataTable dtable = ds.Tables[0];
                GoodsListGridView gLGV = new GoodsListGridView(dtable);
                gLGV.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //*************************************************************************************************************************************


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Calculator.ActiveForm.Close();

        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {

            Receipt receipt = new Receipt();
            receipt.Show();

        }

        private void idnameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListViewItem minaFilmer;


            //livFilmer.Items.Clear();
            //DataSet ds = new DataSet();
            //ds = Databas.ListaFilmer();//     .ListaFilmer();

            //int antal = ds.Tables[0].Rows.Count;

            //for (int i = 0; i < antal; i++)
            //{
            //    minaFilmer = new ListViewItem(Convert.ToString((ds.Tables[0].Rows[i][0])));
            //    minaFilmer.SubItems.Add(Convert.ToString((ds.Tables[0].Rows[i][1])));

            //    livFilmer.Items.Add(minaFilmer);
            //}
            //foreach(DataRow dr in ds.Tables[0].Rows)
            //{
            //    chk3.Items.Add(dr[0]);
            //    lsb3.Items.Add(dr[0]);
            //    cmb3.Items.Add(dr[0]);
            //    txt3.Text = txt3.Text + dr[0] + Environment.NewLine;


        }

        private void BarcodeBotton_Click(object sender, EventArgs e)
        {
            barcode = new Barcode();
            barcode.Show();
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            customer = new RegisterNewCustomer();
            customer.Show();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            oldcustomer = new Existing_Customer();
            oldcustomer.Show();
        }

        private void goodsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dbaccess db = new Dbaccess();
            //DataSet ds = db.GetGoodsList();

            //foreach (DataRow r in ds.Tables[0].Rows)
            //{
            //    if (r["name"].ToString() == goodsListBox.SelectedValue)
            //        label1.Text = r["id"].ToString();
            //}

        }

        private void Calculator_Load(object sender, EventArgs e)
        {


        }
    }
}



