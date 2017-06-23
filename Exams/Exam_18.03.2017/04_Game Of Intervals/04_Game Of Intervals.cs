using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var moveGame = int.Parse(Console.ReadLine());

            var zeroTo9 = 0.0;
            var tenTo19 = 0.0;
            var twentyTo29 = 0.0;
            var thirtyTo39 = 0.0;
            var fortyTo50 = 0.0;
            var invalid = 0.0;

            var result = 0.0;

            for (int i = 0; i < moveGame; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());

                if (currentNumber >= 0 && currentNumber <= 9)
                {
                    result += currentNumber * 0.2;
                    zeroTo9 ++;
                }
                else if (currentNumber >= 10 && currentNumber <= 19)
                {
                    result += currentNumber * 0.3;
                    tenTo19 ++;
                }
                else if (currentNumber >= 20 && currentNumber <= 29)
                {
                    result += currentNumber * 0.4;
                    twentyTo29 ++;
                }
                else if (currentNumber >= 30 && currentNumber <= 39)
                {
                    result += 50;
                    thirtyTo39 ++;
                }
                else if (currentNumber >= 40 && currentNumber <= 50)
                {
                    result += 100;
                    fortyTo50 ++;
                }
                else if (currentNumber < 0 || currentNumber > 50)
                {
                    result /= 2;
                    invalid++;
                }
            }

            double zeroTo9Persent = (zeroTo9 / moveGame) * 100;
            double tenTo19Persent = (tenTo19 / moveGame) * 100;
            double twentyTo29Persent = (twentyTo29 / moveGame) * 100;
            double thirtyTo39Persent = (thirtyTo39 / moveGame) * 100;
            double fortyTo50Persent = (fortyTo50 / moveGame) * 100;
            double invalidPersent = (invalid / moveGame) * 100;

            Console.WriteLine("{0:f2}", result);
            Console.WriteLine("From 0 to 9: {0:f2}%", zeroTo9Persent);
            Console.WriteLine("From 10 to 19: {0:f2}%", tenTo19Persent);
            Console.WriteLine("From 20 to 29: {0:f2}%", twentyTo29Persent);
            Console.WriteLine("From 30 to 39: {0:f2}%", thirtyTo39Persent);
            Console.WriteLine("From 40 to 50: {0:f2}%", fortyTo50Persent);
            Console.WriteLine("Invalid numbers: {0:f2}%", invalidPersent);

            //var numberOfMoves = int.Parse(Console.ReadLine());

            //var points = 0.0;
            //var firstInterval = 0.0;
            //var secondInterval = 0.0;
            //var thirdInterval = 0.0;
            //var forthInterval = 0.0;
            //var fifthInterval = 0.0;
            //var sixthterval = 0.0;

            //for (int move = 0; move < numberOfMoves; move++)
            //{
            //    var currentNumber = int.Parse(Console.ReadLine());
            //    if (currentNumber >= 0 && currentNumber <= 9)
            //    {
            //        points += currentNumber * 0.2;
            //        firstInterval++;
            //    }
            //    else if (currentNumber >= 10 && currentNumber <= 19)
            //    {
            //        points += currentNumber * 0.3;
            //        secondInterval++;
            //    }
            //    else if (currentNumber >= 20 && currentNumber <= 29)
            //    {
            //        points += currentNumber * 0.4;
            //        thirdInterval++;
            //    }
            //    else if (currentNumber >= 30 && currentNumber <= 39)
            //    {
            //        points += 50;
            //        forthInterval++;
            //    }
            //    else if (currentNumber >= 40 && currentNumber <= 50)
            //    {
            //        points += 100;
            //        fifthInterval++;
            //    }
            //    else
            //    {
            //        points /= 2;
            //        sixthterval++;
            //    }

            //}

            //Console.WriteLine($"{points:f2}");
            //Console.WriteLine($"From 0 to 9: {firstInterval / numberOfMoves * 100:f2}%");
            //Console.WriteLine($"From 10 to 19: {secondInterval / numberOfMoves * 100:f2}%");
            //Console.WriteLine($"From 20 to 29: {thirdInterval / numberOfMoves * 100:f2}%");
            //Console.WriteLine($"From 30 to 39: {forthInterval / numberOfMoves * 100:f2}%");
            //Console.WriteLine($"From 40 to 50: {fifthInterval / numberOfMoves * 100:f2}%");
            //Console.WriteLine($"Invalid numbers: {sixthterval / numberOfMoves * 100:f2}%");



        }
    }
}
