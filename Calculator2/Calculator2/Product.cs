using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    public class Product
    {
        private int id;
        private int qty;

        private long price;


        private decimal vat;

        private string manufacturer;
        private string supplier;
        private string name;
        private string productGroup;

        private Boolean pricePerKg;
        private Boolean pricePerHg;
        private int v1;
        private string v2;
        private string v3;
        private string v4;
        private int v5;
        private bool v6;
        private bool v7;
        private string v8;

        public Product(int v)
        {
        }

        public Product(int v, int v1, string v2, string v3, string v4, int v5, bool v6, bool v7, string v8) : this(v)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
            this.v8 = v8;
        }

        public Product(int idy, long pricy, int qty1, string manufac, string supply, string productG, decimal vaty, Boolean ppkg, Boolean ppHg, string namey)
        {
            Id = idy;
            Price = pricy;
            Qty = qty1;
            Manufacturer = manufac;
            Supplier = supply;
            ProductGroup = productG;
            Vat = vaty;
            PricePerKG = ppkg;
            PricePerHG = ppHg;
            Name = namey;
        }


        public int Id { get; set; }
        public int Qty { get; set; }
        public long Price { get; set; }
        public string Manufacturer { get; set; }
        public string Supplier { get; set; }
        public string ProductGroup { get; set; }
        public decimal Vat { get; set; }
        public Boolean PricePerKG { get; set; }
        public Boolean PricePerHG { get; set; }
        public string Name { get; set; }

        
    }
}
