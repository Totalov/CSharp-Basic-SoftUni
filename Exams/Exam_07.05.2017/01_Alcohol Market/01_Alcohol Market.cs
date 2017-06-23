using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceWhisky = double.Parse(Console.ReadLine());
            var beerLitres = double.Parse(Console.ReadLine());
            var wineLitres = double.Parse(Console.ReadLine());
            var rakiaLitres = double.Parse(Console.ReadLine());
            var wiskyLitres = double.Parse(Console.ReadLine());

            var priceRakia = priceWhisky * 0.5;
            var priceWine = priceRakia * 0.6;
            var priceBeer = priceRakia * 0.2;

            var sumRakia = rakiaLitres * priceRakia;
            var sumWine = wineLitres * priceWine;
            var sumBeer = beerLitres * priceBeer;
            var sumWisky = wiskyLitres * priceWhisky;

            var sumAll = sumRakia + sumWine + sumBeer + sumWisky;

            Console.WriteLine($"{sumAll:F2}");
        }
    }
}
