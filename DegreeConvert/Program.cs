using System;

namespace DegreeConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string valik;
            int a;
            int x;

        Start:
            Console.WriteLine("Tere! See on Fahrenheit / Celsiuse kalkulaator.");
            Console.WriteLine("Kui soovid arvutada Fahrenheite vajuta F.");
            Console.WriteLine("Kui soovid arvutada Celsiuse'i vajuta C."); 
            valik = Console.ReadLine().ToLower();
            

           if (valik == "f")
            {

                Console.WriteLine("Nüüd sisestage kraadid: ");
                a = int.Parse(Console.ReadLine());
                x = (a * 9) / 5 + 32;
                Console.WriteLine($"Fahrenheit = {x}");
                Console.WriteLine("Celsius = {a}");

            }

           else if (valik == "c")
            {
                Console.WriteLine("Nüüd sisestage kraadid: ");
                a = int.Parse(Console.ReadLine());
                x = (a - 32) * 5 / 9;
                Console.WriteLine($"Celsius = {x}");
                Console.WriteLine($"Fahrenheit = {a}");
            }
            else
            {
                Console.WriteLine("Sellist valikut pole. Palun vali F või C");
                goto Start;
            }
            
        }
    }
}
