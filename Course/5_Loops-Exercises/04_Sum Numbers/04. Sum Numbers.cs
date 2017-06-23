using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the numbers:");

            //var sum = 0;

            //for (var i = 0; i < n; i++)
            //{
            //    var num = int.Parse(Console.ReadLine());

            //    sum = sum + num;
            //}

            //Console.WriteLine("sum = " + sum);


            var numberOfNumbers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers:");

            var sum = 0.0;

            for (var i = 0; i < numberOfNumbers; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());

                sum += currentNumber;
              
            }

            Console.WriteLine("sum = " + sum);

        }
    }
}
