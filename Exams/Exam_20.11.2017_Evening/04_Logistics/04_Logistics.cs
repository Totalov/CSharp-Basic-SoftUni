using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberLoad = int.Parse(Console.ReadLine());

            var persentBus = 0.0;
            var persentTruck = 0.0;
            var persentTrain = 0.0;
            var totalpricebus = 0.0;
            var totalpricetruck = 0.0;
            var totalpricetrain = 0.0;
            var allLoads = 0.0;
            var pricePerTone = 0.0;
            var truck = 0.0;
            var bus = 0.0;
            var train = 0.0;

            for (int i = 0; i < numberLoad; i++)
            {
                var tonesOfLoad = int.Parse(Console.ReadLine());
                allLoads += tonesOfLoad;

                if (tonesOfLoad <= 3)
                {
                    bus = tonesOfLoad * 200;
                    totalpricebus += bus;
                    persentBus += tonesOfLoad;
                }

                if (tonesOfLoad >= 4 && tonesOfLoad <= 11)
                {
                    truck = tonesOfLoad * 175;                
                    totalpricetruck += truck;
                    persentTruck += tonesOfLoad;
                }


                if (tonesOfLoad >= 12)
                {
                    train = tonesOfLoad * 120;
                    totalpricetrain += train;
                    persentTrain += tonesOfLoad;
                }

            }

            pricePerTone = (totalpricebus + totalpricetruck + totalpricetrain) / allLoads;

            Console.WriteLine("{0:F2}", pricePerTone);
            Console.WriteLine("{0:F2}%", persentBus / allLoads * 100);
            Console.WriteLine("{0:F2}%", persentTruck / allLoads * 100);
            Console.WriteLine("{0:F2}%", persentTrain / allLoads * 100);

         

        }
    }
}
