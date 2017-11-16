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
    class dbAcess   
    {
        // Detta för att slippa upprepa senare i de olika metoderna
        // variabler
        SqlConnection connection;
        SqlCommand command;

        public dbAcess()
        {
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\skola\GIT\Digitcashier\databastestLocal\databastestLocal\databasen\Empolees.mdf;Integrated Security=True;Connect Timeout=30";
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        } // constructor
        ///////////////////////////////////////////////////////////////////

            // getdataset är den metod vi använder för att checka username och password mot databas, den returnerar ett dataset med all data som tillhör denna användaren.

        public DataSet getdataset(string txt_UserName, string txt_Password)
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
                return ds;

            }
            else
            {
                return null;
            }
        }

        // detta är vår bool metod som bara kollar ifall vårt dataset innehåller något.
        public bool credentialcheckerLogin(DataSet ds)
        {

            int count = ds.Tables[0].Rows.Count;

            if (count == 1)
            {
                return true;
                
            }
            else
            {
                return false;
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
