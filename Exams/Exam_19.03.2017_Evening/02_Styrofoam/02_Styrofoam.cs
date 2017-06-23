using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var areaHouse = double.Parse(Console.ReadLine());
            var numberWindows = double.Parse(Console.ReadLine());
            var SquareMeterFoaminPackage = double.Parse(Console.ReadLine());
            var priceSquareMeterFoam = double.Parse(Console.ReadLine());

            var areaWindows = numberWindows * 2.4;
            var areaEnd = (areaHouse - areaWindows) * 1.1;
            //Console.WriteLine(areaEnd);
            var neededPackageFoam = (areaEnd / SquareMeterFoaminPackage);
            neededPackageFoam = Math.Ceiling(neededPackageFoam);
            //Console.WriteLine(neededPackageFoam);
            var priceNeededPackageFoam = neededPackageFoam * priceSquareMeterFoam;
            var moneyLeft = budget - priceNeededPackageFoam;
            var moneyNotEnought = priceNeededPackageFoam - budget;
            //Console.WriteLine(moneyLeft);


            if (budget > priceNeededPackageFoam)
            {
                Console.WriteLine(String.Format("Spent: {0:0.00}" , priceNeededPackageFoam));
                Console.WriteLine(String.Format("Left: {0:0.00}" , moneyLeft));
            }
            else
            {
                Console.WriteLine(String.Format("Need more: {0:0.00}" , moneyNotEnought));
            }

        }

    }
}
