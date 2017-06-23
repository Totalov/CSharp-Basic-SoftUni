using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfGroups = int.Parse(Console.ReadLine());

            var car = 0.0;
            var minivan = 0.0;
            var smallBus = 0.0;
            var bigBus = 0.0;
            var train = 0.0;
            var allParticipants = 0.0;

            //var percentCar = 0.0;
            //var percentMinivan = 0.0;
            //var percentSmallBus = 0.0;
            //var percentBigBus = 0.0;
            //var percentTrain = 0.0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                var numberOfParticipants = int.Parse(Console.ReadLine());
                allParticipants += numberOfParticipants;

                if (numberOfParticipants <= 5)
                {
                    car += numberOfParticipants;
                }
               if (numberOfParticipants >= 6  && numberOfParticipants <= 12)
                {
                    minivan += numberOfParticipants;
                }
               if (numberOfParticipants >= 13 && numberOfParticipants <= 25)
                {
                    smallBus += numberOfParticipants;
                }
                if (numberOfParticipants >= 26 && numberOfParticipants <= 40)
                {
                    bigBus += numberOfParticipants;
                }
                if (numberOfParticipants >= 41)
                {
                    train += numberOfParticipants;
                }

            }

          var percentCar = (car / allParticipants) * 100;
          var percentMinivan = (minivan / allParticipants) * 100;
          var percentSmallBus = (smallBus / allParticipants) * 100;
          var percentBigBus = (bigBus / allParticipants) * 100;
          var percentTrain = (train / allParticipants) * 100;

            Console.WriteLine("{0:F2}%", percentCar);
            Console.WriteLine("{0:F2}%", percentMinivan);
            Console.WriteLine("{0:F2}%", percentSmallBus);
            Console.WriteLine("{0:F2}%", percentBigBus);
            Console.WriteLine("{0:F2}%", percentTrain);
        }
    }
}
