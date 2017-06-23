using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            //////+ - - - +            
            //////| - - - |
            //////| - - - |
            //////| - - - |
            //////+ - - - +

            var n = int.Parse(Console.ReadLine());
           
            #region first Line

            Console.Write("+ ");

            for (int i = 0; i < n-2; i++)
            {
                Console.Write("- ");
            }
            
            Console.WriteLine("+");
            #endregion

            #region middle

            for (int row = 0; row < n - 2; row++)
            {

                Console.Write("| ");

                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write("- ");
                }

                Console.WriteLine("|");
            }

            #endregion

            #region last line

            Console.Write("+ ");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }

            Console.WriteLine("+");

            #endregion

            //for (int row = 0; row < n; row++)
            //{

            //}
        }
    }
}
