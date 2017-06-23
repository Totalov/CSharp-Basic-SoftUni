using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Tasks_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}

            //for (int i = 100; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            var n = 12;


            for (int i = 0; i < n; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" * ");

                    for (int z = n - i - 1; z > 0; z--)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            for (int i = n; i > 0; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            var num = 2;

            var space = num - 1;

            for (int i = 1; i <= num; i++)
            {
                for (space = 1; space <= (num - i); space++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                for (int k = (i - 1); k >= 1; k--)
                {
                    Console.Write("*");
                }

            }

        }
    }
}

