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
using System.Drawing.Drawing2D;

namespace CashierClasses
{
    public class Receipt
    {
        PrintDocument pdoc = null;

        List<Product> cartItem;
        private string foretagsnamn;
        private string employeeNamn;
        private string adress;

        private int orgnr;
        private int receiptId;
        private int productQty;
        private int telefonNr;

        private DateTime issuedate;

        private double change;
        private double totalPrice;
        private double Vat;
        private double toPay;

        private Boolean cash;
        private Boolean credit;
        private Boolean coupon;

        public string Foretagsnamn { get => foretagsnamn; set => foretagsnamn = value; }
        public string EmployeeNamn { get => employeeNamn; set => employeeNamn = value; }
        public string Adress { get => adress; set => adress = value; }
        public int TelefonNr { get => telefonNr; set => telefonNr = value; }
        public int Orgnr { get => orgnr; set => orgnr = value; }
        public int ReceiptId { get => receiptId; set => receiptId = value; }
        public int ProductQty { get => productQty; set => productQty = value; }
        public int SalesPerson { get; set; }
        public DateTime Issuedate { get => issuedate; set => issuedate = value; }

        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public double Vat1 { get => Vat; set => Vat = value; }
        public double Topay { get; set; }
        public double Change { get; set; }

        public bool Cash { get => cash; set => cash = value; }
        public bool Credit { get => credit; set => credit = value; }
        public bool Coupon { get => coupon; set => coupon = value; }

        public Receipt() { }

        public Receipt(string foretagsnamn, string adress, int telefonNr, string employeeName, int orgnr, int receiptId, int productQty, DateTime issuedate, double totalPrice, double vat1, bool cash, bool credit, bool coupon)
        {
            Foretagsnamn = foretagsnamn;
            Adress = adress;
            TelefonNr = telefonNr;
            EmployeeNamn = employeeName;
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

        public void print(List<Product> cartItems)
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
                Receipt myreceipt = new Receipt();
                myreceipt = this;
                DbAcess db = new DbAcess();

                db.insertIntoReceiptdb(myreceipt);

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
            int Offset1 = 170;


            // quality of the layout.
            //**********************************************************************
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            //**********************************************************************

            
            graphics.DrawString("ICA Nära",
               new Font("Courier New", 20, FontStyle.Bold), 
               new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 30;

            graphics.DrawString("Näverlursgatan 18 " + this.Adress,
                new Font("Courier New", 12),
                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("421 44 Västra Frölunda " + this.Adress,
               new Font("Courier New", 12),
               new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString("Telnr: 031-3562254 " + this.TelefonNr,
                new Font("Courier New", 12),
                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString("Org Nr: " + this.Orgnr,
                new Font("Courier New", 12),
                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            // making space with lines between the rows
            //**********************************************************************
            String underLine = "------------------------------------------";
            Offset = Offset + 20;
            graphics.DrawString(underLine,
                new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            //**********************************************************************

            graphics.DrawString("Receipt No: " + this.ReceiptId,
                     new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString("Receipt Date: " + this.Issuedate,
                     new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString("Cashier name: Roger Federör " + this.EmployeeNamn,
                new Font("Courier New", 12),
                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            // making space with lines between the rows
            //**********************************************************************
            String underline = "------------------------------------------";
            Offset = Offset + 20;
            graphics.DrawString(underLine,
                new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            //**********************************************************************
            foreach (Product p in cartItem)
            {
                Offset = Offset + 20;
                String productName = p.Name;
                String productPrice = (p.Qty * p.Price).ToString();
                String productqty = p.Qty.ToString();
                graphics.DrawString(productName + "                    " + productPrice + "                    ",
                    new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;

            }
            Offset = Offset + 30;
            graphics.DrawString("Total amout to pay:  " + this.Topay,
                new Font("Courier New", 13),
                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 30;

            // making space with lines between the rows
            //**********************************************************************
            underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 3;
            //**********************************************************************
            // making space with lines between the rows
            //**********************************************************************
            underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 3;
            //**********************************************************************

            Offset = Offset + 20;
            graphics.DrawString("Product Qty:   " + this.ProductQty,
                new Font("Courier New", 12),
                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString("Moms: " + this.Vat1,
                new Font("Courier New", 12),
                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString("Total Amount Paid: " + this.TotalPrice,
                new Font("Courier New", 15, FontStyle.Bold),
                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;



            // försökte med det för att få ut om de cash eller credit, eftersom vi har bara cash så går det inte än 
            //graphics.DrawString("Cash:  " + this.totalPrice,
            //   new Font("Courier New", 12),
            //   new SolidBrush(Color.Black), startX, startY + Offset);
            //Offset = Offset + 20;

            if (Cash == true)
            {
                graphics.DrawString("Cash:   " + this.TotalPrice,
                  new Font("Courier New", 12),
                  new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString("Change: " + this.Change,
                 new Font("Courier New", 12),
                 new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
            }
            else if (Credit == true)
            {
                graphics.DrawString("Credit:   " + this.TotalPrice,
                new Font("Courier New", 12),
                new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;

            }

            // making space with lines between the rows
            //**********************************************************************
            underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            //**********************************************************************
            graphics.DrawString("Thank you for your visit",
               new Font("Courier New", 9),
               new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString("Welcome back to ICA Nära!",
               new Font("Courier New", 9),
               new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

        }
        //**************************************************************************************************************************************************
    }
}


