﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse(Console.ReadLine());
            //var currentNumber = 1;
            //var row = 1;

            //while (currentNumber <= number)
            //{
            //    for (int i = 0; i < row && currentNumber <= number; i++)
            //    {
            //        Console.Write(currentNumber + " ");
            //        currentNumber++;
            //    }
            //    row++;
            //    Console.WriteLine();

            var n = int.Parse(Console.ReadLine());
            var num = 1;
            for (var row = 1; row <= n; row++)
            {
                for (var col = 1; col <= row; col++)
                {
                    if (col > 1) Console.Write(" ");
                    Console.Write(num);
                    num++;
                    if (num > n) break;
                }
                Console.WriteLine();
                if (num > n) break;
            }
        }

    }
}