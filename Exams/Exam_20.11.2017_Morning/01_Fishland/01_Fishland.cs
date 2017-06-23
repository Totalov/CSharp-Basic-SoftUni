using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceSkumria = double.Parse(Console.ReadLine());
            var priceCaca = double.Parse(Console.ReadLine());
            var kilogramsPalamud = double.Parse(Console.ReadLine());
            var kilogramsSafrid = double.Parse(Console.ReadLine());
            var kilogramsMidi = int.Parse(Console.ReadLine());

            var pricePalamud = priceSkumria * 1.6;
            var sumPalamud = pricePalamud * kilogramsPalamud;
            var priceSafrid = priceCaca * 1.8;
            var sumSafrid = priceSafrid * kilogramsSafrid;
            var sumMidi = kilogramsMidi * 7.50;

            var sumAll = sumPalamud + sumSafrid + sumMidi;

            Console.WriteLine("{0:F2}", sumAll);




        }
    }
}
