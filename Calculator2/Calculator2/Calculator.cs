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
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void NrOneButton_Click_1(object sender, EventArgs e)
        {
            if (totalTextBox.Text == "0.00")
                totalTextBox.Clear();
            totalTextBox.Text = totalTextBox.Text + "1";
        }

        private void NrTwoButton_Click_1(object sender, EventArgs e)
        {
            if (totalTextBox.Text == "0.00")
                totalTextBox.Clear();
            totalTextBox.Text = totalTextBox.Text + "2";
        }

        private void NrThreeButton_Click(object sender, EventArgs e)
        {
            if (totalTextBox.Text == "0.00")
                totalTextBox.Clear();
            totalTextBox.Text = totalTextBox.Text + "3";
        }

        private void nrFourButton_Click_1(object sender, EventArgs e)
        {
            if (totalTextBox.Text == "0.00")
                totalTextBox.Clear();
            totalTextBox.Text = totalTextBox.Text + "4";
        }

        private void nrFiveButton_Click_1(object sender, EventArgs e)
        {
            if (totalTextBox.Text == "0.00")
                totalTextBox.Clear();
            totalTextBox.Text = totalTextBox.Text + "5";
        }

        private void NrSixButton_Click_1(object sender, EventArgs e)
        {
            if (totalTextBox.Text == "0.00")
                totalTextBox.Clear();
            totalTextBox.Text = totalTextBox.Text + "6";
        }

        private void NrSevenButton_Click_1(object sender, EventArgs e)
        {
            if (totalTextBox.Text == "0.00")
                totalTextBox.Clear();
            totalTextBox.Text = totalTextBox.Text + "7";
        }

        private void NrEightButton_Click_1(object sender, EventArgs e)
        { 
            if (totalTextBox.Text == "0.00")
                totalTextBox.Clear();
            totalTextBox.Text = totalTextBox.Text + "8";
        }

        private void NrNineButton_Click_1(object sender, EventArgs e)
        {
            if (totalTextBox.Text == "0.00")
                totalTextBox.Clear();
            totalTextBox.Text = totalTextBox.Text + "9";
        }

        private void PlusButton_Click_1(object sender, EventArgs e)
        {
            string operand1 = PlusButton.Text;
            result += double.Parse(totalTextBox.Text);
            totalTextBox.Text = "";
            operation = "+";
            
        }

        private void CommaButton_Click_1(object sender, EventArgs e)
        {
            if (totalTextBox.Text == "0.00")
                totalTextBox.Clear();
            totalTextBox.Text = totalTextBox.Text + ",";
        }

        private void DoubleZeroButton_Click_1(object sender, EventArgs e)
        {
            if (totalTextBox.Text == "0.00")
                totalTextBox.Clear();
            totalTextBox.Text = totalTextBox.Text + "00";
        }

        private void ZeroButton_Click_1(object sender, EventArgs e)
        {
            if (totalTextBox.Text == "0.00")
                totalTextBox.Clear();
            totalTextBox.Text = totalTextBox.Text + "0";
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            
                totalTextBox.Clear();
                discountTextBox.Clear();    

              
        }

        private void TimesButton_Click_1(object sender, EventArgs e)
        {
            string operand1 = PlusButton.Text;
            result = double.Parse(totalTextBox.Text);
            totalTextBox.Text = totalTextBox.Text + "*";
        }
        private void OkBotton_Click(object sender, EventArgs e)
        {
            ////tal1 = ;
            ////tal2 = ;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == "+")
            {
                result += result;
                totalTextBox.Text = result.ToString();
            }
            else if (operation == "*")
            {
                result = num1 * num2;
                totalTextBox.Text = result.ToString();
            }
            else
            {
                totalTextBox.Text = "";
            }
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

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (discountTextBox.Text == "0.00")
                discountTextBox.Clear();
            
        }

        private void DiscountButton_Click(object sender, EventArgs e)
        {
            if (discountTextBox.Text == "0.00")
                discountTextBox.Clear();
            discountTextBox.Text = discountTextBox.Text + "%";
        }

        private void totalTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void twentyPercentButton_Click(object sender, EventArgs e)
        {
            if (discountTextBox.Text == "0.00")
                discountTextBox.Clear();
            discountTextBox.Text = discountTextBox.Text + "20%";
        }

        private void tenPercentButton_Click(object sender, EventArgs e)
        {
            if (discountTextBox.Text == "0.00")
                discountTextBox.Clear();
            discountTextBox.Text = discountTextBox.Text + "10%";
        }

        private void thertyPercentButton_Click(object sender, EventArgs e)
        {
            if (discountTextBox.Text == "0.00")
                discountTextBox.Clear();
            discountTextBox.Text = discountTextBox.Text + "30%";
        }

        private void nrSearchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Search")
                searchTextBox.Clear();
            searchTextBox.Text = searchTextBox.Text + "#";
        }

        private void searchTextBox_TextChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}
   
    
