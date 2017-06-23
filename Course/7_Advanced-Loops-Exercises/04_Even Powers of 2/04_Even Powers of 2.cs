using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());

            int num = 1;

            for (int i = 0; i <= n; i += 2)
            {
                var currentValue = Math.Pow(2, i);
                Console.WriteLine(currentValue);

                //Console.WriteLine(num);
                //num = num * 2 * 2;
            }
        }
    }
}
