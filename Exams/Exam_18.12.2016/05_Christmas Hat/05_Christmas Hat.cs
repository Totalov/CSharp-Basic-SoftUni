using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Да се напише програма, която прочита от конзолата цяло число N и 
            //  чертае коледна шапка с ширина 4 * n + 1 колони 
            //  и височина 2 * n + 5 реда като в примерите по-долу.  
            //  Входът се чете от конзолата – едно цяло число N в интервала [3…100].

            //                        4     ......./|\.......      17
            //                              .......\|/.......
            //                              .......***.......
            //                              ......*-*-*......
            //                              .....*--*--*.....
            //                              ....*---*---*....
            //                              ...*----*----*...
            //                              ..*-----*-----*..
            //                              .*------*------*.
            //                              *-------*-------*
            //                              *****************
            //                              *.*.*.*.*.*.*.*.*
            //                13            *****************
            //                              

            int n = int.Parse(Console.ReadLine());

            var width = 4 * n + 1;
            var hight = 2 * n + 5;

            #region First Rows

            Console.Write(new string('.', (width - 3)/2));
            Console.Write("/|\\");
            Console.WriteLine(new string('.', (width - 3)/2));

            Console.Write(new string('.', (width - 3)/2));
            Console.Write("\\|/");
            Console.WriteLine(new string('.',( width - 3)/2));

            #endregion

            #region Middle Part
          
                for (int j = 0; j < 2 * n ; j++)
                {

                    Console.Write(new string('.', (width - 3) / 2 - j));
                    Console.Write("*");
                    Console.Write(new string('-', + j));
                    Console.Write("*");
                    Console.Write(new string('-', + j));
                    Console.Write("*");
                    Console.Write(new string('.', (width - 3) / 2 - j));

                    Console.WriteLine();
                }
        

            #endregion

            #region Last Rows

            Console.WriteLine(new string('*', width));

            for (int i = 0; i < 2 * n ; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");

            Console.WriteLine(new string('*', width));

            #endregion
        }
    }
}
