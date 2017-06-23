using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());


            var counter = 0;
           

            for (int i = start; i >= end; i--)
            {
                for (int j = start; j >= end; j--)
                {
                    var sum = i + j;
                    counter++;

                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combinations N:{counter} ({i} + {j} = {magicNumber})");
                        return;
                    }
                                                                                                                                         
                }
                
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");


            //int aSTART = int.Parse(Console.ReadLine());
            //int bEND = int.Parse(Console.ReadLine());
            //int cSTOP = int.Parse(Console.ReadLine());

            //int counter = 0;
            //bool lamp = false;

            //for (int cycle1 = aSTART; cycle1 >= bEND; cycle1--)
            //{
            //    for (int cycle2 = aSTART; cycle2 >= bEND; cycle2--)
            //    {
            //        counter++;
            //        if (bEND < aSTART && cycle1 + cycle2 == cSTOP)
            //        {
            //            Console.WriteLine($"Combination N:{counter} ({cycle1} + {cycle2} = {cSTOP})");
            //            lamp = true;
            //            break;
            //        }
            //    }
            //    if (lamp == true)
            //    {
            //        break;
            //    }
            //}
            //if (lamp == false)
            //{
            //    Console.WriteLine($"{counter} combinations - neither equals {cSTOP}");
            //}

        }
    }
}

