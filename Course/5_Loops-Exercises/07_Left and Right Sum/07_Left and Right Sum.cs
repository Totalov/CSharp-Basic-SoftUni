using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //var n = int.Parse(Console.ReadLine());

            //var leftSum = 0;
            //var rightSum = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    var currentNumber = int.Parse(Console.ReadLine());

            //    leftSum += currentNumber;
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    var currentNumber = int.Parse(Console.ReadLine());

            //    rightSum += currentNumber;
            //}

            //if (rightSum == leftSum)
            //{
            //    Console.WriteLine("Yes, sum = " + rightSum);
            //}
            //else
            //{
            //    Console.WriteLine("No, diff = " + Math.Abs(rightSum - leftSum));
            //}

            var n = int.Parse(Console.ReadLine());

            var leftSum = 0;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                leftSum += currentNumber;
            }


            var rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                rightSum += currentNumber;
            }

            if (leftSum == rightSum) Console.WriteLine($"Yes, sum= {rightSum}");
            else
            {
                var diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff= , { diff}");
            }

        }
    }
}
