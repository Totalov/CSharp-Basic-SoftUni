using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareMeterGrape = int.Parse(Console.ReadLine());
            var grapePerSquareMeter = double.Parse(Console.ReadLine());
            var neededLitresWine = int.Parse(Console.ReadLine());
            var numberWorkers = int.Parse(Console.ReadLine());

            var AllGrape = squareMeterGrape * grapePerSquareMeter;
            var grapeForWine = (AllGrape * 0.40) / 2.5 ;

            if (grapeForWine >= neededLitresWine)
            {
                var left = (grapeForWine - neededLitresWine);
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Truncate(grapeForWine)} liters."); 
                var litresPerWorker = (left / numberWorkers);
                Console.WriteLine($"{Math.Ceiling(left)} liters left -> {Math.Ceiling(litresPerWorker)} liters per person.");
            }
            else
            {
                var notEnought = (neededLitresWine - grapeForWine);

                Console.WriteLine($"It will be a tough winter! More {Math.Truncate(notEnought)} liters wine needed.");
            }



        }
    }
}
