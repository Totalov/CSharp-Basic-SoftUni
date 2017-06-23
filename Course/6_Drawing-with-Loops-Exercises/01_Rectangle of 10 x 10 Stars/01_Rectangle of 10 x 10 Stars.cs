using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (var row = 0; row < 10; row++)
            //{
            //    for (var col = 0; col < 10; col++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            for (int row = 0; row < 10; row++)
            {
                Console.WriteLine(new string('*', 10));
            }

        }
    }
}
