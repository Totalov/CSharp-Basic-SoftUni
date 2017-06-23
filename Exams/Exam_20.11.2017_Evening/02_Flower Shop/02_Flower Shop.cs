using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnolies = int.Parse(Console.ReadLine());
            var hyacinthes = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var cactuses = int.Parse(Console.ReadLine());
            var priceGift = double.Parse(Console.ReadLine());

            var allPriceEarned = ((magnolies * 3.25) + (hyacinthes * 4.00) + (roses * 3.50) + (cactuses * 8.00)) * 0.95;

            if (allPriceEarned >= priceGift)
            {
                var leftMoney = Math.Truncate(allPriceEarned - priceGift); //става и с Math.Floor.
                Console.WriteLine("She is left with {0} leva.", leftMoney);
            }
            else
            {
                var borrowMoney = Math.Ceiling(priceGift - allPriceEarned);
                Console.WriteLine("She will have to borrow {0} leva.", borrowMoney);
            }          

        }
    }
}
