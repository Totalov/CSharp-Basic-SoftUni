using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //var s = Console.ReadLine();
            //var sum = 0;

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == 'a') sum++;
            //    else if (s[i] == 'e') sum += 2;
            //    else if (s[i] == 'i') sum += 3;
            //    else if (s[i] == 'o') sum += 4;
            //    else if (s[i] == 'u') sum += 5;
            //}

            //Console.WriteLine("Vowels sum = " + sum);

            var word = Console.ReadLine();
            var sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                var currentLetter = word[i];
                switch (currentLetter)
                {
                    case 'a': sum++;
                        break;
                    case 'e': sum += 2;
                        break; 
                    case 'i': sum += 3;
                        break; 
                    case 'o': sum += 4;
                        break;
                    case 'u': sum += 5;
                        break;
                }
            }

            Console.WriteLine("Vowels sum = " + sum);

        }
    }
}
