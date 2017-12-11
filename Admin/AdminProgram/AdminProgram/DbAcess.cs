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


namespace AdminProgram
{
    class DbAcess
    {
        SqlConnection connection;
        SqlCommand command;

        public DbAccess()
        {                                       // DONIAS CON STRING @"Data Source=LAPTOP-B9AASP37\SQLEXPRESS;Initial Catalog=DigitCashier;Integrated Security=True;Connect Timeout=30;";
                                                // BJÖRNS CON STRING Data Source=LAPTOP-TU1UMOIC;Initial Catalog=DigitCashier;Integrated Security=True
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=LAPTOP-TU1UMOIC;Initial Catalog=DigitCashier;Integrated Security=True";
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        }

        





    }
}
