using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dbFileTest
{
    class Cashier:User
    {

        private int userName;
        private int password;
        private int acesslevel;



        public Cashier(int uname, Int64 passcode, int alvl, string forename, string surname, string hadress, int postcode, string hcity, string persnr, Int64 sal)
        {
            uname = UserName;
            passcode = Password;
            alvl = Acesslevel;
            forename = Fname;
            surname = Sname;
            hadress = Adress;
            postcode = Postnr;
            hcity = City;
            persnr = Personnr;
            sal = Salary;
        }

        public int UserName { get; set; }
        public Int64 Password { get; set; }
        public int Acesslevel { get; set; }
        public string Fname { get; set; }
        public string Sname { get; set; }
        public string Adress { get; set; }
        public int Postnr { get; set; }
        public string City { get; set; }
        public string Personnr { get; set; }
        public Int64 Salary { get; set; }

     

        public static void getusername()
        {
            
            StreamReader sr = new StreamReader(@"H:\\skola\\GIT\\Digitcashier\\dbFileTest\\dbFileTest\\txtf_users\\EmployeeCredentials.txt");
            string s = sr.ReadLine();
            string[] parts = s.Split('\t');
            for (parts[0])
            {
                
            }
         
        }




    }
}
