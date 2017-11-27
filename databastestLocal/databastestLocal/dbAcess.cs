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



namespace databastestLocal
{

    class DbAcess
    {
        // Detta för att slippa upprepa senare i de olika metoderna
        // variabler
        SqlConnection connection;
        SqlCommand command;
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\skola\GIT\Digitcashier\databastestLocal\databastestLocal\databasen\Empolees.mdf;Integrated Security=True;Connect Timeout=30
        public DbAcess()
        {
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=LAPTOP-TU1UMOIC;Initial Catalog=DigitCashier;Integrated Security=True";
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        } // constructor
          ///////////////////////////////////////////////////////////////////

        // getdataset är den metod vi använder för att checka username och password mot databas, den returnerar ett dataset med all data som tillhör denna användaren.
        
        public User getUser(string txt_UserName, string txt_Password)
        {
            command.CommandText = "Select * from EmployeeUsers where employeeID=@employeeID and password=@password";
            command.Parameters.AddWithValue("@employeeID", txt_UserName);
            command.Parameters.AddWithValue("@password", txt_Password);
            connection.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            connection.Close();

            int count = ds.Tables[0].Rows.Count;

            if (count == 1)
            {
                
                User getuser = new User(
                //UserName = 
                ds.Tables[0].Rows[0][0].ToString(),
                //Fname = 
                ds.Tables[0].Rows[0][1].ToString(),
                //Sname = 
                ds.Tables[0].Rows[0][2].ToString(),
                //dob
                ds.Tables[0].Rows[0][3].ToString(),
                //adress
                ds.Tables[0].Rows[0][4].ToString(), 
                //Salary
                (int)ds.Tables[0].Rows[0][5],
                //postcode
                (int)ds.Tables[0].Rows[0][6],
                //age
                (int)ds.Tables[0].Rows[0][7],
                //passwordPin
                (int)ds.Tables[0].Rows[0][8],
                //reportsTo
                (int)ds.Tables[0].Rows[0][9],
                //companyId
                ds.Tables[0].Rows[0][10].ToString(),
                //RoleId
                (int)ds.Tables[0].Rows[0][11],
                //hoursWorked
                (int)ds.Tables[0].Rows[0][12],
                //hiredDate
                (DateTime)ds.Tables[0].Rows[0][13],
                //lastActiveDateTime
                (DateTime)ds.Tables[0].Rows[0][14],
                //checkIn
                (DateTime)ds.Tables[0].Rows[0][15],
                //checkOut
                (DateTime)ds.Tables[0].Rows[0][16]
                );
                return getuser;

            }
            else
            {
                throw new Exception();
            }
        }



        // denna är inte klar men ska kunna användas för att kunna hämta information i databasen på användarna

        //public static User GetUsersData(int id)
        //{

            


        //    command.CommandText = "Select * from User where employeeId=@employeeId";
        //    command.Parameters.AddWithValue("@employeeId", id);
        //    connection.Open();
        //    SqlDataAdapter adapt = new SqlDataAdapter(command);
        //    DataSet ds = new DataSet();
        //    adapt.Fill(ds);
        //    connection.Close();

        //    int count = ds.Tables[0].Rows.Count;

        //    if (count == 1)
        //    {
        //        return ds;
        //    }
        //    else
        //    {
        //        throw new Exception();
        //    }
          

        //}


        














        }
    }
