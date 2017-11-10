using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databastestLocal
{
    class Employee
    {
        //instansvariabler
        private string fname;
        private string sname;
        private string adress;
        private int postnr;
        private string city;
        private string personnr;
        private Int64 salary;



        public Employee() { }

        public Employee(string forename, string surname, string hadress, int postcode, string hcity, string persnr, Int64 sal)
        {
            forename = Fname;
            surname = Sname;
            hadress = Adress;
            postcode = Postnr;
            hcity = City;
            persnr = Personnr;
            sal = Salary;
        }

        public string Fname { get; set; }
        public string Sname { get; set; }
        public string Adress { get; set; }
        public int Postnr { get; set; }
        public string City { get; set; }
        public string Personnr { get; set; }
        public Int64 Salary { get; set; }


    }
}
