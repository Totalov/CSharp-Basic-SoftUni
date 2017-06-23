using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberCaps = double.Parse(Console.ReadLine());
            var numberWorkers = double.Parse(Console.ReadLine());
            var numberDays = double.Parse(Console.ReadLine());

            var workingHours = numberWorkers * numberDays * 8;
            var capsManufactured = Math.Truncate(workingHours / 5);
            var capsLosses = numberCaps - capsManufactured;
            var moneyLosses = capsLosses * 4.2;

            var extraCaps = capsManufactured - numberCaps;
            var extraMoney = extraCaps * 4.2;

            if (capsManufactured > numberCaps)
            {
                Console.WriteLine(String.Format("{0:0.00} extra money", extraMoney));
            }
            else if (capsManufactured < numberCaps)
            {
                Console.WriteLine(String.Format("Losses: {0:0.00}", moneyLosses));
            }
        }
    }
}
