using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            //5! = 1 * 2 * 3 * 4 * 5;   Това е факториел !

            var factorial = 1;

            do
            {
                factorial = factorial * num;
                num--;

            } while (num > 1);

            Console.WriteLine(factorial);

        }
    }
}
