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

namespace Kvitto
{
    class DbAcess
    {
        SqlConnection connection;
        SqlCommand command;

        public DbAcess()
        {
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\skola\GIT\Digitcashier\databastestLocal\databastestLocal\databasen\Empolees.mdf;Integrated Security=True;Connect Timeout=30";
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        } // constructor
          ///////////////////////////////////////////////////////////////////

        // getdataset är den metod vi använder för att checka username och password mot databas, den returnerar ett dataset med all data som tillhör denna användaren.

        public DataSet getReceipt(string Search_text)
        {
            command.CommandText = "Select * from receipt id=@id";
            
            command.Parameters.AddWithValue("@id", Search_text);
            connection.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            connection.Close();

            return ds;













        }
















    }
}
