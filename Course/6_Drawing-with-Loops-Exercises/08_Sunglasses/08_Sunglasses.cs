using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {        

            var n = int.Parse(Console.ReadLine());


            #region first line

            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));

            #endregion


            #region Middle 

            var noseIndex = (n - 1) / 2 - 1;
            for (int row = 0; row < n - 2; row++)
            {
                if (row != noseIndex)
                {
                    Console.Write("*");
                    Console.Write(new string('/', 2 * n - 2));
                    Console.Write("*");
                    Console.Write(new string(' ', n));
                    Console.Write("*");
                    Console.Write(new string('/', 2 * n - 2));
                    Console.WriteLine("*");
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', 2 * n - 2));
                    Console.Write("*");
                    Console.Write(new string('|', n));
                    Console.Write("*");
                    Console.Write(new string('/', 2 * n - 2));
                    Console.WriteLine("*");
                }
            }

            #endregion


            #region last line

            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));

            #endregion


        }
    }
}
