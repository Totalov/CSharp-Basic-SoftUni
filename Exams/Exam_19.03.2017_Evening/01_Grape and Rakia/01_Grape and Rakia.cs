using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = double.Parse(Console.ReadLine());
            var kgFromSquareMeter = double.Parse(Console.ReadLine());
            var waste = double.Parse(Console.ReadLine());

            var pureGrape = (area * kgFromSquareMeter) - waste;
            
            var rakia = (0.45 * pureGrape);
            var litreRakia = rakia / 7.5;
            var moneyEarnRakia = litreRakia * 9.8;


            var sellGrape = (0.55 * pureGrape) ;
            var moneyEarnGrape = sellGrape * 1.5;

            Console.WriteLine(String.Format("{0:0.00}", moneyEarnRakia));
            Console.WriteLine(String.Format("{0:0.00}" ,moneyEarnGrape));

        }
    }
}
