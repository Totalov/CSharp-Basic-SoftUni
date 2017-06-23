using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            int rows = (n / 2) + 4;
            int cols = (2 * n) - 1;

            #region First Rows

            Console.WriteLine("@" + new string(' ', n - 2) + "@" + new string(' ', n - 2) + "@");
            Console.WriteLine("**" + new string(' ', n - 3) + "*" + new string(' ', n - 3) + "**");

            #endregion

            #region Middle Part

            for (int i = 0; i < (n / 2) - 2 ; i++)
            {
                Console.Write("*");
                Console.Write(new string('.',1 + i));
                Console.Write("*");
                Console.Write(new string(' ', (n - 5) - 2 * i));
                Console.Write("*");
                Console.Write(new string('.', 1 + 2 * i));
                Console.Write("*");
                Console.Write(new string(' ', (n - 5) - 2 * i));
                Console.Write("*");
                Console.Write(new string('.', 1 + i));
                Console.WriteLine("*");
            }

            #endregion

            #region Middle Rows

            Console.WriteLine("*" + new string('.', (n / 2) - 1) + "*" + new string('.', n - 3) + "*" + new string('.', (n / 2) - 1) + "*");
            Console.WriteLine("*" + new string('.', (n / 2) ) + new string('*', (n / 2) - 2) + "." + new string('*', (n / 2 - 2)) + new string('.', (n / 2)) + "*") ;


            #endregion

            #region Last Rows

            Console.WriteLine(new string('*', cols));
            Console.WriteLine(new string('*', cols));

            #endregion
        }
    }
}
