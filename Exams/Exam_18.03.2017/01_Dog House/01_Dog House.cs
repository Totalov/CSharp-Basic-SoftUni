using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = double.Parse(Console.ReadLine());
            var B = double.Parse(Console.ReadLine());

            var twoSidesArea = A * (A / 2) * 2;

            var squareBackWall = (A / 2) * (A / 2);
            var triangleBackWall = ((A / 2) * (B - (A / 2))) / 2;
            var backWallArea = squareBackWall + triangleBackWall;

            var entrance = (A / 5) * (A / 5);
            var frontWallArea = backWallArea - entrance;

            var areaWalls = twoSidesArea + backWallArea + frontWallArea;

            var greenPaint = areaWalls / 3;

            var roofArea = A * (A / 2) * 2;

            var redPaint = roofArea / 5;

            Console.WriteLine(String.Format("{0:0.00}", greenPaint));
            Console.WriteLine(String.Format("{0:0.00}", redPaint));

            //var sideA = double.Parse(Console.ReadLine());
            //var sideB = double.Parse(Console.ReadLine());
            //var halfSideA = sideA / 2;


            //var areaOfRoof = sideA * halfSideA * 2;

            //var areaOfSides = areaOfRoof;

            //var backSqareArea = halfSideA * halfSideA;
            //var backTriangleArea = (halfSideA * (sideB - halfSideA)) / 2;
            //var backArea = backSqareArea + backTriangleArea;

            //var frontSquareSide = sideA / 5;
            //var frontSquareArea = frontSquareSide * frontSquareSide;
            //var frontArea = backArea - frontSquareArea;

            //var totalNotRoofArea = frontArea + backArea + areaOfSides;

            //var greenPaintQuantity = totalNotRoofArea / 3;
            //var redPaintQuantity = areaOfRoof / 5;
            //Console.WriteLine($"{greenPaintQuantity:f2}");
            //Console.WriteLine($"{redPaintQuantity:f2}");

        }
    }
}
