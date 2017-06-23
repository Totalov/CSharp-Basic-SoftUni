using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = char.Parse(Console.ReadLine());
            var end = char.Parse(Console.ReadLine());
            var special = char.Parse(Console.ReadLine());
            var counter = 0;


            for (var firstLetter = start; firstLetter <= end; firstLetter++)
            {
                for (var secondLetter = start; secondLetter <= end; secondLetter++)
                {
                    for (var thirdLetter = start; thirdLetter <= end; thirdLetter++)
                    {
                        if (firstLetter != special && secondLetter != special && thirdLetter != special)
                        {
                            Console.Write($"{firstLetter}{secondLetter}{thirdLetter} ");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);

        }
    }
}
