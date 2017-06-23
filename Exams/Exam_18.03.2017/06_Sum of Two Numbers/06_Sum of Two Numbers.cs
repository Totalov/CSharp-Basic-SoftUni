using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var combinationExists = false;

            var counter = 0;
            var sum = 0;

            for (int i = start; i <= end; i++)
            {
                for (int g = start; g <= end; g++)
                {
                    counter++;
                    sum = i + g;
                    if (sum == magicNumber)
                    {
                        combinationExists = true;
                        Console.WriteLine($"Combination N:{counter} ({i} + {g} = {sum})");
                        break;
                    }
                }
                if (sum == magicNumber)
                {
                    break;
                }
            }

            if (combinationExists == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }

        }
    }
}
