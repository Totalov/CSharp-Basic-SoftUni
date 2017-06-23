using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitOne = int.Parse(Console.ReadLine());
            int digitTwo = int.Parse(Console.ReadLine());
            int digitThree = int.Parse(Console.ReadLine());

            if (digitOne == digitTwo && digitOne == digitThree)
            {
                Console.WriteLine("yes");
            }
            else

            {
                Console.WriteLine("no");
            }

        }

    }
}


