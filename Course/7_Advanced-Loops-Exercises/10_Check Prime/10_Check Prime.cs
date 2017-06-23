using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var isPrime = "Prime";

            if (number < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {

                for (var i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = "Not Prime";
                        break;
                    }

                }
                Console.WriteLine(isPrime);

            }
            
                

                //var n = int.Parse(Console.ReadLine());
                //var prime = true;
                //for (var i = 2; i <= Math.Sqrt(n); i++)
                //    if (n % i == 0)
                //    {
                //        prime = false;
                //        break;
                //    }
                //if (prime) Console.WriteLine("Prime");
                //else Console.WriteLine("Not prime");


            }
        }
    }

