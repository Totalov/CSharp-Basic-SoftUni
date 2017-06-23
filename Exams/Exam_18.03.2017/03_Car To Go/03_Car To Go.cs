using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            if (budget <= 100)
            {
                if (season == "Summer")
                {
                    var price = budget * 0.35;
                    Console.WriteLine("Economy class");
                    Console.WriteLine(String.Format("Cabrio - {0:0.00}", price));
                }
                else if (season == "Winter")
                {
                    var price = budget * 0.65;
                    Console.WriteLine("Economy class");
                    Console.WriteLine(String.Format("Jeep - {0:0.00}", price));
                    //Console.WriteLine($"Jeep - {price:F2}");
                }
            }


            if (budget >100 && budget <= 500)
            {
                if (season == "Summer")
                {
                    var price = budget * 0.45;
                    Console.WriteLine("Compact class");
                    Console.WriteLine(String.Format("Cabrio - {0:0.00}", price));
                }
                else if (season == "Winter")
                {
                    var price = budget * 0.80;
                    Console.WriteLine("Compact class");
                    Console.WriteLine(String.Format("Jeep - {0:0.00}", price));
                }
            }

            if (budget >= 500)
            {
                if (season == "Summer")
                {
                    var price = budget * 0.90;
                    Console.WriteLine("Luxury class");
                    Console.WriteLine(String.Format("Jeep - {0:0.00}", price));
                }
                else if (season == "Winter")
                {
                    var price = budget * 0.90;
                    Console.WriteLine("Luxury class");
                    Console.WriteLine(String.Format("Jeep - {0:0.00}", price));
                }
            }

            //var budget = double.Parse(Console.ReadLine());
            //var season = Console.ReadLine();

            //if (budget <= 100)
            //{
            //    Console.WriteLine("Economy class");
            //    if (season == "Summer")
            //    {
            //        Console.WriteLine($"Cabrio - {budget * 0.35:f2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Jeep - {budget * 0.65:f2}");
            //    }
            //}
            //else if (budget > 100 && budget <= 500)
            //{
            //    Console.WriteLine("Compact class");
            //    if (season == "Summer")
            //    {
            //        Console.WriteLine($"Cabrio - {budget * 0.45:f2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Jeep - {budget * 0.80:f2}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Luxury class");
            //    Console.WriteLine($"Jeep - {budget * 0.90:f2}");
            //}


        }
    }
}
