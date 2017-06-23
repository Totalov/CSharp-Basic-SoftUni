using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeYear = Console.ReadLine();
            var pHolidays = double.Parse(Console.ReadLine());
            var hWeekends = double.Parse(Console.ReadLine());


            var gamesweekendsSofia = 48 - hWeekends;
            var weekendsInYear = gamesweekendsSofia * 3 / 4;
            var gamesSofiaHolidays = pHolidays * 2 / 3;

            var gamesweekendAndHolidaysSofiandBirthTown = weekendsInYear + hWeekends + gamesSofiaHolidays;

            var leapYear = gamesweekendAndHolidaysSofiandBirthTown + (0.15 * gamesweekendAndHolidaysSofiandBirthTown);

            if (typeYear == "leap")

            {

                Console.WriteLine(Math.Truncate(leapYear));

            }

            else if (typeYear == "normal")

            {
                Console.WriteLine(Math.Truncate(gamesweekendAndHolidaysSofiandBirthTown));

            }

        }
    }
}
