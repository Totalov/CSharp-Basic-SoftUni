﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {

            var age = double.Parse(Console.ReadLine());
            var sex = Console.ReadLine();

            if (sex == "m")
            {
                if (age >= 16)

                {
                    Console.WriteLine("Mr.");

                }
                else if (age <= 16)

                {
                    Console.WriteLine("Master");
                }
            }

            if (sex == "f")
            {
                if (age >= 16)

                {
                    Console.WriteLine("Ms.");

                }
                else if (age <= 16)

                {

                    Console.WriteLine("Miss");
                }

            }

        }
    }
}
