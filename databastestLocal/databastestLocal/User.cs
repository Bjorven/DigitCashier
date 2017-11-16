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

        private string userName;
        private string password;
        private string acesslevel;

        public User() { }

        public User(string uname, string passcode, string alvl)
        {
            uname = UserName;
            passcode = Password;
            alvl = Acesslevel;

           
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Acesslevel { get; set; }











    }
}
