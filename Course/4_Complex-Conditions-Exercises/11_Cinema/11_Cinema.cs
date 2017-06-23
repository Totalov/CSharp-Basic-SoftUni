using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            var movieType = 1.00;

            var fullHallPlaces = rows * columns;

            

            if (movie == "premiere")
            {
                movieType = 12.00;
            }
            else if (movie == "normal")
            {
                movieType = 7.50;

            }
            else if (movie == "discount")
            {
                movieType = 5.00;
            }


            var moneyEarnedFullHall = fullHallPlaces * movieType;

            Console.WriteLine("{0:f2} leva", moneyEarnedFullHall);

        }
    }
}
