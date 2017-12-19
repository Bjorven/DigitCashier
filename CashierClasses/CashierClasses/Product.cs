using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierClasses
{
    public class Product
    {
        private int id;
        private Int32 qty;

        private double price;
        private double vat;

        private string manufacturer;
        private string supplier;
        private string name;
        private string productGroup;

        private Boolean pricePerKg;
        private Boolean pricePerHg;



        public Product(int idy, double pricy, string manufac, string supply, string productG, double vaty, Boolean ppkg, Boolean ppHg, string namey)
        {
            Id = idy;
            Price = pricy;
            //Qty = qty1;
            Manufacturer = manufac;
            Supplier = supply;
            ProductGroup = productG;
            Vat = vaty;
            PricePerKG = ppkg;
            PricePerHG = ppHg;
            Name = namey;
        }


        public int Id { get; set; }
        public Int32 Qty { get; set; }
        public double Price { get; set; }
        public string Manufacturer { get; set; }
        public string Supplier { get; set; }
        public string ProductGroup { get; set; }
        public double Vat { get; set; }
        public Boolean PricePerKG { get; set; }
        public Boolean PricePerHG { get; set; }
        public string Name { get; set; }


    }
}
