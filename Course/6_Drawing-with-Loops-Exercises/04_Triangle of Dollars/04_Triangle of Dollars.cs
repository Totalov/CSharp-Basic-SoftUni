using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            ////$           
            ////$ $
            ////$ $ $
            ////$ $ $ $
            ////$ $ $ $ $

            for (int row = 1; row <= n; row++)
            {

                for (int col = 0; col < row ; col++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();               
            }
        }
    }
}
