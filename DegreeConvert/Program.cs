using System;

namespace DegreeConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string valik;
            double a;
            
            

        Start:
            Console.WriteLine("Tere! See on Fahrenheit / Celsiuse kalkulaator.");
            Console.WriteLine("Kui soovid arvutada Fahrenheite vajuta F.");
            Console.WriteLine("Kui soovid arvutada Celsiuse'i vajuta C."); 
            valik = Console.ReadLine().ToLower();
            Console.WriteLine("Nüüd sisestage kraadid: ");
            a = int.Parse(Console.ReadLine());
            

           if (valik == "f")
            {

                Fahrenheit(a);

            }

           else if (valik == "c")
            {

                Celsius(a);
            }
            else
            {
                Console.WriteLine("Sellist valikut pole. Palun vali F või C");
                goto Start;
            }

        }


        public static void Fahrenheit(double kraad)
        {

            double x = Math.Round((kraad * 9) / 5 + 32, 1);
            Console.WriteLine($"Fahrenheit: {x} "); //Kuidas lisada arvutus ja lause ühele reale?
            Console.WriteLine($"Celsius: {kraad}");

        }

        public static void Celsius(double kraad)
        {
            double x = Math.Round((kraad - 32) * 5 / 9, 1);
            Console.WriteLine($"Celsius:{x}");
            Console.WriteLine($"Fahrenheit{kraad}");
        }
    }
}
