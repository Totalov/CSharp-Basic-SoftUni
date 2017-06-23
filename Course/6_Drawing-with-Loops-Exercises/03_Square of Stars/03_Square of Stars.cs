using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideOfSquare = int.Parse(Console.ReadLine());

            for (int row = 0; row < sideOfSquare; row++)
            {
                for (int col = 0; col < sideOfSquare; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
