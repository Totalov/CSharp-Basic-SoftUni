using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine().ToLower();
            var typeOfGroup = Console.ReadLine().ToLower();
            var numberStudents = int.Parse(Console.ReadLine());
            var numberNights = int.Parse(Console.ReadLine());

            var sport = "";            
            var Price = 0.0;
           

            if (season == "winter" && typeOfGroup == "girls")
            {
                sport = "Gymnastics";
                Price = 9.60;
            }
            else if (season == "winter" && typeOfGroup == "boys")
            {
                sport = "Judo";
                Price = 9.60;
            }
            else if (season == "winter" && typeOfGroup == "mixed")
            {
                sport = "Ski";
                Price = 10;
            }

            if (season == "spring" && typeOfGroup == "girls")
            {
                sport = "Athletics";
                Price = 7.20;
            }
            else if (season == "spring" && typeOfGroup == "boys")
            {
                sport = "Tennis";
                Price = 7.20;
            }
            else if (season == "spring" && typeOfGroup == "mixed")
            {
                sport = "Cycling";
                Price = 9.50;
            }

            if (season == "summer" && typeOfGroup == "girls")
            {
                sport = "Volleyball";
                Price = 15;
            }
            else if (season == "summer" && typeOfGroup == "boys")
            {
                sport = "Football";
                Price = 15;
            }
            else if (season == "summer" && typeOfGroup == "mixed")
            {
                sport = "Swimming";
                Price = 20;
            }

            var sum = numberStudents * numberNights * Price;

            if (numberStudents >= 10 && numberStudents < 20)
                {
                    sum *= 0.95;
                }
                else if (numberStudents >= 20 && numberStudents < 50)
                {
                    sum *= 0.85;
                }
                else if (numberStudents >= 50)
                {
                    sum *= 0.5;
                }

            


            Console.WriteLine($"{sport} {sum:F2} lv.");

        }
    }
}
