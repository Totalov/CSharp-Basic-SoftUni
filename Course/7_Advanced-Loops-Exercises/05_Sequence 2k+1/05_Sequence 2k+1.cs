using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());         

            //for (int num = 1; num <= n; num = 2* num +1)
            //{
            //    Console.WriteLine(num);
            //}

            int n = int.Parse(Console.ReadLine());
            var i = 1;

            while (i <= n)
            {
                Console.WriteLine(i);
                i = i * 2 + 1;
            }
        }
    }
}
