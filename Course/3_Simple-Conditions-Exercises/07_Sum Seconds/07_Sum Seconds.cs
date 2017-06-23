using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {

            //int racerOneTime = int.Parse(Console.ReadLine());
            //int racerTwoTime = int.Parse(Console.ReadLine());
            //int racerThreeTime = int.Parse(Console.ReadLine());

            //int sumTimeAllRacersSeconds = (racerOneTime + racerTwoTime + racerThreeTime);
            //var minutes = 0;

            //if (sumTimeAllRacersSeconds <= 59)
            //{
            //    minutes++; sumTimeAllRacersSeconds = sumTimeAllRacersSeconds - 60;
            //}
            //if (sumTimeAllRacersSeconds <= 119)
            //{
            //    minutes += 2; sumTimeAllRacersSeconds = sumTimeAllRacersSeconds - 120;
            //}

            //if (sumTimeAllRacersSeconds <= 179)
            //{
            //    minutes += 3; sumTimeAllRacersSeconds = sumTimeAllRacersSeconds - 180;
            //}

            //if (sumTimeAllRacersSeconds < 10)
            //{
            //    Console.WriteLine(minutes + ":" + "0" + sumTimeAllRacersSeconds);
            //}
            //else
            //{
            //    Console.WriteLine(minutes + ":" + sumTimeAllRacersSeconds);
            //}

            var firstSeconds = int.Parse(Console.ReadLine());
            var secondSeconds = int.Parse(Console.ReadLine());
            var thirdSeconds = int.Parse(Console.ReadLine());

            var totalSeconds = firstSeconds + secondSeconds + thirdSeconds;

            var minutes = totalSeconds / 60;
            var seconds = minutes % 60;

            if (totalSeconds <= 59)
            {
                Console.WriteLine($"0:{totalSeconds:D2}");
            }

            else if (totalSeconds <= 119)
            {
                var secTwo = totalSeconds - 60;
                Console.WriteLine($"1:{secTwo:D2}");
            }
            else if (totalSeconds <= 179)
            {
                var secThree = totalSeconds - 120;
                Console.WriteLine($"2:{secThree:D2}");  //  Ако искам водеша нула използвам след промелнивата "D2" - допълва едма нула отпред
            }
            else if (totalSeconds < 10)
            {
                Console.WriteLine($"0{totalSeconds}");
            }

        }
    }
}
