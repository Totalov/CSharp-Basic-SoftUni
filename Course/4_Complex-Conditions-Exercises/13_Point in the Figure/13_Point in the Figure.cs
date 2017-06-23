using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var xofPoint = int.Parse(Console.ReadLine());
            var yOfPoint = int.Parse(Console.ReadLine());


            var x1 = 3 * h;
            var y1 = h;
            var x2 = h;
            var y2 = 4 * h;

            var insideFirstCase = xofPoint > 0 && xofPoint < x1 && yOfPoint > 0 && yOfPoint < y1;
            var insideSecondCase = xofPoint > h && xofPoint < 2 * h && yOfPoint > 0 && yOfPoint < y2;

            var onBorderFirstCase = xofPoint >= 0 && xofPoint <= x1 && yOfPoint >= 0 && yOfPoint <= h;
            var onBorderSecondCase = xofPoint >= h && xofPoint <= 2 * h && (yOfPoint == 0 || (yOfPoint >= h && yOfPoint <= y2));

            if (insideFirstCase)
            {
                Console.WriteLine("inside");
            }
            else if (insideSecondCase)
            {
                Console.WriteLine("inside");
            }
            else if (onBorderFirstCase)
            {
                Console.WriteLine("border");
            }
            else if (onBorderSecondCase)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }

        }
    }
}
