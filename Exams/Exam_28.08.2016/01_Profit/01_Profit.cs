using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingDaysinMonth = int.Parse(Console.ReadLine());
            var earnMoneyPerDay = double.Parse(Console.ReadLine());
            var USDtoBGN = double.Parse(Console.ReadLine());

            var monthSalary = workingDaysinMonth * earnMoneyPerDay;
            var earnMoneyperYear = monthSalary * 12 + monthSalary * 2.5;
            var cleanYearProfit = (earnMoneyperYear * 0.75) * USDtoBGN;

            var profitPerDay = cleanYearProfit / 365;

            Console.WriteLine("{0:F2}", profitPerDay);

        }
    }
}
