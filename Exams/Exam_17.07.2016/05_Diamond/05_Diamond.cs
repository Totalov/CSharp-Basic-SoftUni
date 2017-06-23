using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var width = 5 * n;
            var lenght = 3 * n + 2;

            Console.WriteLine("{0}{1}{2}", new string('.', n), new string('*', 3 * n), (new string('.', n)));


            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('.', n - 1 - i), new string('.', 3 * n + 2 * i), (new string('.', n - 1 - i)));
            }


            Console.WriteLine(new string('*', width));


            for (int i = 0; i < 2 * n ; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('.', 1 + i), new string('.', width - 4 - 2 * i), (new string('.', 1 + i)));
            }


            Console.WriteLine("{0}{1}{2}", new string('.',2 * n + 1), new string('*', n - 2), (new string('.',2 * n + 1)));
        }
    }
}
