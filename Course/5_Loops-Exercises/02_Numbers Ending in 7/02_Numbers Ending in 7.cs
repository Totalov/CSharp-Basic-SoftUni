﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 10 == 7)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            for (int i = 7; i <= 1000; i+=10)
            {
                Console.WriteLine(i);
            }
        }
    }
}
