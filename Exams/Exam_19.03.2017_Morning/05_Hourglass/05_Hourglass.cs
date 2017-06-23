using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която прочита от конзолата цяло число N и чертае пясъчен
            // часовник с височина и ширина – 2 * n + 1.   
            // Входът е цяло нечетно число N в интервала [3…51] 
            //
            // Да се отпечатат на конзолата 2 * n + 1 текстови редове, 
            // изобразяващи пясъчен часовник – точно както в примерите.

            ////////////////////////////  7         ***************
            ////////////////////////////            .*           *.
            ////////////////////////////            ..*@@@@@@@@@*..
            ////////////////////////////            ...*@@@@@@@*...
            ////////////////////////////            ....*@@@@@*....
            ////////////////////////////            .....*@@@*.....
            ////////////////////////////            ......*@*......
            ////////////////////////////            .......*.......
            ////////////////////////////            ......*@*......
            ////////////////////////////            .....* @ *.....
            ////////////////////////////            ....*  @  *....
            ////////////////////////////            ...*   @   *...
            ////////////////////////////            ..*    @    *..
            ////////////////////////////            .*@@@@@@@@@@@*.
            ////////////////////////////            ***************

            int n = int.Parse(Console.ReadLine());

            #region First Line 

            Console.WriteLine(new string('*', 2 * n + 1));
            Console.WriteLine("." + "*" + new string(' ', 2 * n - 3) + "*" + ".");

            #endregion

            #region First Part

            for (var i = 0; i < n - 2 ; i++)
            {

                Console.Write("..");
                Console.Write(new string('.', + i));
                Console.Write("*");
                Console.Write(new string('@', (2 * n - 5) - 2 * i));
                Console.Write("*");
                Console.Write("..");
                Console.WriteLine(new string('.',  + i));
            }

            #endregion

            #region Middle Row

            Console.WriteLine(new string('.', n) + "*" + new string('.', n));

            #endregion

            #region Last Part

            Console.Write(new string('.', n - 1));
            Console.Write("*");
            Console.Write("@");
            Console.Write("*");
            Console.WriteLine(new string('.', n - 1));

            for (var j = 0; j < n - 3; j++)
            {
                Console.Write(new string('.', n - 2 - j));
                Console.Write("*");
                Console.Write(new string(' ', + j));
                Console.Write(" @ ");
                Console.Write(new string(' ', +  j));
                Console.Write("*");
                Console.WriteLine(new string('.', n - 2 - j));

            }           

            #endregion

            #region Last Line 

            Console.WriteLine("." + "*" + new string('@', 2 * n - 3) + "*" + ".");
            Console.WriteLine(new string('*', 2 * n + 1));

            #endregion
        }
    }
}
