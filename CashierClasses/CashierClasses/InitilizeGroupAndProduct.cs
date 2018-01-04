using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace CashierClasses
{
    public class InitilizeGroupAndProduct
    {
        private DataSet productGroups;
        private DataSet products;


        //protected override void Seed(ProductContext context)
        //{
        //    GetCategories().ForEach(c => context.Categories.Add(c)); 
        //    GetProducts().ForEach(p => context.Products.Add(p));
        //}

        public static List<ProductGroup> GetCategories()
        {

            DbAcess db = new DbAcess();
            DataSet productGroups = db.GetPgGroup();

            var ProductGroup = new List<ProductGroup> {
                new ProductGroup
                {
                    PGId = Convert.ToInt16(productGroups.Tables[0].Rows[0][0]),
                    PGName = productGroups.Tables[0].Rows[0][1].ToString()
                },
                new ProductGroup
                {
                    PGId = Convert.ToInt16(productGroups.Tables[0].Rows[1][0]),
                    PGName = productGroups.Tables[0].Rows[1][1].ToString()
                },
                new ProductGroup
                {
                    PGId = Convert.ToInt16(productGroups.Tables[0].Rows[2][0]),
                    PGName = productGroups.Tables[0].Rows[2][1].ToString()
                },

            };

            return ProductGroup;
        }

        public static List<Product> GetProducts()
        {
            DbAcess db = new DbAcess();
            DataSet products = db.GetGoodsList();

            var Products = new List<Product> {

                new Product
                {
                     Id = Convert.ToInt16(products.Tables[0].Rows[0][0]),
                     Manufacturer = products.Tables[0].Rows[0][8].ToString(),
                     Name = products.Tables[0].Rows[0][1].ToString(),
                     Price = Convert.ToDouble(products.Tables[0].Rows[0][2]),
                     PricePerHG = Convert.ToBoolean(products.Tables[0].Rows[0][4]),
                     PricePerKG = Convert.ToBoolean(products.Tables[0].Rows[0][5]),
                     ProductGroupId = Convert.ToInt16(products.Tables[0].Rows[0][10]),
                     Qty = Convert.ToDouble(products.Tables[0].Rows[0][3]),
                     Supplier = products.Tables[0].Rows[0][9].ToString(),
                     Vat = Convert.ToDouble(products.Tables[0].Rows[0][7]),
                     InStock = Convert.ToDouble(products.Tables[0].Rows[0][11]),


                },
                new Product
                {
                    Id = Convert.ToInt16(products.Tables[0].Rows[1][0]),
                     Manufacturer = products.Tables[0].Rows[1][8].ToString(),
                     Name = products.Tables[0].Rows[1][1].ToString(),
                     Price = Convert.ToDouble(products.Tables[0].Rows[1][2]),
                     PricePerHG = Convert.ToBoolean(products.Tables[0].Rows[1][4]),
                     PricePerKG = Convert.ToBoolean(products.Tables[0].Rows[1][5]),
                     ProductGroupId = Convert.ToInt16(products.Tables[0].Rows[1][10]),
                     Qty = Convert.ToDouble(products.Tables[0].Rows[1][3]),
                     Supplier = products.Tables[0].Rows[1][9].ToString(),
                     Vat = Convert.ToDouble(products.Tables[0].Rows[1][7]),
                     InStock = Convert.ToDouble(products.Tables[0].Rows[1][11]),
                },
                new Product
                {
                    Id = Convert.ToInt16(products.Tables[0].Rows[2][0]),
                     Manufacturer = products.Tables[0].Rows[2][8].ToString(),
                     Name = products.Tables[0].Rows[2][1].ToString(),
                     Price = Convert.ToDouble(products.Tables[0].Rows[2][2]),
                     PricePerHG = Convert.ToBoolean(products.Tables[0].Rows[2][4]),
                     PricePerKG = Convert.ToBoolean(products.Tables[0].Rows[2][5]),
                     ProductGroupId = Convert.ToInt16(products.Tables[0].Rows[2][10]),
                     Qty = Convert.ToDouble(products.Tables[0].Rows[2][3]),
                     Supplier = products.Tables[0].Rows[2][9].ToString(),
                     Vat = Convert.ToDouble(products.Tables[0].Rows[2][7]),
                     InStock = Convert.ToDouble(products.Tables[0].Rows[2][11]),
                },
                new Product
                {
                    Id = Convert.ToInt16(products.Tables[0].Rows[3][0]),
                     Manufacturer = products.Tables[0].Rows[3][8].ToString(),
                     Name = products.Tables[0].Rows[3][1].ToString(),
                     Price = Convert.ToDouble(products.Tables[0].Rows[3][2]),
                     PricePerHG = Convert.ToBoolean(products.Tables[0].Rows[3][4]),
                     PricePerKG = Convert.ToBoolean(products.Tables[0].Rows[3][5]),
                     ProductGroupId = Convert.ToInt16(products.Tables[0].Rows[3][10]),
                     Qty = Convert.ToDouble(products.Tables[0].Rows[3][3]),
                     Supplier = products.Tables[0].Rows[3][9].ToString(),
                     Vat = Convert.ToDouble(products.Tables[0].Rows[3][7]),
                     InStock = Convert.ToDouble(products.Tables[0].Rows[3][11]),
                },
                new Product
                {
                    Id = Convert.ToInt16(products.Tables[0].Rows[4][0]),
                     Manufacturer = products.Tables[0].Rows[4][8].ToString(),
                     Name = products.Tables[0].Rows[4][1].ToString(),
                     Price = Convert.ToDouble(products.Tables[0].Rows[4][2]),
                     PricePerHG = Convert.ToBoolean(products.Tables[0].Rows[4][4]),
                     PricePerKG = Convert.ToBoolean(products.Tables[0].Rows[4][5]),
                     ProductGroupId = Convert.ToInt16(products.Tables[0].Rows[4][10]),
                     Qty = Convert.ToDouble(products.Tables[0].Rows[4][3]),
                     Supplier = products.Tables[0].Rows[4][9].ToString(),
                     Vat = Convert.ToDouble(products.Tables[0].Rows[4][7]),
                     InStock = Convert.ToDouble(products.Tables[0].Rows[4][11]),
                },
                new Product
                {
                    Id = Convert.ToInt16(products.Tables[0].Rows[5][0]),
                     Manufacturer = products.Tables[0].Rows[5][8].ToString(),
                     Name = products.Tables[0].Rows[5][1].ToString(),
                     Price = Convert.ToDouble(products.Tables[0].Rows[5][2]),
                     PricePerHG = Convert.ToBoolean(products.Tables[0].Rows[5][4]),
                     PricePerKG = Convert.ToBoolean(products.Tables[0].Rows[5][5]),
                     ProductGroupId = Convert.ToInt16(products.Tables[0].Rows[5][10]),
                     Qty = Convert.ToDouble(products.Tables[0].Rows[5][3]),
                     Supplier = products.Tables[0].Rows[5][9].ToString(),
                     Vat = Convert.ToDouble(products.Tables[0].Rows[5][7]),
                     InStock = Convert.ToDouble(products.Tables[0].Rows[5][11]),
                },
              
            };

            return Products;
        }
    }
}