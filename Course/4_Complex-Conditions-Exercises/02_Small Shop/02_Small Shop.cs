using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //var product = Console.ReadLine().ToLower();
            //var city = Console.ReadLine().ToLower();

            //double quantity = double.Parse(Console.ReadLine());

            //if (city == "sofia")

            //{
            //    if (product == "coffee") Console.WriteLine(quantity * 0.50);
            //    else if (product == "water") Console.WriteLine(quantity * 0.80);
            //    else if (product == "beer") Console.WriteLine(quantity * 1.20);
            //    else if (product == "sweets") Console.WriteLine(quantity * 1.45);
            //    else if (product == "peanuts") Console.WriteLine(quantity * 1.60);
            //}
            //else if (city == "plovdiv")
            //{
            //    if (product == "coffee") Console.WriteLine(quantity * 0.40);
            //    else if (product == "water") Console.WriteLine(quantity * 0.70);
            //    else if (product == "beer") Console.WriteLine(quantity * 1.15);
            //    else if (product == "sweets") Console.WriteLine(quantity * 1.30);
            //    else if (product == "peanuts") Console.WriteLine(quantity * 1.50);
            //}
            //else if (city == "varna")
            //{
            //    if (product == "coffee") Console.WriteLine(quantity * 0.45);
            //    else if (product == "water") Console.WriteLine(quantity * 0.70);
            //    else if (product == "beer") Console.WriteLine(quantity * 1.10);
            //    else if (product == "sweets") Console.WriteLine(quantity * 1.35);
            //    else if (product == "peanuts") Console.WriteLine(quantity * 1.55);

            string productName = Console.ReadLine();
            string cityName = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (productName == "coffee")
            {
                if (cityName == "Sofia")
                {
                    Console.WriteLine(quantity * 0.5);
                }
                else if (cityName == "Plovdiv")
                {
                    Console.WriteLine(quantity * 0.4);
                }
                else if (cityName == "Varna")
                {
                    Console.WriteLine(quantity * 0.45);
                }


            }
            else if (productName == "water")
            {
                if (cityName == "Sofia")
                {
                    Console.WriteLine(quantity * 0.8);
                }
                else if (cityName == "Plovdiv")
                {
                    Console.WriteLine(quantity * 0.7);
                }
                else if (cityName == "Varna")
                {
                    Console.WriteLine(quantity * 0.7);
                }
            }
            else if (productName == "beer")
            {
                if (cityName == "Sofia")
                {
                    Console.WriteLine(quantity * 1.2);
                }
                else if (cityName == "Plovdiv")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                else if (cityName == "Varna")
                {
                    Console.WriteLine(quantity * 1.10);
                }
            }
            else if (productName == "sweets")
            {
                if (cityName == "Sofia")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (cityName == "Plovdiv")
                {
                    Console.WriteLine(quantity * 1.30);
                }
                else if (cityName == "Varna")
                {
                    Console.WriteLine(quantity * 1.35);
                }
            }
            else if (productName == "peanuts")
            {
                if (cityName == "Sofia")
                {
                    Console.WriteLine(quantity * 1.60);
                }
                else if (cityName == "Plovdiv")
                {
                    Console.WriteLine(quantity * 1.50);
                }
                else if (cityName == "Varna")
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }

        }
    }
}
