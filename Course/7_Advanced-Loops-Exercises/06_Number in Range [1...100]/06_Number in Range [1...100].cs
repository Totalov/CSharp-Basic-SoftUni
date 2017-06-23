using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Number_in_Range__1._._._100_
{
    class Program
    {
        static void Main(string[] args)
        {
            int validNumber = int.Parse(Console.ReadLine());
         
            while (validNumber < 1 || validNumber > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine("Please enter a number in the range [0, 100]");
                validNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is {validNumber}");
        }
    }
}
