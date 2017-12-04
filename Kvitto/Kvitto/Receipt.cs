using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvitto
{
    class Receipt
    {
        private int receiptnr;
        private int salesPerson;
        private int qty;

        private DateTime receiptDate;

        private string product;
        private string productGroup;

        public int Receiptnr { get => receiptnr; set => receiptnr = value; }
        public int SalesPerson { get => salesPerson; set => salesPerson = value; }
        public int Qty { get => qty; set => qty = value; }
        public DateTime ReceiptDate { get => receiptDate; set => receiptDate = value; }
        public string Product { get => product; set => product = value; }
        public string ProductGroup { get => productGroup; set => productGroup = value; }
    }
}
