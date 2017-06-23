using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {            // 6     

            //+~~~~+.............  n - 2              //•	височина – 4 * n + 4 реда   
            //|\~~~~\............                //  •	ширина – 3 * N + 1 колони
            //|.\~~~~\...........
            //|..\~~~~\..........               // Да се отпечатат на конзолата 4 * n + 4 текстови редове
            //|...\~~~~\.........
            //|....\~~~~\........               //N {2.....50)
            //|.....\~~~~\.......
            //|......\~~~~\......
            //|.......\~~~~\.....
            //|........\~~~~\....
            //|.........\~~~~\...
            //|..........\~~~~\..
            //|...........\~~~~\.
            //|............\~~~~\
            //\............| ~~~~|
            //.\...........| ~~~~|
            //..\..........| ~~~~|
            //...\.........| ~~~~|
            //....\........| ~~~~|
            //.....\.......| ~~~~|
            //......\......| ~~~~|
            //.......\.....| ~~~~|
            //........\....| ~~~~|
            //.........\...| ~~~~|
            //..........\..| ~~~~|
            //...........\.| ~~~~|
            //............\| ~~~~|
            //.............+ ~~~~+

            var n = int.Parse(Console.ReadLine());

            #region First Row

            for (int row = 0; row < 1; row++)
            {
                Console.Write("+");
                Console.Write(new string('~', n - 2));
                Console.Write("+");
                Console.WriteLine(new string('.', 2 * n + 1));

            }
            #endregion

            #region First Part


            for (int i = 0; i < 2 * n + 1; i++)
            {

                Console.Write("|");
                Console.Write(new string('.', + i));
                Console.Write("\\");
                Console.Write(new string('~', n - 2));
                Console.Write("\\");
                Console.WriteLine(new string('.', 2 * n - i ));
            }

            #endregion

            #region Second Part

            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.Write(new string('.', + i ));
                Console.Write("\\");
                Console.Write(new string('.', 2 * n - i));
                Console.Write("|");
                Console.Write(new string('~', n - 2));
                Console.WriteLine("|");              
            }

            #endregion

            #region Last Row

            Console.Write(new string('.', 2 * n + 1));
            Console.Write("+");
            Console.Write(new string('~', n - 2));
            Console.WriteLine("+");
            
            #endregion

        }
    }
}
