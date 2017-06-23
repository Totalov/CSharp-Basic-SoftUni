using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var dayOfWeek = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            var weekend = (dayOfWeek == "saturday" || dayOfWeek == "sunday");

            var workingDays = (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday"
                || dayOfWeek == "thursday" || dayOfWeek == "friday");

            var fruitCondition = fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" ||
                fruit == "pineapple" || fruit == "grapes";

          //  var pricefruit = -1.00;

            if (fruitCondition & workingDays)
            {
                if (fruit == "banana")
                {
                    var pricefruit = quantity * 2.5;
                    Console.WriteLine(String.Format("{0:0.00}", pricefruit));
                }
                else if (fruit == "apple")
                {
                    var pricefruit = quantity * 1.2;
                    Console.WriteLine(String.Format("{0:0.00}", pricefruit));
                }
                else if (fruit == "orange")
                {
                    var pricefruit = quantity * 0.85;
                    Console.WriteLine(String.Format("{0:0.00}", pricefruit));
                }
                else if (fruit == "grapefruit")
                {
                    var pricefruit = quantity * 1.45;
                    Console.WriteLine(String.Format("{0:0.00}", pricefruit));
                }
                else if (fruit == "kiwi")
                {
                    var pricefruit = quantity * 2.7;
                    Console.WriteLine(String.Format("{0:0.00}", pricefruit));
                }
                else if (fruit == "pineapple")
                {
                    var pricefruit = quantity * 5.5;
                    Console.WriteLine(String.Format("{0:0.00}", pricefruit));
                }
                else if (fruit == "grapes")
                {
                    var pricefruit = quantity * 3.85;
                    Console.WriteLine(String.Format("{0:0.00}", pricefruit));
                }

            }
            else
            {
                Console.WriteLine("error");
            }


            if (fruitCondition && weekend)
            {
                if (fruit == "banana")
                {
                    var pricefruit = quantity * 2.7;
                    Console.WriteLine(String.Format("{0:0.00}", pricefruit));
                }
                else if (fruit == "apple")
                {
                    var pricefruit = quantity * 1.25;
                    Console.WriteLine(String.Format("{0:0.00}", pricefruit));
                }
                else if (fruit == "orange")
                {
                    var pricefruit = quantity * 0.90;
                    Console.WriteLine(String.Format("{0:0.00}", pricefruit));
                }
                else if (fruit == "grapefruit")
                {
                    var pricefruit = quantity * 1.60;
                    Console.WriteLine(String.Format("{0:0.00}", pricefruit));
                }
                else if (fruit == "kiwi")
                {
                    var pricefruit = quantity * 3.00;
                    Console.WriteLine(String.Format("{0:0.00}", pricefruit));
                }
                else if (fruit == "pineapple")
                {
                    var pricefruit = quantity * 5.6;
                    Console.WriteLine(String.Format("{0:0.00}", pricefruit));
                }
                else if (fruit == "grapes")
                {
                    var pricefruit = quantity * 4.20;
                    Console.WriteLine(String.Format("{0:0.00}", pricefruit));
                }

            }
            
           

            //if (workingDays)
            //{
            //    if (fruit == "banana")
            //    {
            //        Console.WriteLine(String.Format("{ 0:0.00}"), (quantity * 2.5));
            //    }
            //    else if (fruit == "apple")
            //    {
            //        Console.WriteLine(String.Format("{ 0:0.00}"), (quantity * 1.2));
            //    }
            //    else if (fruit == "orange")
            //    {
            //        Console.WriteLine(String.Format("{ 0:0.00}"), (quantity * 0.85));
            //    }
            //    else if (fruit == "grapefruit")
            //    {
            //        Console.WriteLine(String.Format("{ 0:0.00}"), (quantity * 1.45));
            //    }
            //    else if (fruit == "kiwi")
            //    {
            //        Console.WriteLine(String.Format("{ 0:0.00}"), (quantity * 2.7));
            //    }
            //    else if (fruit == "pineapple")
            //    {
            //        Console.WriteLine(String.Format("{ 0:0.00}"), (quantity * 5.5));
            //    }
            //    else if (fruit == "grapes")
            //    {
            //        Console.WriteLine(String.Format("{ 0:0.00}"), (quantity * 3.85));
            //    }
            //    else
            //    {
            //        Console.WriteLine("error");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("error");
            //}

            //if (weekend)
            //{
            //    if (!weekend)
            //    {
            //        Console.WriteLine("error");
            //    }
            //    else if (fruit == "banana")
            //    {
            //        Console.WriteLine(String.Format("{ 0:0.00}"), (quantity * 2.7));
            //    }
            //    else if (fruit == "apple")
            //    {
            //        Console.WriteLine(String.Format("{ 0:0.00}"), (quantity * 1.25));
            //    }
            //    else if (fruit == "orange")
            //    {
            //        Console.WriteLine(String.Format("{ 0:0.00}"), (quantity * 0.90));
            //    }
            //    else if (fruit == "grapefruit")
            //    {
            //        Console.WriteLine(String.Format("{ 0:0.00}"), (quantity * 1.60));
            //    }
            //    else if (fruit == "kiwi")
            //    {
            //        Console.WriteLine(String.Format("{ 0:0.00}"), (quantity * 3.00));
            //    }
            //    else if (fruit == "pineapple")
            //    {
            //        Console.WriteLine(String.Format("{ 0:0.00}"), (quantity * 5.60));
            //    }
            //    else if (fruit == "grapes")
            //    {
            //        Console.WriteLine(String.Format("{ 0:0.00}"), (quantity * 4.20));
            //    }
            //    else
            //    {
            //        Console.WriteLine("error");
            //    }
            //}        

        }
    }
}
