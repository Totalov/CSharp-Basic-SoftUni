using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var width = 5 * n;
            var leftDashes = 3 * n;

            #region First Part

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('-', width - 2 * n) + "*" + new string('-', +i) + "*" +
                     new string('-', 2 * n - 2 - i));
            }

            #endregion

            #region Middle Part

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('*', width - 2 * n) + "*" + new string('-', n - 1) + "*" +
                     new string('-', n - 1));
            }

            #endregion

            #region Last Part

            //if (n>2)
            //{
            //    for (int i = 0; i < n / 2; i++)
            //    {
            //        Console.WriteLine(new string('-', width - 2 * n - i) + "*"
            //            + new string('-', n - 1 + 2 * i) + "*" + new string('-', n - 1 - i));
            //    }
            //}
            //else if (n==2)
            //{
            //    for (int i = 0; i < n / 2; i++)
            //    {
            //        Console.WriteLine(new string('-', width - 2 * n - i) + "***" + new string('-', n - 1 - i));
            //    }
            //}

            for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine(new string('-', width - 2 * n - i) + "*"
                        + new string('-', n - 1 + 2 * i) + "*" + new string('-', n - 1 - i));
                }


            #endregion

            #region Last Row

            //for (int i = 0; i < 1; i++)
            //{
            //    Console.Write(new string('*', width - 2 * n) + "*" + new string('-', n - 1) + "*" +
            //         new string('-', n - 1));

            //}
            //Console.WriteLine();
            Console.WriteLine("{0}{1}{2}", new string('-', 3 * n - (n / 2) + 1), new string('*', 5 * n - (3 * n - (n / 2) + 1) - (n - n / 2)), new string('-', n - n / 2));

            #endregion
        }
    }
}
