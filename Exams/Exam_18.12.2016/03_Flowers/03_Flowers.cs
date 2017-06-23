using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var chrysantems = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var tulips = int.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();

            var prise = 0.00;
            var flowers = chrysantems + roses + tulips;

            if (season == "summer" || season == "spring")
            {
                prise = chrysantems * 2 + roses * 4.10 + tulips * 2.5;

                if (day == "y")
                {
                    prise *= 1.15;
                }

                if (tulips > 5 && season == "spring")
                {
                    prise *= 0.95;
                }
                if (flowers > 20)
                {
                    prise *= 0.80;
                    Console.WriteLine("{0:F2}", prise + 2);
                }
                else
                {
                    Console.WriteLine("{0:F2}", prise + 2);
                }
                         
                 
            }


            if (season == "winter" || season == "autumn")
            {
                prise = chrysantems * 3.75 + roses * 4.50 + tulips * 4.15;

                if (day == "y")
                {
                    prise *= 1.15;
                }

                if (roses >= 10 && season == "winter")
                {
                    prise *= 0.90;
                }
                if (flowers > 20)
                {
                    prise *= 0.80;
                    Console.WriteLine("{0:F2}", prise + 2);
                }
                else
                {
                    Console.WriteLine("{0:F2}", prise + 2);
                }

                
            }

        }
    }
}
