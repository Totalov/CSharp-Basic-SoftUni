using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Rectangle_of_N_x_N_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideOfSquare = int.Parse(Console.ReadLine());

            for (int row = 0; row < sideOfSquare; row++)
            {
                Console.WriteLine(new string('*', sideOfSquare));
            }
        }
    }
}
