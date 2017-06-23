using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Sign_STOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //                3                       ...._______....     n * 5
            //                                        ...//_____\\...
            //                                        ..//_______\\..
            //                                        .//_________\\.
            //                                        //___STOP!___\\
            //                                        \\___________//
            //                                        .\\_________//.
            //                                        ..\\_______//..
            //                                        


            int n = int.Parse(Console.ReadLine());

            #region First Rows

            Console.WriteLine(new string('.', n + 1) + new string('_', 2 * n + 1) + new string('.', n + 1));

            #endregion

            #region Middle Part One

            for (var i = 0; i < n ; i++)
            {
                Console.Write(new string('.', n - i));
                Console.Write("//");
                Console.Write(new string('_', (2 * n - 1) + 2 * i));
                Console.Write("\\\\");
                Console.WriteLine(new string('.', n - i));
            }
            #endregion

            #region Middle Row

            Console.WriteLine("//" + new string('_', 2 * n - 3) + "STOP!" 
                + new string('_', 2 * n - 3) + "\\\\");

            #endregion

            #region Middle Part Two and Last Row

            for (var i = 0; i < n ; i++)
            {
                Console.Write(new string('.', 0 + i));
                Console.Write("\\\\");               
                Console.Write(new string('_', (4 * n - 1) - 2 * i));             
                Console.Write("//");
                Console.WriteLine(new string('.', 0 + i));
            }
            #endregion
        }
    }
}
