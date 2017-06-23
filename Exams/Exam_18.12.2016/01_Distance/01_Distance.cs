using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var beginingSpeed = double.Parse(Console.ReadLine());
            var firstTimeMinute = double.Parse(Console.ReadLine())   / 60.0;
            var secondTimeMinute = double.Parse(Console.ReadLine()) / 60.0;
            var thirdTimeMinute = double.Parse(Console.ReadLine()) / 60.0;


            var distance = 0.0;
            distance = beginingSpeed * firstTimeMinute;
            distance += beginingSpeed * 1.10 * secondTimeMinute;
            distance +=  beginingSpeed * 1.10 * 0.95 * thirdTimeMinute;


            Console.WriteLine("{0:F2}" , distance);
          
        }
    }
}
