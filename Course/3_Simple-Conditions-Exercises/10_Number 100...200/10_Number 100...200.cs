using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Number_100._._._200
{
    class Program
    {
        static void Main(string[] args)
        {
            var digit = int.Parse(Console.ReadLine());

            if (digit < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (digit <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (digit >= 201)
            {
                Console.WriteLine("Greater than 200");
            }

        }
    }
}
