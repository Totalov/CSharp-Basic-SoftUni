using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = double.Parse(Console.ReadLine());

            var electricity = 0.0;
            

            for (double i = 0; i < months; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());

                electricity += currentNumber;
            }

            var water = 20.0 * months;
            var internet = 15.0 * months;
            var other = (electricity + water + internet) * 1.2;
            var average = (electricity + water + internet + other) / months;

       
            Console.WriteLine(String.Format("Electricity: {0:0.00} lv", electricity));
            Console.WriteLine(String.Format("Water: {0:0.00} lv", water));
            Console.WriteLine(String.Format("Internet: {0:0.00} lv" , internet));
            Console.WriteLine(String.Format("Other: {0:0.00} lv" , other));
            Console.WriteLine(String.Format("Average: {0:0.00} lv" , average));

        }
    }
}
