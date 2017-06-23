using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine().ToLower();
            var peopleInTheGroup = int.Parse(Console.ReadLine());

            if (category == "vip")
            {               

                if (peopleInTheGroup >=1 && peopleInTheGroup <=4)
                {
                    budget *= 0.25;
                }
                else if (peopleInTheGroup >= 5 && peopleInTheGroup <= 9)
                {
                    budget *= 0.40;
                }
                else if (peopleInTheGroup >= 10 && peopleInTheGroup <= 24)
                {
                    budget *= 0.50;
                }
                else if (peopleInTheGroup >= 25 && peopleInTheGroup <= 49)
                {
                    budget *= 0.60;
                }
                else if (peopleInTheGroup >= 50)
                {
                    budget *= 0.75;
                }
                var VIP = peopleInTheGroup * 499.99;
                var leftVIP = budget - VIP;
                if (budget >= VIP)
                {
                    
                    Console.WriteLine($"Yes! You have {leftVIP:F2} leva left.");
                }
                else
                {
                    var NotEnoughVip = VIP - budget;
                    Console.WriteLine($"Not enough money! You need {NotEnoughVip:F2} leva.");
                }

            }
            else if (category == "normal")
            {              

                if (peopleInTheGroup >= 1 && peopleInTheGroup <= 4)
                {
                    budget *= 0.25;
                }
                else if (peopleInTheGroup >= 5 && peopleInTheGroup <= 9)
                {
                  
                    budget *= 0.40;
                }
                else if (peopleInTheGroup >= 10 && peopleInTheGroup <= 24)
                {

                    budget *= 0.50;
                }
                else if (peopleInTheGroup >= 25 && peopleInTheGroup <= 49)
                {
                    budget *= 0.60;
                }
                else if (peopleInTheGroup >= 50)
                {
                    budget *= 0.75;
                }

                var Normal = peopleInTheGroup * 249.99;
                var leftNormal = budget - Normal;
                if (budget >= Normal)
                { 
                    Console.WriteLine($"Yes! You have {leftNormal:F2} leva left.");
                }
                else
                {
                    var NotEnoughNormal = Normal - budget;
                    Console.WriteLine($"Not enough money! You need {NotEnoughNormal:F2} leva.");
                }

            }
        

        }
    }
}
