using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = (Console.ReadLine());

            if (budget <= 1000)
            {
                if (season == "Summer")
                {
                    var camp = budget * 0.65;
                    Console.Write(String.Format("Alaska - Camp - {0:0.00}", camp));
                }
                else if (season == "Winter")
                {
                    var camp = budget * 0.45;
                    Console.Write(String.Format("Morocco - Camp - {0:0.00}", camp));
                }
            }

                if (budget > 1000 && budget <= 3000)
                {
                    if (season == "Summer")
                    {
                        var hut = budget * 0.80;
                        Console.Write(String.Format("Alaska - Hut - {0:0.00}", hut));
                    }
                    else if (season == "Winter")
                    {
                        var hut = budget * 0.60;
                        Console.Write(String.Format("Morocco - Hut - {0:0.00}", hut));
                    }
                }

                if (budget > 3000)
                {
                    if (season == "Summer")
                    {
                        var hotel = budget * 0.90;
                        Console.Write(String.Format("Alaska - Hotel - {0:0.00}", hotel));
                    }
                    else if (season == "Winter")
                    {
                        var hotel = budget * 0.90;
                        Console.Write(String.Format("Morocco - Hotel - {0:0.00}", hotel));
                    }
                }
            }
        }
    }
