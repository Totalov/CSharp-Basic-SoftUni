using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var sum = 0;

            do
            {
                var lastDigit = number % 10;     //Това дава последната цифра от едно число !
                sum += lastDigit;
                number /= 10;

            } while (number > 0 );

            Console.WriteLine(sum);
        }
    }
}
