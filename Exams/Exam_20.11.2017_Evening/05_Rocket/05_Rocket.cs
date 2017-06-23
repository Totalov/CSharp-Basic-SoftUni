using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Rocket
{
    class Program
    {
        static void Main(string[] args)
        {

            // Да се напише програма, която прочита от конзолата цяло четно число N 
            // и чертае ракета, като в примерите по-долу. 
            // Ракетата има ширина – 3 * N колони.
            // Входът се чете от конзолата и съдържа само едно цяло четно число в интервала [4…100]. 


            //                       6                ......../\........     3 * n - 2
            //                                        ......./  \.......
            //                                        ....../    \......
            //                                        ...../      \.....
            //                                        ..../        \....
            //                                        .../          \...
            //                                        ...************...     3 * n - 2 * n
            //                                        ...|\\\\\\\\\\|...
            //                                        ...|\\\\\\\\\\|...
            //                                        ...|\\\\\\\\\\|...
            //                                        ...|\\\\\\\\\\|...
            //                                        ...|\\\\\\\\\\|...
            //                                        ...|\\\\\\\\\\|...
            //                                        ...|\\\\\\\\\\|...
            //                                        ...|\\\\\\\\\\|...
            //                                        ...|\\\\\\\\\\|...
            //                                        ...|\\\\\\\\\\|...
            //                                        ...|\\\\\\\\\\|...
            //                                        ...|\\\\\\\\\\|...
            //                                        .../**********\...
            //                                        ../************\..
            //                                        ./**************\.


            int n = int.Parse(Console.ReadLine());

            var width = 3 * n;

            #region First Part

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', (width - 2) / 2 - i) + "/" + 
                    new string(' ', + 2 * i) + "\\" + new string('.', (width - 2) / 2 - i));
            }

            #endregion

            #region Middel Row

            Console.WriteLine(new string('.', (width - 2 * n)/2) + new string('*', 2 * n)
                + new string('.', (width - 2 * n)/2));

            #endregion

            #region Second Part

            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine(new string('.', (width - 2 * n) / 2 ) + "|" +
                    new string('\\', + 2 * n - 2) + "|" + new string('.', (width - 2 * n) / 2));
            }

            #endregion

            #region Last Part

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('.', (width - 2 * n) / 2 - i) + "/" +
                    new string('*', + (2 * n - 2) + 2 * i) + "\\" + new string('.', (width - 2 * n) / 2 - i));
            }

            #endregion




        }
    }
}
