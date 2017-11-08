using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovningArraySattar
{
    class Program
    {
        static void Main(string[] args)
        {
            ////övning 7
            //int sum;
            //int[] tal = new int[] { 10, 20, 30, 40 };
            //Console.WriteLine(tal);
            //for (int i = 0; i < tal.Length; i++)
            //{
            //    tal[i]++;

            //}
            //Console.WriteLine(tal[1]);


            ////Ö.8 while loop som ber om ett nytt namn att föra in i registret.

            //string[] reg = new string[10];
            //int antal = 0;
            //string name;
            //// loopa så länge det finns plats i registret
            //while (antal < 10)
            //{
            //    Console.WriteLine("input nytt namn:");
            //    name = Console.ReadLine();
            //    if (name.Equals("EXIT"))
            //    {
            //        break;
            //    }
            //    // reg[antal] kollar så att det är samma namn i arrayn som i stringen name innan den går vidare och lagrar.
            //    reg[antal] = name;
            //    antal++;
            //}

            ////Ö.9 ska en array som lagrar tio nummer. A) manuellt B) med Loop (både for och while)

            //// med for loop
            //int[] tal = new int[10];
            //for (int i = 0; i < tal.Length; i++)
            //{
            //    tal[i]++;

            //}

            ////med while loop

            //int count = 0;
            //int antal = 1;
            //int[] tal = new int[10];
            //while (count < 10)
            //{
            //    tal[count] = antal;
            //    antal++;
            //    count++;
            //}
            //Console.WriteLine(tal[0]);

            //// manuellt
            //int[] tal = new int[10];
            //tal[0] = 1;
            //tal[1] = 2;
            //tal[2] = 3;
            //tal[3] = 4;
            //tal[4] = 5;
            //tal[5] = 6;
            //tal[6] = 7;
            //tal[7] = 8;
            //tal[8] = 9;
            //tal[9] = 10;
            //Console.WriteLine(tal[9]);

            ////////Ö.9 

            ////skriv ut mauellt
            //int[] tal = new int[] { 8, 4, 1, 9, 4 };
            //Console.WriteLine(tal[0]);
            //Console.WriteLine(tal[1]);
            //Console.WriteLine(tal[2]);
            //Console.WriteLine(tal[3]);
            //Console.WriteLine(tal[4]);
            //// omvänd ordning




            //// temp lika lång som tal. vi behöver göra en "int temp" för som är exakt lika lång som "int tal"
            //// Jag behöver att nån förklarar temp[i] = tal[tal.Length - i - 1];
            //int sum;
            //int[] temp = new int[tal.Length];

            //for (int i = 0; i < tal.Length; i++)
            //{
            //    temp[i] = tal[tal.Length - i - 1];
            //}
            //tal = temp;
            //sum = tal[4];
            //Console.WriteLine(tal[0]);
            //Console.WriteLine(tal[1]);
            //Console.WriteLine(tal[2]);
            //Console.WriteLine(tal[3]);
            //Console.WriteLine(tal[4]);

            ////beräkna medelvärde

            //double sum = 0;

            //int[] tal = new int[] { 8, 4, 1, 9, 4 };

            //for (int i = 0; i < tal.Length; i++)
            //{
            //    sum = sum + tal[i];
            //}
            //Console.WriteLine(sum/5);



            ////byt plats på index 2 med index 4
            //int tal1;
            //int tal2;
            //int[] tal = new int[] { 8, 4, 1, 9, 4 };
            ////sparar index 2 och 4 i variabel tal 1 och tal 2
            //tal1 = tal[2];
            //tal2 = tal[4];
            //// nu bytar jag ut värdena
            //tal[2] = tal2;
            //tal[4] = tal1;
            //Console.WriteLine(tal[0]);
            //Console.WriteLine(tal[1]);
            //Console.WriteLine(tal[2]);
            //Console.WriteLine(tal[3]);
            //Console.WriteLine(tal[4]);

            //// hitta den med max och minst skriv sedan ut
            //int min;
            //int max;
            //int minindex;
            //int maxindex;
            //int[] tal = new int[] { 8, 4, 1, 9, 4 };
            //min = tal[0];
            //max = tal[0];
            //minindex = 0;
            //maxindex = 0;
            //for (int i=0; i < tal.Length; i++)
            //{


            //    if (tal[i] < min)
            //        {
            //            minindex = i;
            //            min = tal[i];
            //        }
            //    if (tal[i] > max)
            //    {
            //        maxindex = i;
            //        max = tal[i];
            //    }


            //}
            //Console.WriteLine("minimum:" + min);
            //Console.WriteLine("minindex" + minindex);
            //Console.WriteLine("maximum:" + max);
            //Console.WriteLine("maxindex" + maxindex);
            //// byt så att det med max flyttas till sist i arrayn och den sita till den med max
            //int tal1 = tal[3];
            //int tal2 = tal[4];
            //tal[3] = tal2;
            //tal[4] = tal1;
            //Console.WriteLine(tal[0]);
            //Console.WriteLine(tal[1]);
            //Console.WriteLine(tal[2]);
            //Console.WriteLine(tal[3]);
            //Console.WriteLine(tal[4]);


            ////Ö.10
            ////skriver ut " antal tal?
            //// deklarerar och initierar variablen int antal med valfritt heltal
            //// deklarerar och initierar en int array som ska va lika stor som int antal.
            //// skriver ut "Ge talen"
            //// kör en loop för att tilldela alla array index ett element

            //Console.WriteLine("Antal tal?");
            //int antal = Console.Read();
            //int[] tal = new int[antal];

            //Console.WriteLine("Ge talen:");
            //for (int i = 0; i < tal.Length; i++)
            //{
            //    tal[i] = Console.Read();
            //}

            //Ö.11
            //int sum;
            //String[] namn = { "Uno", "Eva", "Karl-Astrid", "Ann-Bengt" };
            //Console.WriteLine(namn[0]);
            //Console.WriteLine(namn[1]);
            //Console.WriteLine(namn[2]);
            //Console.WriteLine(namn[3]);





            //        int firstarray = namn[0].Length;
            //        int secondarray = namn[1].Length;
            //        int thirdarray = namn[2].Length;
            //        int fourtharray = namn[3].Length;
            //        sum = firstarray + secondarray + thirdarray + fourtharray;
            //        Console.WriteLine("summan av alla tecken " + sum);

            //// beräknar medellängden
            //sum = sum / 4;
            //Console.WriteLine("medelvärde: " + sum);

            //for (int i = 0; i < namn.Length; i++) ;

            //Array.Sort(namn);
            ////Array.Sort(namn[i].Length);
            //Console.WriteLine("new order alfabetical");
            //Console.WriteLine(namn[0]);
            //Console.WriteLine(namn[1]);
            //Console.WriteLine(namn[2]);
            //Console.WriteLine(namn[3]);


            //Ö.12 band mellan två strings

            String[] namn = { "Sattar", "Anders", "Lisa", "Ragnar" };
            int[] age = { 35, 62, 34, 18 };
            





        }

    }
}
