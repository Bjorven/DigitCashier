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
    public partial class Calculator : Form
    {

        ListViewItem myProducts;
        Barcode barcode;
        RegisterNewCustomer customer;
        Existing_Customer oldcustomer;
        Receipt receipt;
        Product SearchedProduct;
        Frm_CashPayAmount qtyAmount;

        string input = string.Empty;
        string operation = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        double result = 0.0;
        double tal1 = 0;
        double tal2 = 0;
        double myTotal;
        double count;


        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        bool isSearchBtn = false;
        bool hasDiscount;
        bool hasCoupon;
        double Mresult = 1;



        public Calculator()

        {

            InitializeComponent();



        }






        private void NrOneButton_Click_1(object sender, EventArgs e)
        {
            if (isSearchBtn)
            {
                searchTextBox.Text = searchTextBox.Text + "1";
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
                searchTextBox.Text = searchTextBox.Text + "2";
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
                searchTextBox.Text = searchTextBox.Text + "3";
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
                searchTextBox.Text = searchTextBox.Text + "4";
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
                searchTextBox.Text = searchTextBox.Text + "5";
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
                searchTextBox.Text = searchTextBox.Text + "6";
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
                searchTextBox.Text = searchTextBox.Text + "7";
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
                searchTextBox.Text = searchTextBox.Text + "8";
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
                searchTextBox.Text = searchTextBox.Text + "9";
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
                searchTextBox.Text = searchTextBox.Text + "00";
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
                searchTextBox.Text = searchTextBox.Text + "0";
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
            goodsListView.Items.Clear();
            totalTextBox.Clear();
            discountTextBox.Clear();
            couponTextBox.Clear();
            changeTextBox.Clear();
            toPayTextBox.Clear();
            momsTextBox.Clear();


        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            if (isSearchBtn == true)
            {

                qtyAmount = new Frm_CashPayAmount(count);
                qtyAmount.Show();
                
            }
            else
            {
                string operand2 = TimesButton.Text;
                Mresult *= double.Parse(totalTextBox.Text);
                totalTextBox.Text = "";
                operation = "*";
            }

            //if (qtyAmount.Qty > 0)
            //{
            //    myProducts.SubItems.Add(tal2.ToString());
            //}


        }

        private void OkBotton__Click(object sender, EventArgs e)
        {

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


            else if
                (isSearchBtn == true)
            {

                if (searchTextBox.Text != "")
                {

                    CashierClasses.DbAcess db = new CashierClasses.DbAcess();

                    CashierClasses.Product searchProduct = db.getProduct(searchTextBox.Text);

                    myProducts = new ListViewItem(searchProduct.Id.ToString());
                    myProducts.SubItems.Add(searchProduct.Name);
                    myProducts.SubItems.Add(searchProduct.ProductGroup.ToString());
                    myProducts.SubItems.Add(searchProduct.Price.ToString());

                    goodsListView.Items.Add(myProducts);
                    searchTextBox.Clear();
                    SearchedProduct = new Product(searchProduct.Id, searchProduct.Price, searchProduct.Manufacturer, searchProduct.Supplier, searchProduct.ProductGroup, searchProduct.Vat, searchProduct.PricePerKG, searchProduct.PricePerHG, searchProduct.Name);

                }
                else
                {
                    toPayTextBox.Text = "";

                }

                // denna funktion summerar alla tillagda produkter till toTextBox
                foreach (ListViewItem lstitem in goodsListView.Items)
                {

                    myTotal += double.Parse(lstitem.SubItems[3].Text);

                }
                myTotal -= count;
                count = myTotal;
                toPayTextBox.Text = myTotal.ToString();
                momsTextBox.Clear();
                momsTextBox.Text = toPayTextBox.Text;
                momsTextBox.Text = (Convert.ToInt32(momsTextBox.Text) * SearchedProduct.Vat).ToString();

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
            hasDiscount = true;
            if (discountTextBox.Text == "0.00")
                discountTextBox.Clear();
            discountTextBox.Text = discountTextBox.Text + "%";
        }

        private void TotalTextBox_TextChanged(object sender, EventArgs e)
        {
            // Räknar ut change basserat på total minus toPay fälten. denna aktieras först när totalTextBox fylls med något. typ när vi klickar på btn_Cash.
            int x;
            int y;
            int sum;
            Int32.TryParse(totalTextBox.Text, out x);
            Int32.TryParse(toPayTextBox.Text, out y);
            sum = x - y;
            changeTextBox.Text = sum.ToString();
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            isSearchBtn = true;




        }


        DataTable dt = new DataTable();
        private void SearchTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {

            }



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

        private void MomsButton_Click(object sender, EventArgs e)
        {
            if (momsTextBox.Text == "0.00")
                momsTextBox.Clear();
            momsTextBox.Text = toPayTextBox.Text;
            toPayTextBox.Text = (Convert.ToInt32(momsTextBox.Text) * 0.2).ToString();
        }


        //*************************************************************************************************************************************
        // plockar fram en lista på alla produkter vi har i butiken.
        private void GoodsButton_Click(object sender, EventArgs e)
        {

            CashierClasses.DbAcess db = new CashierClasses.DbAcess();
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

        private void IdnameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void GoodsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
           

        }

        private void Calculator_Load_1(object sender, EventArgs e)
        {
       

        }

        private void GoodsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CashButton_Click(object sender, EventArgs e)
        {
            if (hasDiscount == true)
            {

            }
            if (hasCoupon == true)
            {

            }
            Frm_CashPayAmount cash = new Frm_CashPayAmount(totalTextBox);
            cash.Show();

        }








        private void CouponButton_Click(object sender, EventArgs e)
        {
            hasCoupon = true;
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            tal1 = e.KeyValue;
        }
    }
}



