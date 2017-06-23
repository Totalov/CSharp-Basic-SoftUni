using System;

namespace _02_Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var availableMoney = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var lenght = double.Parse(Console.ReadLine());
            var side = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var priseOneTile = double.Parse(Console.ReadLine());
            var sumMaster = Double.Parse(Console.ReadLine());

            var x = (width * lenght) / (side * h / 2);


            var total = Math.Ceiling(x) + 5;
            var y = total * priseOneTile + sumMaster;


            if (y <= availableMoney)
            {

                Console.WriteLine("{0:f2} lv left.", availableMoney - y);

            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", y - availableMoney);
            }
        }
    }
}
