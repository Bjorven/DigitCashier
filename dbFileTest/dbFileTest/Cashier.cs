using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbFileTest
{
    class Cashier:User
    {

        private int userName;
        private int acesslevel = 2;



        public Cashier(int uname)
        {
            uname = UserName;
        }

        public int UserName { get; set; }








    }
}
