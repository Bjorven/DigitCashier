﻿using System;
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
                CashierClasses.User getUser = new User (
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
            connection.Close();


            return user;
        }



        public DataSet GetGoodsList()
        {

            command.CommandText = "Select P.idnumber, P.Pname, P.price, P.qty, P.PricePerHg, P.pricePerKg, PG.PGname, V.Vvalue, M.Mname, S.Supname from Product P, ProductGroup PG, Vat V, Manufacturer M, Supplier s Where P.receiptId is NULL and P.productGroupId = PG.PGid and P.vatId = V.Vid and P.manufacturerId = M.Mid and P.supplierId = S.Supid";
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

            if (searchText.Contains("*"))
            {
                connection.Open();
                command.CommandText = "spGetProduct";
                command.CommandType = CommandType.StoredProcedure;

                workperameter1 = command.Parameters.Add("@searchText", SqlDbType.VarChar);
                workperameter1.Value = searchText;
                command.ExecuteNonQuery();

                SqlDataAdapter adapt1 = new SqlDataAdapter(command);
                adapt1.Fill(ds);
                connection.Close();
            }

            
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
                 (
                 Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString()),
                 Convert.ToDouble(ds.Tables[0].Rows[0][1].ToString()),
                 //Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString()),
                 Convert.ToString(ds.Tables[0].Rows[0][2].ToString()),
                 Convert.ToString(ds.Tables[0].Rows[0][3].ToString()),
                 Convert.ToString(ds.Tables[0].Rows[0][4].ToString()),
                 Convert.ToDouble(ds.Tables[0].Rows[0][5].ToString()),
                 Convert.ToBoolean(ds.Tables[0].Rows[0][7].ToString()),
                 Convert.ToBoolean(ds.Tables[0].Rows[0][6].ToString()),
                 Convert.ToString(ds.Tables[0].Rows[0][8].ToString())
                 );
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

        //public void insertIntoDatabase(ListView cartItems)
        //{
        //    string sql = ;
        //    command.CommandType = CommandType.Text;
        //    foreach(ListViewItem item in cartItems.Items)
        //    {
        //        string qry = string.Format(sql, item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[3].Text, item.SubItems[4].Text);
        //        using (command = new SqlCommand(qry, connection))
        //        {
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //            connection.Close();
        //        }
        //    }
            
        //}


    }
}