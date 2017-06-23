using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceTrip = double.Parse(Console.ReadLine());
            var numberPuzzles = int.Parse(Console.ReadLine());
            var numberTalkingDolls = int.Parse(Console.ReadLine());
            var numberBears = int.Parse(Console.ReadLine());
            var numberMinions = int.Parse(Console.ReadLine());
            var numberTracks = int.Parse(Console.ReadLine());


            var pricePuzzle = 2.6;
            var priceTalkingDolls = 3;
            var priceBear = 4.10;
            var priceMinion = 8.20;
            var priceTrack = 2;

            var TotalPrice = (pricePuzzle * numberPuzzles) + (priceTalkingDolls * numberTalkingDolls) +
                (priceBear * numberBears) + (priceMinion * numberMinions) + (priceTrack * numberTracks);

            var numberToys = numberPuzzles + numberTalkingDolls + numberBears + numberMinions + numberTracks;
        

            if (numberToys >= 50)
            {
                TotalPrice *= 0.75;
            }

            TotalPrice *= 0.90;

            if (TotalPrice >= priceTrip)
            {
                var left = TotalPrice - priceTrip;
                Console.WriteLine($"Yes! {left:F2} lv left.");
            }
            else if (TotalPrice < priceTrip)
            {
                var notEnought = priceTrip - TotalPrice;
                Console.WriteLine($"Not enough money! {notEnought:F2} lv needed.");
            }
            
        }
    }
}
