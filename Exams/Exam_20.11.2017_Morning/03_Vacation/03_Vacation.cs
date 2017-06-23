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
            var numberAdults = int.Parse(Console.ReadLine());
            var numberStudents = int.Parse(Console.ReadLine());
            var nightStayed = int.Parse(Console.ReadLine());
            var typeOfTransport = Console.ReadLine().ToLower();

            var allGroup = numberAdults + numberStudents;
            var sumTransport = 0.0;
            //var sumBus = 0.0;
            //var sumShip = 0.0;
            //var sumAirPlane = 0.0;

            if (typeOfTransport == "train")
            {
                sumTransport = (numberAdults * 24.99 + numberStudents * 14.99) * 2; ;
                if (allGroup >= 50)
                {
                    sumTransport *= 0.5;
                }
            }
            else if (typeOfTransport == "bus")
            {
                sumTransport = (numberAdults * 32.50 + numberStudents * 28.50) * 2;
            }
            else if (typeOfTransport == "boat")
            {
                sumTransport = (numberAdults * 42.99 + numberStudents * 39.99) * 2;
            }
            else if (typeOfTransport == "airplane")
            {
                sumTransport = (numberAdults * 70.00 + numberStudents * 50.00) * 2;
            }

            var sumHotel = nightStayed * 82.99;
            var sumCommission = (sumTransport + sumHotel) * 0.10;

            var neededSumForHoliday = sumHotel + sumTransport + sumCommission;

            Console.WriteLine("{0:F2}", neededSumForHoliday);

        }
    }
}
