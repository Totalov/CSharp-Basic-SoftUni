using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var reminder = (num % 2);
            if (reminder == 0)
            {
                Console.WriteLine("even");

            }

            else

                Console.WriteLine("odd");
        }
    }
}
