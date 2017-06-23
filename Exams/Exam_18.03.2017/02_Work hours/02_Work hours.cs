using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededHours = int.Parse(Console.ReadLine());
            var numberWorkers = int.Parse(Console.ReadLine());
            var workingDays = int.Parse(Console.ReadLine());

            var workingHours = numberWorkers * workingDays * 8;

            var hoursLeft = workingHours - neededHours;

            var hoursOvertime = neededHours - workingHours;

            var penaltyMoney = hoursOvertime * workingDays;

            if (workingHours > neededHours)
            {
                Console.WriteLine("{0} hours left", hoursLeft);
            }
            else if (workingHours < neededHours)
            {
                Console.WriteLine("{0} overtime", hoursOvertime);
                Console.WriteLine("Penalties: {0}", penaltyMoney);
            }

            //var neededHours = int.Parse(Console.ReadLine());
            //var numberOfWorkers = int.Parse(Console.ReadLine());
            //var numberOfWorkDays = int.Parse(Console.ReadLine());

            //var totalTimeFromWorkers = numberOfWorkers * numberOfWorkDays * 8;

            //if (totalTimeFromWorkers >= neededHours)
            //{
            //    var leftHours = totalTimeFromWorkers - neededHours;
            //    Console.WriteLine($"{leftHours} hours left");
            //}
            //else
            //{
            //    var overtime = neededHours - totalTimeFromWorkers;
            //    var penalites = overtime * numberOfWorkDays;

            //    Console.WriteLine($"{overtime} overtime");
            //    Console.WriteLine($"Penalties: {penalites}");
            //}

        }
    }
}
