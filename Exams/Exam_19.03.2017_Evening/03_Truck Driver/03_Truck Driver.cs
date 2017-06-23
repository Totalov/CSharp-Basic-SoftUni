using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = (Console.ReadLine());
            var kilometresPerMonth = double.Parse(Console.ReadLine());

            if (season == "Spring" || season == "Autumn")
            {
                if (kilometresPerMonth <= 5000)
                {
                    var sum = kilometresPerMonth * 0.75 * 4;
                    var sumWithoutTaxes = sum - (sum * 0.1);
                    Console.WriteLine(String.Format("{0:0.00}", sumWithoutTaxes));
                }
                else if (kilometresPerMonth <= 10000)
                {
                    var sum = kilometresPerMonth * 0.95 * 4;
                    var sumWithoutTaxes = sum - (sum * 0.1);
                    Console.WriteLine(String.Format("{0:0.00}", sumWithoutTaxes));
                }
                else if (kilometresPerMonth <= 20000)
                {
                    var sum = kilometresPerMonth * 1.45 * 4;
                    var sumWithoutTaxes = sum - (sum * 0.1);
                    Console.WriteLine(String.Format("{0:0.00}", sumWithoutTaxes));
                }
            }

            if (season == "Summer")
            {
                if (kilometresPerMonth <= 5000)
                {
                    var sum = kilometresPerMonth * 0.90 * 4;
                    var sumWithoutTaxes = sum - (sum * 0.1);
                    Console.WriteLine(String.Format("{0:0.00}", sumWithoutTaxes));
                }
                else if (kilometresPerMonth <= 10000)
                {
                    var sum = kilometresPerMonth * 1.10 * 4;
                    var sumWithoutTaxes = sum - (sum * 0.1);
                    Console.WriteLine(String.Format("{0:0.00}", sumWithoutTaxes));
                }
                else if (kilometresPerMonth <= 20000)
                {
                    var sum = kilometresPerMonth * 1.45 * 4;
                    var sumWithoutTaxes = sum - (sum * 0.1);
                    Console.WriteLine(String.Format("{0:0.00}", sumWithoutTaxes));
                }
            }

            if (season == "Winter")
            {
                if (kilometresPerMonth <= 5000)
                {
                    var sum = kilometresPerMonth * 1.05 * 4;
                    var sumWithoutTaxes = sum - (sum * 0.1);
                    Console.WriteLine(String.Format("{0:0.00}", sumWithoutTaxes));
                }
                else if (kilometresPerMonth <= 10000)
                {
                    var sum = kilometresPerMonth * 1.25 * 4;
                    var sumWithoutTaxes = sum - (sum * 0.1);
                    Console.WriteLine(String.Format("{0:0.00}", sumWithoutTaxes));
                }
                else if (kilometresPerMonth <= 20000)
                {
                    var sum = kilometresPerMonth * 1.45 * 4;
                    var sumWithoutTaxes = sum - (sum * 0.1);
                    Console.WriteLine(String.Format("{0:0.00}", sumWithoutTaxes));
                }

            }
        }
    }
}
