using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //var n = int.Parse(Console.ReadLine());

            //var sumEven = 0;
            //var sumOdd = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    var currentNumber = int.Parse(Console.ReadLine());

            //    if (i % 2 == 0) sumOdd += currentNumber;
            //    else sumEven += currentNumber;

            //    //if (i % 2 != 0) sumOdd -= Math.Abs(currentNumber);
            //    //else sumEven -= Math.Abs(currentNumber);
            //}
            //if (sumOdd == sumEven)
            //{
            //    Console.WriteLine("Yes");
            //    Console.WriteLine("Sum = " + sumOdd);
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //    Console.WriteLine("Diff = " + Math.Abs(sumOdd - sumEven));
            //}

            var n = int.Parse(Console.ReadLine());

            var evenSum = 0;
            var oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + oddSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(oddSum - evenSum));
            }
        }
    }
}