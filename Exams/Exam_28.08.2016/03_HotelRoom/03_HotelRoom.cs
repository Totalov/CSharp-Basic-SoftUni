using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            var numberOfNights = int.Parse(Console.ReadLine());

            var studio = 0.0;
            var apartment = 0.0;


            if (month == "may" || month == "october")
            {
                studio = 50;
                apartment = 65;
                if (numberOfNights > 14)
                {
                    studio *= 0.70;
                }
                else if ( numberOfNights > 7)
                {
                    studio *= 0.95;
                }
            }
            else if (month == "june" || month == "september")
            {
                studio = 75.20;
                apartment = 68.70;
                if ( numberOfNights > 14)
                {
                    studio *= 0.80;
                }
            }
            else if (month == "july" || month == "august")
            {
                studio = 76.00;
                apartment = 77.00;
            }

            if (numberOfNights > 14)
            {
                apartment *= 0.90;
            }

            var allApartmentPrice = apartment * numberOfNights;
            var allStudioPrice = studio * numberOfNights;

            Console.WriteLine("Apartment: {0:F2} lv.", allApartmentPrice);
            Console.WriteLine("Studio: {0:F2} lv.", allStudioPrice);
        }
    }
}
