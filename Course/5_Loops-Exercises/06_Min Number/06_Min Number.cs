using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var NumberOfNumbers = int.Parse(Console.ReadLine());

            var lowestNumber = int.MaxValue;

            for (int i = 0; i < NumberOfNumbers; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < lowestNumber)
                {
                    lowestNumber = currentNumber;
                }
            }

            Console.WriteLine(lowestNumber);
        }
    }
}
