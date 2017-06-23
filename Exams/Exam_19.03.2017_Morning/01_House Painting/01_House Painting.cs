using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var sidewall = x * y;
            var windowSide = 1.5 * 1.5;
            var sidewallArea = (2 * sidewall) - (2 * windowSide);
            var backwall = x * x;
            var doorFront = 1.2 * 2;
            var areaFrontAndBackWalls = (2 * backwall) - doorFront;
            var areaHouse = sidewallArea + areaFrontAndBackWalls;

            var greenPaint = areaHouse / 3.4;

            var twoRectanglesRoofArea = 2 * (x * y);
            var twoTrianglesRoofArea = 2 * ((x * h) / 2);
            var areaRoof = twoRectanglesRoofArea + twoTrianglesRoofArea;

            var redPaint = areaRoof / 4.3;

            Console.WriteLine(String.Format("{0:0.00}" ,greenPaint));
            Console.WriteLine(String.Format("{0:0.00}" ,redPaint));
        }
    }
}
