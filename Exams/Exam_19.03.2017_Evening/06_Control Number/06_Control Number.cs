using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());

            var sum = 0;
            var counter = 0;

            for (int firstNumber = 1; firstNumber <= N; firstNumber++)
            {
                for (int secondNumber = M; secondNumber >=1; secondNumber--)
                {
                    sum += (firstNumber * 2 + secondNumber * 3);
                    counter++;

                    if (sum >= controlNumber)
                    {
                        break;
                    }                  
                }
                if (sum >= controlNumber)
                {
                    break;
                }
            }
            Console.WriteLine($"{counter} moves");
            if (sum >= controlNumber)
            {
                Console.WriteLine($"Score: {sum} >= {controlNumber}");
            }
        }
    }
}
