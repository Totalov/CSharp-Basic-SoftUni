using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());
            //double bonusi = 0;

            //if (num <= 100 )
            //{
            //    bonusi = 5;
            //}
           
            //else 
            //{
            //    bonusi = num * 0.2;
            //}

            //if (num > 1000)
            //{
            //  bonusi = num * 0.1;
            
            //}

            //if (num % 2 == 0)
            //{
            //    bonusi ++ ;
            //}

            //if (num % 10 == 5 )
            //{
            //    bonusi +=2;
            //}

            //Console.WriteLine(bonusi);
            //Console.WriteLine(bonusi + num);

            double num = double.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (num <= 100)
            {
                bonusPoints = 5;
            }

            else
            {
                bonusPoints = num * 0.2;
            }

            if (num > 1000)
            {
                bonusPoints = num * 0.1;

            }

            if (num % 2 == 0)
            {
               bonusPoints++;
            }

            if (num % 10 == 5)
            {
                bonusPoints += 2;
            }



            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints + num);
        }
    }
}
