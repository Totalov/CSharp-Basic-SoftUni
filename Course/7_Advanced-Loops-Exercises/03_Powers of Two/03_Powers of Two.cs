using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var num = 1;
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(num);
                num = num * 2 ;
            }
      
        }
    }
}
