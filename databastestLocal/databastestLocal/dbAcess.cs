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

        public DataSet getdataset(string txt_UserName, string txt_Password)
        {
            command.CommandText = "Select * from EmployeeUsers where id=@id and passwordPIN=@passwordPIN";
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
                return ds;

            }
            else
            {
                throw new Exception();
            }
        }

      
        
        // denna är inte klar men ska kunna användas för att kunna hämta information i databasen på användarna

        public bool GetUsersData(ref string acesslvl, ref string forename)
        {
           

            bool returnvalue = false;
            try
            {
                
                command.CommandText = "Select * from EmployeeUsers where employeeID=@employeeID and password=@password";
                command.Parameters.Add("@forename", SqlDbType.VarChar).Value = forename;
                command.Parameters.Add("@acesslvl", SqlDbType.NChar).Value = acesslvl;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        acesslvl = reader.GetString(1);
                        forename = reader.GetString(2);
                    }
                }
                returnvalue = true;
            }
            catch
            { }
            finally
            {
                connection.Close();
            }
            return returnvalue;

        }

















        }
    }
