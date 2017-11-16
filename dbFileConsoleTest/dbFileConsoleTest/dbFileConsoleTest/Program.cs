using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dbFileConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("enter username:");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            //H:\skola\GIT\Digitcashier\dbFileConsoleTest\dbFileConsoleTest\dbFileConsoleTest\txtf_users

            string line;

            using (StreamReader reader = new StreamReader(@"H:\\skola\\GIT\\Digitcashier\\dbFileTest\\dbFileTest\\txtf_users\\EmployeeCredentials.txt"))

            {

                while (reader.Peek() >= 0 && [didn't find password])
                {
                    Console.WriteLine(reader.ReadLine());

                }



            }

            string[] ss = line.Split(',');

            if (userName == ss[0])

            {

                if (password == ss[1])

                {
                    Console.WriteLine("login sucess");
                    Console.ReadLine();
                }

                else

                {

                    Console.WriteLine("Username or password incorrect");
                    Console.ReadLine();
                }

            }
        }

    }
    
}
