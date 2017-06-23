using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacityStadium = int.Parse(Console.ReadLine());
            var numberOfFans = int.Parse(Console.ReadLine());

            var A = 0.0;
            var B = 0.0;
            var V = 0.0;
            var G = 0.0;
 
            double numberOfFanD = numberOfFans;
            double capacityStadiumD = capacityStadium;

            var AllSectorsPercent = (numberOfFanD / capacityStadiumD) * 100;

            for (int i = 0; i < numberOfFans; i++)
            {
                var sector = Console.ReadLine();

                if (sector == "A")
                {
                    A++;                 
                }
                else if (sector == "B")
                {
                    B++;
                }
                else if (sector == "V")
                {
                    V++;
                }
                else if (sector == "G")
                {
                    G++;
                }
            }


            var A_Persent = (A / numberOfFans) * 100;
            var B_Persent = (B / numberOfFans) * 100;
            var V_Persent = (V / numberOfFans) * 100;
            var G_Persent = (G / numberOfFans) * 100;


            Console.WriteLine($"{A_Persent:F2}%");
            Console.WriteLine($"{B_Persent:F2}%");
            Console.WriteLine($"{V_Persent:F2}%");
            Console.WriteLine($"{G_Persent:F2}%");
            Console.WriteLine($"{AllSectorsPercent:F2}%");




        }
    }
}
