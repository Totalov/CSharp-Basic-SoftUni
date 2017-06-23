using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
      

            if (product == "banana" || product == "kiwi" || product == "apple" || product == "cherry"
                || product == "lemon" || product == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "tomato" || product == "pepper" || product == "carrot" || product == "cucumber")
            {
                Console.WriteLine("vegetable");

            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
