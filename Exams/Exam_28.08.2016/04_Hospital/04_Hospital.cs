using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var periodDays = int.Parse(Console.ReadLine());

            var treatedPatients = 0.0;
            var unTreatedPatients = 0.0;
            var countOfDoctors = 7;

            for (int day = 1; day <= periodDays; day++)
            {
                var currentPatients = int.Parse(Console.ReadLine());

                if ((day % 3 == 0) && (unTreatedPatients > treatedPatients))
                {
                    countOfDoctors++;
                }

                if (currentPatients > countOfDoctors)
                {
                    treatedPatients += countOfDoctors;
                    unTreatedPatients += currentPatients - countOfDoctors;
                }
                else
                {
                    treatedPatients += currentPatients;
                }
            }

            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", unTreatedPatients);

        }
    }
}
