using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededHours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var numberOfWorkers = int.Parse(Console.ReadLine());

            var daysAfterEducation = days * 0.90;
            var hoursForWork = daysAfterEducation * 8;

            var extraHours = numberOfWorkers * 2 * days;

            var allHours = Math.Floor(hoursForWork + extraHours);

            var hoursLeft = 0.0;
            var hoursNotEnought = 0.0;

            if (neededHours <= allHours)
            {
                hoursLeft = allHours - neededHours;
                Console.WriteLine("Yes!{0} hours left.", hoursLeft);

            }
            else 
            {
              
                hoursNotEnought = neededHours - allHours;
                Console.WriteLine("Not enough time!{0} hours needed.", hoursNotEnought);

            }

        }
    }
}
