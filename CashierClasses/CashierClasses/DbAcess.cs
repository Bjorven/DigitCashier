using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.Common;
using System.Windows.Forms;

namespace CashierClasses
{
    public class DbAcess
    {
        // Detta läggs här för att slippa upprepa senare i de olika metoderna
        // variabler
        SqlConnection connection;
        SqlCommand command;

        public DbAcess()
        {
            connection = new SqlConnection
            {
                ConnectionString = @"Data Source=LAPTOP-TU1UMOIC;Initial Catalog=DigitCashier;Integrated Security=True"
            };
            command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text
            };
        } // constructor
          ///////////////////////////////////////////////////////////////////

        // getdataset är den metod vi använder för att checka username och password mot databas, den returnerar ett dataset med all data som tillhör denna användaren.

        // GetUser är den metod vi använder för att checka username och password mot databas, den returnerar en instans av klassen User med all data som tillhör denna användaren.

        public User GetUser(string txt_UserName, string txt_Password)
        {

            command.CommandText = "Select * from Employee where id=@id and passwordPIN=@passwordPIN";
            command.Parameters.AddWithValue("@id", txt_UserName);
            command.Parameters.AddWithValue("@passwordPIN", txt_Password);
            connection.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            connection.Close();

            int count = ds.Tables[0].Rows.Count;

            if (count == 1)
            {
                // här skickar vi ut och tilldelar user's data
                //vi måste göra detta en och en för att se vilken jag har parsat/castat fel.
                CashierClasses.User getUser = new User(
                ////UserName 
                Convert.ToInt16(ds.Tables[0].Rows[0][0]),
                ////Fname 
                Convert.ToString(ds.Tables[0].Rows[0][1].ToString()),
                ////Sname 
                Convert.ToString(ds.Tables[0].Rows[0][2].ToString()),
                ////dob
                Convert.ToString(ds.Tables[0].Rows[0][3].ToString()),
                ////adress
                Convert.ToString(ds.Tables[0].Rows[0][4].ToString()),
                ////Salary
                Convert.ToInt32(ds.Tables[0].Rows[0][5].ToString()),
                ////postcode
                Convert.ToInt32(ds.Tables[0].Rows[0][6].ToString()),
                ////age
                Convert.ToInt32(ds.Tables[0].Rows[0][7].ToString()),
                ////passwordPin
                Convert.ToInt32(ds.Tables[0].Rows[0][8].ToString()),
                ////reportsTo
                Convert.ToInt32(ds.Tables[0].Rows[0][9].ToString()),
                ////companyId
                Convert.ToString(ds.Tables[0].Rows[0][10].ToString()),
                ////RoleId
                Convert.ToInt32(ds.Tables[0].Rows[0][11].ToString()),
                ////hoursWorked denna funkar inte!!
                Convert.ToInt16(ds.Tables[0].Rows[0][12].ToString()),
                //hiredDate
                Convert.ToDateTime(ds.Tables[0].Rows[0][13].ToString()),
                //lastActiveDateTime
                Convert.ToDateTime(ds.Tables[0].Rows[0][14].ToString()),
                //checkIn
                Convert.ToDateTime(ds.Tables[0].Rows[0][15].ToString()),
                //checkOut
                Convert.ToDateTime(ds.Tables[0].Rows[0][16].ToString())
                );

                return getUser;



            }
            else
            {

                throw new Exception();
            }
        }


        // Detta är vår metod för att spara upp hur lång tid en användare har arbetat (varit inloggad), 
        // denna tid summeras upp till en "total arbetade timmar"-coloumn i Databasen.
        public User GetTimestamp(User user)
        {

            int timeelapsed = (int)user.CheckOut.Subtract(user.CheckIn).TotalMinutes;

            user.HoursWorked = user.HoursWorked + timeelapsed;

            command.CommandText = "UPDATE Employee SET checkIn=@checkIn, checkOut=@checkOut, hoursWorked=@hoursWorked where id=@id";
            command.Parameters.AddWithValue("@id", user.UserName);
            command.Parameters.AddWithValue("@checkIn", user.CheckIn);
            command.Parameters.AddWithValue("@checkOut", user.CheckOut);
            command.Parameters.AddWithValue("@hoursWorked", user.HoursWorked);
            //command.Parameters.AddWithValue("@lasActiveDateTime", user.CheckIn);
            connection.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            command.ExecuteNonQuery();
            connection.Close();


            return user;
        }



        public DataSet GetPgGroup()
        {
            command.CommandText = "select * from ProductGroup";
            connection.Open();
            SqlDataAdapter adapt = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            connection.Close();
            return ds;
        }

        public DataSet GetGoodsList()
        {

            command.CommandText = "Select P.idnumber, P.Pname, P.price, P.qty, P.PricePerHg, P.pricePerKg, PG.PGname, V.Vvalue, M.Mname, S.Supname, P.productGroupId, P.inStock from Product P, ProductGroup PG, Vat V, Manufacturer M, Supplier s Where P.receiptId is NULL and P.productGroupId = PG.PGid and P.vatId = V.Vid and P.manufacturerId = M.Mid and P.supplierId = S.Supid";
            connection.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            connection.Close();
            return ds;

        }

        public Product GetProduct(string searchText)
        {
            SqlParameter workperameter1 = new SqlParameter();
            DataSet ds = new DataSet();

            command.CommandText = "spGetProduct";
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            workperameter1 = command.Parameters.Add("@searchText", SqlDbType.VarChar);
            workperameter1.Value = searchText;
            command.ExecuteNonQuery();

            SqlDataAdapter adapt = new SqlDataAdapter(command);
            adapt.Fill(ds);
            connection.Close();
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                Product getproduct = new Product
                {
                    Id = Convert.ToInt16(ds.Tables[0].Rows[0][0]),
                    Price = Convert.ToDouble(ds.Tables[0].Rows[0][1]),
                    Manufacturer = ds.Tables[0].Rows[0][2].ToString(),
                    ManufacturerId = Convert.ToInt16(ds.Tables[0].Rows[0][12]),
                    Supplier = ds.Tables[0].Rows[0][3].ToString(),
                    SupplierId = Convert.ToInt16(ds.Tables[0].Rows[0][13]),
                    Vat = Convert.ToDouble(ds.Tables[0].Rows[0][5]),
                    VatId = Convert.ToInt16(ds.Tables[0].Rows[0][14]),
                    PricePerHG = Convert.ToBoolean(ds.Tables[0].Rows[0][6]),
                    PricePerKG = Convert.ToBoolean(ds.Tables[0].Rows[0][7]),
                    Name = ds.Tables[0].Rows[0][8].ToString(),
                    InStock = Convert.ToDouble(ds.Tables[0].Rows[0][9]),
                    Qty = Convert.ToDouble(ds.Tables[0].Rows[0][10]),
                    ProductGroupId = Convert.ToInt16(ds.Tables[0].Rows[0][11]),
                    ProductGroupname = ds.Tables[0].Rows[0][4].ToString(),

                };
                
                 
                return getproduct;
            }
            else
            {
                throw new Exception();
            }
        }

        //***************************************************************************************************************************************************
        //***************************************************************************************************************************************************

        public DataTable GetReceipt(string Search_text)

        {
            SqlParameter workparameter1 = new SqlParameter();
            connection.Open();
            command.CommandText = "spGetReceipt";
            command.CommandType = CommandType.StoredProcedure;

            workparameter1 = command.Parameters.Add("@Search_text", SqlDbType.VarChar);
            workparameter1.Value = Search_text;
            command.ExecuteNonQuery();


            SqlDataAdapter Adapt = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            Adapt.Fill(dt);
            connection.Close();


            return dt;
        }
        // //***************************************************************************************************************************************************
        // //***************************************************************************************************************************************************



        public DataSet GetTotalPriceAndQty(string Search_text)
        {
            command.CommandText = "Select sum (price*qty) as totalprice, sum (qty) as totalqty from Product where receiptId = @receiptId";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@receiptId", Search_text);
            connection.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            connection.Close();
            return ds;
        }

        #region Export Store Data to Sql

        //public void ExportSqlData(DataTable prod)
        //{

        //    try
        //    {
        //        command.CommandText = "Select P.idnumber, P.Pname, P.price, P.qty, P.PricePerHg, P.pricePerKg, PG.PGname, V.Vvalue, M.Mname, S.Supname from Product P, ProductGroup PG, Vat V, Manufacturer M, Supplier s Where P.receiptId is NULL and P.productGroupId = PG.PGid and P.vatId = V.Vid and P.manufacturerId = M.Mid and P.supplierId = S.Supid";
        //        command.CommandType = CommandType.Text;
        //        connection.Open();
        //        command.ExecuteNonQuery();
        //        SqlDataAdapter adapt = new SqlDataAdapter(command);
        //        adapt.Fill(prod);


        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);


        //    }


        //    finally
        //    {
        //        connection.Close();


        //    }




        //}

        #endregion



        

        public int getReceiptid()
        {
            int receiptId;
            command.CommandText = "Select id from receipt Order By id DESC";
            command.CommandType = CommandType.Text;
            connection.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            connection.Close();

            receiptId = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
            receiptId++;

            return receiptId;



        }

        public DataSet beforeInsertProduct()
        {
            command.CommandText = "Select * from Product where receiptId is null";
            command.CommandType = CommandType.Text;
            connection.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            connection.Close();

            return ds;
        }

        public void insertIntoDatabase(List<Product> cartItems, string textBox)
        {
            #region Create and Insert to tempTable
            //"create table tempTable1 ([id] [bigint] IDENTITY(1,1) NOT NULL, [idnumber] [nchar] (10) NULL, [price] [money] NULL, [manufacturerId] [nvarchar] (50) NULL, [supplierId] [nvarchar] (50) NULL, [productGroupId] [nchar] (10) NULL, [vatId] [nchar] (10) NULL, [pricePerKg] [bit] NULL, [PricePerHg] [bit] NULL, [Pname] [nvarchar] (50) NULL, [receiptId] [bigint] NULL, [qty] [decimal](18, 2) NULL, [inStock] [decimal](18, 2) NULL,)" +
            //"Insert into tempTable1 (idnumber, price, manufacturerId, supplierId, productGroupId, vatId, pricePerKg, PricePerHg, Pname, receiptId, qty, inStock)" +
            connection.Open();

            command.CommandText = "Insert Into Product (idnumber, price, manufacturerId, supplierId, productGroupId, vatId, pricePerKg, PricePerHg, Pname, receiptId, qty, inStock) Values (@idnumber, @price, @manufacturerId, @supplierId, @productGroupId, @vatId, @pricePerKg, @PricePerHg, @Pname, @receiptId, @qty, @inStock)";
            command.CommandType = CommandType.Text;
            command.Connection = connection;


            command.Parameters.Add("@idnumber", SqlDbType.NChar);
            command.Parameters.Add("@price", SqlDbType.Money);
            command.Parameters.Add("@manufacturerId", SqlDbType.NVarChar);
            command.Parameters.Add("@supplierId", SqlDbType.NVarChar);
            command.Parameters.Add("@productGroupId", SqlDbType.NChar);
            command.Parameters.Add("@vatId", SqlDbType.NChar);
            command.Parameters.Add("@pricePerKg", SqlDbType.Bit);
            command.Parameters.Add("@PricePerHg", SqlDbType.Bit);
            command.Parameters.Add("@Pname", SqlDbType.NVarChar);
            command.Parameters.Add("@receiptId", SqlDbType.BigInt);
            command.Parameters.Add("@qty", SqlDbType.Decimal);
            command.Parameters.Add("@inStock", SqlDbType.Decimal);
            

            foreach (var p in cartItems)
            {
                command.Parameters[0].Value = p.Id;
                command.Parameters[1].Value = p.Price;
                command.Parameters[2].Value = p.ManufacturerId;
                command.Parameters[3].Value = p.SupplierId;
                command.Parameters[4].Value = p.ProductGroupId;
                command.Parameters[5].Value = p.VatId;
                command.Parameters[6].Value = p.PricePerKG;
                command.Parameters[7].Value = p.PricePerHG;
                command.Parameters[8].Value = p.Name;
                command.Parameters[9].Value = p.ReceiptId;
                command.Parameters[10].Value = p.Qty;
                command.Parameters[11].Value = p.InStock - p.Qty;

                command.ExecuteNonQuery();

            }
            command.CommandText = "Update Product Set inStock=@inStock where receiptId is Null and idnumber=@idnumber";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            
            foreach (var p in cartItems)
            {
                command.Parameters[11].Value = p.InStock - p.Qty;
                command.ExecuteNonQuery();
            }


            connection.Close();
            #endregion

        }
        public void insertproduct(Product p, string textBox)
        {
            command.CommandText = "Insert Into Product (idnumber, price, manufacturerId, supplierId, productGroupId, vatId, pricePerKg, PricePerHg, Pname, receiptId, qty, inStock) Values (@idnumber, @price, @manufacturerId, @supplierId, @productGroupId, @vatId, @pricePerKg, @PricePerHg, @Pname, @receiptId, @qty, @inStock)";
            command.CommandType = CommandType.Text;
            connection.Open();
            command.Parameters.Add("@idnumber", SqlDbType.NChar);
            command.Parameters.Add("@price", SqlDbType.Money);
            command.Parameters.Add("@manufacturerId", SqlDbType.NVarChar);
            command.Parameters.Add("@supplierId", SqlDbType.NVarChar);
            command.Parameters.Add("@productGroupId", SqlDbType.NChar);
            command.Parameters.Add("@vatId", SqlDbType.NChar);
            command.Parameters.Add("@pricePerKg", SqlDbType.Bit);
            command.Parameters.Add("@PricePerHg", SqlDbType.Bit);
            command.Parameters.Add("@Pname", SqlDbType.NVarChar);
            command.Parameters.Add("@receiptId", SqlDbType.BigInt);
            command.Parameters.Add("@qty", SqlDbType.Decimal);
            command.Parameters.Add("@inStock", SqlDbType.Decimal);

            command.Parameters[0].Value = p.Id;
            command.Parameters[1].Value = p.Price;
            command.Parameters[2].Value = p.ManufacturerId;
            command.Parameters[3].Value = p.SupplierId;
            command.Parameters[4].Value = p.ProductGroupId;
            command.Parameters[5].Value = p.VatId;
            command.Parameters[6].Value = p.PricePerKG;
            command.Parameters[7].Value = p.PricePerHG;
            command.Parameters[8].Value = p.Name;
            command.Parameters[9].Value = Convert.ToDecimal(textBox);
            command.Parameters[10].Value = 3.5;
            command.Parameters[11].Value = p.InStock - p.Qty;
            command.ExecuteNonQuery();

            connection.Close();
        }

        public void insertIntoReceiptdb(Receipt myreceipt)
        {
            command.CommandText = "Insert Into receipt (receiptDate, salePerson, cash, credit, coupon, vatAmount, total) Values (@receiptDate, @salePerson, @cash, @credit, @coupon, @vatAmount, @total)";
            command.CommandType = CommandType.Text;
            connection.Open();
            command.Parameters.Add("@receiptDate", SqlDbType.DateTime);
            command.Parameters.Add("@salePerson", SqlDbType.VarChar);
            command.Parameters.Add("@cash", SqlDbType.Bit);
            command.Parameters.Add("@credit", SqlDbType.Bit);
            command.Parameters.Add("@coupon", SqlDbType.Bit);
            command.Parameters.Add("@vatAmount", SqlDbType.Money);
            command.Parameters.Add("@total", SqlDbType.Money);

            command.Parameters[0].Value = myreceipt.Issuedate;
            command.Parameters[1].Value = myreceipt.SalesPerson;
            command.Parameters[2].Value = myreceipt.Cash;
            command.Parameters[3].Value = myreceipt.Credit;
            command.Parameters[4].Value = myreceipt.Coupon;
            command.Parameters[5].Value = myreceipt.Vat1;
            command.Parameters[6].Value = myreceipt.Topay;
            command.ExecuteNonQuery();

            connection.Close();
        }

    }
}