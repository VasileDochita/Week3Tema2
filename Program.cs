using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrrk3Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            //LeapYear();
            ReadFromFile();
            //Console.ReadLine();
            //Proba();
        }

        private static void LeapYear()
        {
            int VerifyYear;
            Console.WriteLine("Input year to be checked : ");
            VerifyYear = Convert.ToInt32(Console.ReadLine());
            if ((VerifyYear % 400) == 0)
                Console.WriteLine($"{VerifyYear} is a leap year.");
            else if ((VerifyYear % 100) == 0)
                Console.WriteLine($"{VerifyYear} is not a leap year.");
            else if ((VerifyYear % 4) == 0)
                Console.WriteLine($"{VerifyYear} is a leap year.");
            else
                Console.WriteLine($"{VerifyYear} is not a leap year.");
            Console.ReadLine();
        }
        
        private static void ReadFromFile()
        {


            string text = System.IO.File.ReadAllText(@"C:\Users\Victor\Desktop\Sum.txt");


            System.Console.WriteLine($"Contents of Sum.txt = \n{text}");

            //// Exemplul 2

            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Victor\Desktop\Sum.txt");


            //Console.WriteLine("Contents of Sum.txt = ");
            //foreach (string line in lines)
            //{

            //    Console.WriteLine("\t" + line);
            //}

            Console.ReadLine();
        }
       

        //Aici am cautat sa vad daca am putea face ca un program sa fie deschis din C# (si cred ca asta e formula)
        //private static void Proba()
        //{
        //    System.Diagnostics.Process.Start(@"C:\Users\Victor\AppData\Local\slack\slack.exe");
        //}
        



    }



}
