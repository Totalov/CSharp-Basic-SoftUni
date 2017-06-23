using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = double.Parse(Console.ReadLine());
            var seniors = double.Parse(Console.ReadLine());
            var route = Console.ReadLine().ToLower();

            var moneyDonate = 0.0;
            var bikers = juniors + seniors; ;

            if (route == "trail")
            {
                moneyDonate = (juniors * 5.50 + seniors * 7.00) * 0.95;

            }
            else if (route == "downhill")
            {
                moneyDonate = (juniors * 12.25 + seniors * 13.75) * 0.95;
            }
            else if (route == "road")
            {
                moneyDonate = (juniors * 20.00 + seniors * 21.50) * 0.95;

            }

            else if (route == "cross-country")
            {
                moneyDonate = (juniors * 8.00 + seniors * 9.50) * 0.95;
            }

            if (route == "cross-country" && bikers >= 50 )
            {
                moneyDonate *= 0.75;
            }

            Console.WriteLine("{0:F2}", moneyDonate);

        }
    }
}

