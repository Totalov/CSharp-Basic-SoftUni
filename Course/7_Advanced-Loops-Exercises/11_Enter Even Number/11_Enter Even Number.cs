using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            //var n = 0;

            //while (true)
            //{
            //    Console.Write("Enter even number: ");
            //    n = int.Parse(Console.ReadLine());
            //    if (n % 2 == 0)
            //        break; // even number -> exit from the loop
            //    Console.WriteLine("The number is not even.");
            //}
            //Console.WriteLine("Even number entered: {0}", n);

            Console.Write("Enter even number: ");
            int a;
            while (int.TryParse(Console.ReadLine(), out a ) == false || a % 2 != 0 )
            {
                Console.WriteLine("The number is not even.");
                Console.Write("Enter even number: ");
            }
            Console.WriteLine("Even number entered: {0}", a);
        }
    }
}