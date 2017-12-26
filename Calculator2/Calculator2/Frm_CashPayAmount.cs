using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Frm_CashPayAmount : Form 
    {
        private double qty = 0;
        private string amount;
        private bool totalPaycon;
        private bool qtyAmount;
        private bool isDone = false;
        TextBox totaltextbox;
        ListViewItem myProducts;
        public string Amount { get => amount; set => amount = value; }
        public bool IsDOne { get => isDone; set => isDone = value; }
        public double Qty { get => qty; set => qty = value; }

        
        
       

        

        public Frm_CashPayAmount(TextBox totaltextbox)
        {
            this.totaltextbox = totaltextbox;
            InitializeComponent();
            totalPaycon = true;
            
        }

        public Frm_CashPayAmount(ListViewItem myProducts)
        {
            this.myProducts = myProducts;
            InitializeComponent();
            qtyAmount = true;
            
        }

        private void btn_CashOk_Click(object sender, EventArgs e)
        {

            // om det gäller uträkning och inmatning av total amount sker denna uträkning.
            if (totalPaycon == true)
            {
                amount = txtb_CashAmount.Text;
                totaltextbox.Text = amount;
            }
            // om det gäller uträkning  och inmatning av qty av product sker denna uträkning.
            else if (qtyAmount == true)
            {
                double counter;

                amount = txtb_CashAmount.Text;
                
                myProducts.SubItems[4].Text = amount;

                // nu försvinner instansen av searchedproduct i calc innan denna kan köras.
                // en idé är att använda dataset som en property som kan användas och istället köra en metod för att tilldela variabler för produkter.
                // Calculator calculator = new Calculator();
                // calculator.GetTotalSum();
               


            }

            isDone = true;
            this.Hide();
        }







    }
}
