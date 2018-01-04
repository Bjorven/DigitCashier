﻿using System;
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
        Receipt receipt;
        Product SearchedProduct;
        User myUser;
        List<Product> shoppingCart = new List<Product>();
        DbAcess dbReceipt;

        private string checker;
        string input = string.Empty;
        string operation = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        double result = 0.0;
        double tal1 = 0;
        double tal2 = 0;
        double myTotal;
        double count;
        double myRef;


        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        bool isSearchBtn = false;
        bool isCalc = false;
        bool qtyAmount = false;
        bool DeployPayment = false;
        private bool cash = false;
        private bool credit = false;
        bool hasDiscount = false;
        bool hasCoupon = false;
        double Mresult = 1;

        public Calculator(User myUser)

        {
            this.myUser = myUser;
            InitializeComponent();
            InitilizeGroupAndProduct initilize = new InitilizeGroupAndProduct();
            dbReceipt = new DbAcess();
            reciptNrTextBox.Text = dbReceipt.getReceiptid().ToString("0000");
            idnameComboBox.Text = myUser.Fname + " " + myUser.Sname;
            goodsListView.HideSelection = false;
            goodsListView.Focus();
            idNrTextBox.Text = myUser.UserName.ToString();

        }

        public bool Cash { get; set; }
        public bool Credit { get; set; }
        //*************************************************************************************************************************************
        // Siffrorna till kassaprogrammet/Calculator

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
        //*************************************************************************************************************************************

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (isSearchBtn == true)
            {
                if (SearchedProduct.PricePerHG || SearchedProduct.PricePerKG == true)
                {

                    txtb_CashAmount.Clear();
                    pnl_Amount.BringToFront();
                    qtyAmount = true;
                    count = 1;
                }
                else
                {
                    tal2++;
                    myProducts.SubItems[4].Text = tal2.ToString();

                    //denna är bara till för att initiera GetTOtalSum
                    GetTotalSum();
                    // denna för ref till decimal
                    myRef = Convert.ToDouble(myProducts.SubItems[4].Text);
                }
            }
            else
            {
                string operand1 = PlusButton.Text;
                result += double.Parse(totalTextBox.Text);
                totalTextBox.Text = "";
                operation = "+";
            }
            qtyAmount = false;
        }

        public double GetTotalSum()
        {
            myTotal = 0;
            foreach (ListViewItem lstitem in goodsListView.Items)
            {
                double pris = Convert.ToDouble(lstitem.SubItems[3].Text);
                double antal = Convert.ToDouble(lstitem.SubItems[4].Text);

                myTotal += (pris * antal);
            }

            toPayTextBox.Text = myTotal.ToString();
            momsTextBox.Clear();
            momsTextBox.Text = toPayTextBox.Text;
            momsTextBox.Text = (Convert.ToDouble(momsTextBox.Text) * SearchedProduct.Vat).ToString();
            return myTotal;
        }

        private void Btn_subtract_Click(object sender, EventArgs e)
        {
            if (isSearchBtn == true)
            {
                //double pris = Convert.ToDouble(myProducts.SubItems[3].Text);
                //double antal = Convert.ToDouble(myProducts.SubItems[4].Text);
                double total;
                tal2--;
                myProducts.SubItems[4].Text = tal2.ToString();

                // för ref till decimal
                myRef = Convert.ToDouble(myProducts.SubItems[4].Text);

                GetTotalSum();
            }
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
            string operand2 = TimesButton.Text;
            Mresult *= double.Parse(totalTextBox.Text);
            totalTextBox.Text = "";
            operation = "*";
        }
        #region OK BUTTON
        private void OkBotton__Click(object sender, EventArgs e)
        {
            if (isCalc == true)
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

            }

            else if (isSearchBtn == true)

            {

                if (searchTextBox.Text != "")
                {
                    // laddar in produkter i listviewn.
                    // kollar ifall den redan finns i listan genom .name och containskey funktionerna i listvew.
                    // adderar qty ifall den redan finns.
                    CashierClasses.DbAcess db = new CashierClasses.DbAcess();
                    CashierClasses.Product searchProduct = db.GetProduct(searchTextBox.Text);
                    this.SearchedProduct = searchProduct;

                    if (goodsListView.Items.Count > 0)
                    {

                        if (!goodsListView.Items.ContainsKey(searchProduct.Id.ToString()))
                        {
                            #region add new product to listview
                            myProducts = new ListViewItem(searchProduct.Id.ToString());
                            myProducts.Name = searchProduct.Id.ToString();
                            myProducts.SubItems.Add(searchProduct.Name);
                            myProducts.SubItems.Add(searchProduct.ProductGroupname.ToString());
                            myProducts.SubItems.Add(searchProduct.Price.ToString());
                            tal2 = 1;
                            myProducts.SubItems.Add(tal2.ToString());

                            goodsListView.Items.Add(myProducts);
                            searchTextBox.Clear();
                            // Vi gör detta för att kunna ha en ref till senare om värdet skulle bli decimal.
                            myRef = Convert.ToDouble(myProducts.SubItems[4].Text);

                            shoppingCart.Add(new Product()
                            {

                                Id = SearchedProduct.Id,
                                InStock = SearchedProduct.InStock,
                                Manufacturer = SearchedProduct.Manufacturer,
                                Name = SearchedProduct.Name,
                                Price = SearchedProduct.Price,
                                PricePerHG = SearchedProduct.PricePerHG,
                                PricePerKG = SearchedProduct.PricePerKG,
                                ProductGroup = SearchedProduct.ProductGroup,
                                ProductGroupId = SearchedProduct.ProductGroupId,
                                ProductGroupname = SearchedProduct.ProductGroupname,
                                Qty = tal2,
                                Supplier = SearchedProduct.Supplier,
                                Vat = SearchedProduct.Vat,
                            });
                            #endregion

                        }

                        else
                        {
                            #region qty++


                            // för ref till decimal
                            myRef = Convert.ToDouble(myProducts.SubItems[4].Text);
                            searchTextBox.Clear();

                            var index = shoppingCart.FindIndex(c => c.Id == searchProduct.Id);
                            tal2++;
                            shoppingCart[index] = new Product
                            {

                                Id = SearchedProduct.Id,
                                InStock = SearchedProduct.InStock,
                                Manufacturer = SearchedProduct.Manufacturer,
                                Name = SearchedProduct.Name,
                                Price = SearchedProduct.Price,
                                PricePerHG = SearchedProduct.PricePerHG,
                                PricePerKG = SearchedProduct.PricePerKG,
                                ProductGroup = SearchedProduct.ProductGroup,
                                ProductGroupId = SearchedProduct.ProductGroupId,
                                ProductGroupname = SearchedProduct.ProductGroupname,
                                Qty = tal2,
                                Supplier = SearchedProduct.Supplier,
                                Vat = SearchedProduct.Vat,
                            };

                            myProducts.SubItems[4].Text = tal2.ToString();

                            #endregion

                        }

                    }
                    else if (goodsListView.Items.Count < 1)
                    {
                        #region add new product to listview
                        myProducts = new ListViewItem(searchProduct.Id.ToString());
                        myProducts.Name = searchProduct.Id.ToString();
                        myProducts.SubItems.Add(searchProduct.Name);
                        myProducts.SubItems.Add(searchProduct.ProductGroupname.ToString());
                        myProducts.SubItems.Add(searchProduct.Price.ToString());
                        tal2 = 1;
                        myProducts.SubItems.Add(tal2.ToString());

                        goodsListView.Items.Add(myProducts);
                        searchTextBox.Clear();
                        // Vi gör detta för att kunna ha en ref till senare om värdet skulle bli decimal.
                        myRef = Convert.ToDouble(myProducts.SubItems[4].Text);

                        shoppingCart.Add(new Product()
                        {

                            Id = SearchedProduct.Id,
                            InStock = SearchedProduct.InStock,
                            Manufacturer = SearchedProduct.Manufacturer,
                            Name = SearchedProduct.Name,
                            Price = SearchedProduct.Price,
                            PricePerHG = SearchedProduct.PricePerHG,
                            PricePerKG = SearchedProduct.PricePerKG,
                            ProductGroup = SearchedProduct.ProductGroup,
                            ProductGroupId = SearchedProduct.ProductGroupId,
                            ProductGroupname = SearchedProduct.ProductGroupname,
                            Qty = tal2,
                            Supplier = SearchedProduct.Supplier,
                            Vat = SearchedProduct.Vat,
                        });
                        #endregion

                    }




                    //SearchedProduct = new Product(searchProduct.Id, searchProduct.Price, searchProduct.Manufacturer, searchProduct.Supplier, searchProduct.ProductGroup, searchProduct.Vat, searchProduct.PricePerKG, searchProduct.PricePerHG, searchProduct.Name);
                    if (searchProduct.PricePerHG || searchProduct.PricePerKG == true)
                    {
                        qtyAmount = true;
                        pnl_Amount.BringToFront();
                    }

                    // Detta ska bli en funktion för att kunna ladda in två av samma vara och bara addera en qty på en och samma listview-rad.
                    //foreach (ListViewItem i in goodsListView.Items)
                    //{
                    //    if (searchProduct.Id == Convert.ToInt16(i.SubItems[0].Text))
                    //    {
                    //        double qtyRef;
                    //        qtyRef = Convert.ToDouble(i.SubItems[4].Text);
                    //        qtyRef++;
                    //        i.SubItems[4].Text = qtyRef.ToString();
                    //    }
                    //}

                    else
                    {
                        toPayTextBox.Text = "";

                    }
                }

                // denna funktion summerar alla tillagda produkter till toTextBox
                GetTotalSum();

            }
            // här skapas en lista över alla produkter i varukorgen.
            #region Shoppingcart list


            #endregion
        }


        #endregion

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
            if (DeployPayment == true)
            {
                double sum;
                double.TryParse(totalTextBox.Text, out double x);
                double.TryParse(toPayTextBox.Text, out double y);
                sum = x - y;
                changeTextBox.Text = sum.ToString();
            }
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
            isCalc = false;
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

        private void BarcodeBotton_Click(object sender, EventArgs e)
        {
            barcode = new Barcode();
            barcode.Show();
        }

        // Med denna kan man nu klicka i listViewn och selecta en rad och ändra tex qty.
        private void GoodsListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (ListViewItem item in goodsListView.SelectedItems)
            {
                myProducts = item;
                //denna raden göra så att vi sparar upp den aktuella radens qty och kan därmed ändra korrekt.
                tal2 = Convert.ToDouble(myProducts.SubItems[4].Text);
            }
        }

        private void Btn_AmountOk_Click(object sender, EventArgs e)
        {
            if (DeployPayment == true)
            {
                totalTextBox.Text = txtb_CashAmount.Text;
                CashierClasses.Receipt newReceipt = new CashierClasses.Receipt
                {
                    Foretagsnamn = "Ica Nära",
                    Orgnr = 1337,
                    ReceiptId = Convert.ToInt16(reciptNrTextBox.Text),
                    Issuedate = DateTime.Now,
                    TotalPrice = Convert.ToDouble(totalTextBox.Text),
                    Topay = Convert.ToDouble(toPayTextBox.Text),
                    Change = Convert.ToDouble(changeTextBox.Text),
                    Vat1 = Convert.ToDouble(momsTextBox.Text),
                    Cash = cash,
                    Coupon = hasCoupon,
                    Credit = credit,
                    ProductQty = shoppingCart.Count,
                };
                newReceipt.print(shoppingCart);

                //DbAcess db = new DbAcess();
                //db.insertIntoDatabase(shoppingCart, reciptNrTextBox.Text);

                // så att man inte skriver ut varjegång man klickar någonstans.
                DeployPayment = false;
            }
            else if (qtyAmount == true)
            {
                myProducts.SubItems[4].Text = txtb_CashAmount.Text;
                qtyAmount = false;
            }

            GetTotalSum();
            pnl_Amount.SendToBack();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

            toPayTextBox.Text = myTotal.ToString();
            momsTextBox.Clear();
            momsTextBox.Text = toPayTextBox.Text;
            momsTextBox.Text = (Convert.ToDouble(momsTextBox.Text) * SearchedProduct.Vat).ToString();

        }

        private void CouponButton_Click_1(object sender, EventArgs e)
        {
            hasCoupon = true;
        }

        private void CashButton_Click_1(object sender, EventArgs e)
        {
            if (hasDiscount == true)
            {

            }
            if (hasCoupon == true)
            {

            }

            txtb_CashAmount.Clear();
            pnl_Amount.BringToFront();
            DeployPayment = true;
            Credit = true;


            //// Här skapar vi ett datatable för att skicka upp de köpta produkterna till databasen.
            //DataTable myPurchase = new DataTable();
            //foreach (ListViewItem item in goodsListView.Items)
            //{
            //    myPurchase.Columns.Add(item.ToString());
            //    foreach (var it in item.SubItems)
            //    {
            //        myPurchase.Rows.Add(it.ToString());
            //    }
            //    // Om vi använder skickar upp detta samtidigt här som där under knyter vi samman de köpta produkterna med kvittoInformationen.

            //}
            //myPurchase.Columns.Add(reciptNrTextBox.Text);
            //myPurchase.Rows.Add(reciptNrTextBox.Text);
            //DbAcess db = new DbAcess();

            //// Här skapar vi ett datatable för att skicka upp informationen om köpet
            //DataTable myReceiptInfo = new DataTable();
            //// Denna knyter samman de köpta produkterna till informationen här.
            //myReceiptInfo.Columns.Add(reciptNrTextBox.Text);
            //myReceiptInfo.Columns.Add(dateTimePicker1.Text);
            //myReceiptInfo.Columns.Add(totalTextBox.Text);
            //myReceiptInfo.Columns.Add(changeTextBox.Text);
            //myReceiptInfo.Columns.Add(couponTextBox.Text);
            //myReceiptInfo.Columns.Add(discountTextBox.Text);
            //myReceiptInfo.Columns.Add(momsTextBox.Text);
            //myReceiptInfo.Columns.Add(toPayTextBox.Text);
            //myReceiptInfo.Columns.Add(idNrTextBox.Text);
            //db.ExportSqlData(myReceiptInfo);


            //Frm_CashPayAmount cash = new Frm_CashPayAmount(totalTextBox);
            //cash.Show();

        }

        // denna är för att kunna radera valda varor från varolistan
        private void DeletRowbotton(object sender, EventArgs e)
        {
            for (int i = goodsListView.Items.Count - 1; i >= 0; i--)
            {
                if (goodsListView.Items[i].Selected)
                {
                    goodsListView.Items[i].Remove();
                }
                GetTotalSum();
            }
        }

        private void ReciptNrTextBox_TextChanged(object sender, EventArgs e)
        {
            // för söker hitta rätt kod för att generera unik id nr till kvittot 
            //string Row = "";
            //for (int i = 1; i <= 5; i++)
            //{
            //    Row += "st" + i.ToString("000") + System.Environment.NewLine;
            //}
            //label1.Text = Row;
        }

        private void CardButton_Click(object sender, EventArgs e)
        {
            Credit = true;
        }
    }
}







