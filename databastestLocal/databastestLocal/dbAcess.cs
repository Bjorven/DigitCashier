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
        public static bool credentialcheckerLogin(string txt_UserName, string txt_Password)
        {

            // login check credentials.
            //Connection String
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Björn\Documents\GitHub\DigitCashier\databastestLocal\databastestLocal\Database1.mdf;Integrated Security=True;Connect Timeout=30";




            //Create SqlConnection
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select * from Employees where employeeID=@employeeID and password=@password", con);
            cmd.Parameters.AddWithValue("@employeeID", txt_UserName);
            cmd.Parameters.AddWithValue("@password", txt_Password);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            
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
        //public dbAcess() { }


        
        
         
        // Get userinfo
        
                


    }
}
