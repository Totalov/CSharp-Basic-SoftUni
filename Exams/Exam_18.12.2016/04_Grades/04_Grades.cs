using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = int.Parse(Console.ReadLine());

            var allMarks = 0.0;
            var topStudents = 0.0;
            var goodStudents = 0.0;
            var middleStudents = 0.0;
            var failStudents = 0.0;

            for (int i = 0; i < students; i++)
            {
                var mark = double.Parse(Console.ReadLine());

                if (mark >= 2.00 && mark <= 2.99)
                {                   
                    failStudents++;
                    allMarks += mark;
                }
                else if (mark >= 3.00 && mark <= 3.99)
                {
                    
                    middleStudents++;
                    allMarks += mark;
                }
                else if (mark >= 4.00 && mark <= 4.99)
                {
                    
                    goodStudents++;
                    allMarks += mark;
                }
                else if (mark >= 5.00)
                {
                    
                    topStudents++;
                    allMarks += mark;
                }
                
            }



            double topStudentsPersent = (topStudents / students) * 100;
            double goodStudentsPersent = (goodStudents / students) * 100;
            double middleStudentsPersent = (middleStudents / students) * 100;
            double failStudentsPersent = (failStudents / students) * 100;
            double allMarksMiddle = allMarks / students;



            Console.WriteLine("Top students: {0:F2}%" , topStudentsPersent);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", goodStudentsPersent);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", middleStudentsPersent);
            Console.WriteLine("Fail: {0:F2}%", failStudentsPersent);
            Console.WriteLine("Average: {0:F2}", allMarksMiddle);



        }
    }
}
