using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var lection = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());

            var moneyForLecturers = budget / lection;

            var jelev = 0.0;
            var royal = 0.0;
            var roli = 0.0;
            var trofon = 0.0;
            var sino = 0.0;
            var otherLecturer = 0.0;


            for (int i = 0; i < lection; i++)
            {
                var name = Console.ReadLine().ToLower();

                if (name == "jelev")
                {
                    jelev += moneyForLecturers;
                }
                else if (name == "royal")
                {
                    royal += moneyForLecturers;
                }
                else if (name == "roli")
                {
                    roli += moneyForLecturers;
                }
                else if (name == "trofon")
                {
                    trofon += moneyForLecturers;
                }
                else if (name == "sino")
                {
                    sino += moneyForLecturers;
                }
                else
                {
                    otherLecturer += moneyForLecturers;
                }
            }

            Console.WriteLine("Jelev salary: {0:d2} lv", jelev);
            Console.WriteLine(String.Format("RoYaL salary: {0:0.00} lv" , royal));
            Console.WriteLine(String.Format("Roli salary: {0:0.00} lv", roli));
            Console.WriteLine(String.Format("Trofon salary: {0:0.00} lv", trofon));
            Console.WriteLine(String.Format("Sino salary: {0:0.00} lv", sino));
            Console.WriteLine(String.Format("Others salary: {0:0.00} lv", otherLecturer));

        }
    }
}
