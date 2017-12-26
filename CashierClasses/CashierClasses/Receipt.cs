using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using System.Data;

namespace CashierClasses
{
    public class Receipt
    {
        PrintDocument pdoc = null;

        ListView cartItem;
        private string foretagsnamn;

        private int orgnr;
        private int receiptId;
        private int productQty;

        private DateTime issuedate;

        private decimal productWeight;

        private double totalPrice;
        private double Vat;
       

        private Boolean cash;
        private Boolean credit;
        private Boolean coupon;

        public string Foretagsnamn { get => foretagsnamn; set => foretagsnamn = value; }
        public int Orgnr { get => orgnr; set => orgnr = value; }
        public int ReceiptId { get => receiptId; set => receiptId = value; }
        public int ProductQty { get => productQty; set => productQty = value; }
        public DateTime Issuedate { get => issuedate; set => issuedate = value; }
        public decimal ProductWeight { get => productWeight; set => productWeight = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public double Vat1 { get => Vat; set => Vat = value; }
        
        public bool Cash { get => cash; set => cash = value; }
        public bool Credit { get => credit; set => credit = value; }
        public bool Coupon { get => coupon; set => coupon = value; }

        public Receipt() { }

        public Receipt(string foretagsnamn, int orgnr, int receiptId, int productQty, DateTime issuedate, decimal productWeight, double totalPrice, double vat1, bool cash, bool credit, bool coupon)
        {
            Foretagsnamn = foretagsnamn;
            Orgnr = orgnr;
            ReceiptId = receiptId;
            ProductQty = productQty;
            Issuedate = issuedate;
            ProductWeight = productWeight;
            TotalPrice = totalPrice;
            Vat1 = vat1;
            Cash = cash;
            Credit = credit;
            Coupon = coupon;
        }

        public Receipt (string foretagsnamn, int orgnr, int receiptId, int productQty, DateTime issuedate, double totalPrice, double vat1, bool cash, bool credit, bool coupon)
        {
            Foretagsnamn = foretagsnamn;
            Orgnr = orgnr;
            ReceiptId = receiptId;
            ProductQty = productQty;
            Issuedate = issuedate;
            TotalPrice = totalPrice;
            Vat1 = vat1;
            Cash = cash;
            Credit = credit;
            Coupon = coupon;


        }

        //*************************************************************************************************************************************************


        



        public void print(ListView cartItems)
        {
            this.cartItem = cartItems;
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);


            PaperSize psize = new PaperSize("Custom", 100, 200);
            //ps.DefaultPageSettings.PaperSize = psize;

            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            //pdoc.DefaultPageSettings.PaperSize.Height =320;
            pdoc.DefaultPageSettings.PaperSize.Height = 820;

            pdoc.DefaultPageSettings.PaperSize.Width = 520;

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = pdoc;
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }

        }

        //************************************************************************************************************************************************

        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 55;
            int Offset = 40;
            graphics.DrawString("Welcome back to ICA Nära", new Font("Courier New", 14),
                                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Receipt No:" + this.ReceiptId,
                     new Font("Courier New", 14),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Receipt Date :" + this.Issuedate,
                     new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            String underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);


            foreach (ListViewItem i in cartItem.Items) {
                Offset = Offset + 20;
                String productName = i.SubItems[1].Text;
                String productPrice = i.SubItems[3].Text;
                graphics.DrawString(productName + "               " + productPrice,
                    new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + Offset);
            }


            Offset = Offset + 20;
            String Grosstotal = "Total Amount to Paid = " + this.TotalPrice;

            Offset = Offset + 20;
            underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString(Grosstotal, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

        }
        //**************************************************************************************************************************************************
    }
}

