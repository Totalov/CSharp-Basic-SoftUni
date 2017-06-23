using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_House_Price
{
    class Program
    {
        static void Main(string[] args)
        {

            var areaSmallestRoom = double.Parse(Console.ReadLine());
            var areaKitchen = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            var areaBathroom = areaSmallestRoom / 2;
            var areaSecondRoom = areaSmallestRoom * 1.1;
            var areaThirdrRoom = areaSecondRoom * 1.1;

            var areaAllHouse = (areaSmallestRoom + areaKitchen + areaBathroom + areaSecondRoom + areaThirdrRoom) * 1.05;

            var allPrice = areaAllHouse * price;

            Console.WriteLine("{0:F2}" , allPrice);


        }
    }
}
