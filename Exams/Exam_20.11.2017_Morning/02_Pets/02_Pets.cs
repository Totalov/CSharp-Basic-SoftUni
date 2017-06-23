using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberDaysOut = int.Parse(Console.ReadLine());
            var leftFoodKg = int.Parse(Console.ReadLine());
            var leftDogFootKgDay = double.Parse(Console.ReadLine());
            var leftCatFootKgDay = double.Parse(Console.ReadLine());
            var leftTurtleFootGramsDay = double.Parse(Console.ReadLine());

            var neededFoodDog = leftDogFootKgDay * numberDaysOut;
            var neededFoodCat = leftCatFootKgDay * numberDaysOut;
            var neededFoodTurtle = (leftTurtleFootGramsDay * numberDaysOut) / 1000;

            var allFoodNeeded = neededFoodDog + neededFoodCat + neededFoodTurtle;

            var foodLeft = 0.0;
            var foodNotEnought = 0.0;

            if (leftFoodKg >= allFoodNeeded)
            {
                foodLeft = Math.Truncate(leftFoodKg - allFoodNeeded); //закръгля към по-ниско, може и с Math.Floor
                Console.WriteLine("{0} kilos of food left." , foodLeft);
            }
            else
            {
                foodNotEnought = Math.Ceiling(allFoodNeeded - leftFoodKg); // закръгля към по-високо
                Console.WriteLine("{0} more kilos of food are needed.", foodNotEnought);

            }

        }
    }
}
