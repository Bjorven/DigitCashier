using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databastestLocal
{
    class User:Employee
    {

        ///Instansvariabler
        ///

        private int userName;
        private Int64 password;
        private int acesslevel;

        public User() { }

        public User(int uname, Int64 passcode, int alvl)
        {
            uname = UserName;
            passcode = Password;
            alvl = Acesslevel;

           
        }
        public int UserName { get; set; }
        public Int64 Password { get; set; }
        public int Acesslevel { get; set; }











    }
}
