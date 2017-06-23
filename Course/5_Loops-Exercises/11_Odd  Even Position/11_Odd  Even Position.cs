using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {

            double oddSum = 0;
            double evenSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            int numbers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numbers; i++)
            {
                if (i % 2 == 0)
                {
                    double currentNumber = double.Parse(Console.ReadLine());
                    evenSum += currentNumber;

                    if (currentNumber < evenMin)
                    {
                        evenMin = currentNumber;
                    }
                    if (currentNumber > evenMax)
                    {
                        evenMax = currentNumber;
                    }
                }
                else
                {
                    double currentNumber = double.Parse(Console.ReadLine());
                    oddSum += currentNumber;
                    if (currentNumber < oddMin)
                    {
                        oddMin = currentNumber;
                    }
                    if (currentNumber > oddMax)
                    {
                        oddMax = currentNumber;
                    }

                }
            }
            if (numbers == 0)
            {
                Console.WriteLine("OddSum=" + oddSum);
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
                Console.WriteLine("EvenSum=" + evenSum);
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else if ((evenMin == double.MaxValue) || (evenMax == Double.MinValue))
            {
                Console.WriteLine("OddSum=" + oddSum);
                Console.WriteLine("OddMin=" + oddMin);
                Console.WriteLine("OddMax=" + oddMax);
                Console.WriteLine("EvenSum=" + evenSum);
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("OddSum=" + oddSum);
                Console.WriteLine("OddMin=" + oddMin);
                Console.WriteLine("OddMax=" + oddMax);
                Console.WriteLine("EvenSum=" + evenSum);
                Console.WriteLine("EvenMin=" + evenMin);
                Console.WriteLine("EvenMax=" + evenMax);
            }

        }
    }
}