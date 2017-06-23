using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var height = 4 * n - 2;
            var width = 12 * n - 5;


            for (int i = 1; i <= 2 * n; i++)
            {
                var numberOfHashTag = i * 6 - 5;
                var numberOfDots = (width - numberOfHashTag) / 2;
                Console.Write(new string('.', numberOfDots));
                Console.Write(new string('#', numberOfHashTag));
                Console.WriteLine(new string('.', numberOfDots));
            }

            var numberOfDotsInSecondHalf = 3;
            for (int i = 0; i < n - 2; i++)
            {
                var numberOfDieses = width - numberOfDotsInSecondHalf * 2;
                Console.Write("|");
                Console.Write(new string('.', numberOfDotsInSecondHalf - 1));
                Console.Write(new string('#', numberOfDieses));
                Console.WriteLine(new string('.', numberOfDotsInSecondHalf));
                numberOfDotsInSecondHalf += 3;
            }

            for (int i = 0; i < n - 1; i++)
            {
                var numberOfDieses = width - numberOfDotsInSecondHalf * 2;
                Console.Write("|");
                Console.Write(new string('.', numberOfDotsInSecondHalf - 1));
                Console.Write(new string('#', numberOfDieses));
                Console.WriteLine(new string('.', numberOfDotsInSecondHalf));
            }

            //var numberOfDiesesPesho = width - numberOfDotsInSecondHalf * 2;
            //Console.Write("@");
            //Console.Write(new string('.', numberOfDotsInSecondHalf - 1));
            //Console.Write(new string('#', numberOfDiesesPesho));
            //Console.WriteLine(new string('.', numberOfDotsInSecondHalf));


            //#region First Part

            //for (int i = 0; i < 2 * n; i++)
            //{
            //    Console.WriteLine(new string('.', (width - 1)/ 2 - 3 * i) + new string('#', 1 + 6 * i) +
            //        new string('.', (width - 1) / 2 - 3 * i));
            //}

            //#endregion

            //#region Second Part

            //var hashtagsSecondPart = width - 6;

            //for (int i = 0; i < n - 2; i++)
            //{
            //    Console.WriteLine("|" + new string('.', (width - hashtagsSecondPart - 4) + 3 * i) +
            //        new string('#', (width - 6) - 6 * i) + new string('.', (width - hashtagsSecondPart - 3) + 3 * i));
            //}

            //#endregion

            //for (int i = 0; i < n; i++)
            //{
            //    var numberOfDotsInSecondHalf = 3;
            //    var numberOfDiesesPesho = width - numberOfDotsInSecondHalf * 2;
            //    Console.Write("@");
            //    Console.Write(new string('.', numberOfDotsInSecondHalf - 1));
            //    Console.Write(new string('#', numberOfDiesesPesho));
            //    Console.WriteLine(new string('.', numberOfDotsInSecondHalf));
            //}


















        }
    }
}
