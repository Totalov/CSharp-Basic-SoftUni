using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double valueToConvert = double.Parse(Console.ReadLine());

            var unitToConvert = (Console.ReadLine());
            var ConvertedUnit = (Console.ReadLine());

            double firtsUnit = 0.0;
            double secondUnit = 0.0;

            double m = 1.0;
            double mm = m / 1000;
            double cm = m / 100;
            double mi = m / 0.000621371192;
            double inch = m / 39.3700787;
            double km = m / 0.001;
            double ft = m / 3.2808399;
            double yd = m / 1.0936133;

            if (unitToConvert == "m")
            {
                firtsUnit = m;
            }
            else if (unitToConvert == "mm")
            {
                firtsUnit = mm;
            }

            else if (unitToConvert == "cm")
            {
                firtsUnit = cm;
            }

            else if (unitToConvert == "mi")
            {
                firtsUnit = mi;
            }

            else if (unitToConvert == "in")
            {
                firtsUnit = inch;
            }

            else if (unitToConvert == "km")
            {
                firtsUnit = km;
            }

            else if (unitToConvert == "ft")
            {
                firtsUnit = ft;
            }

            else if (unitToConvert == "yd")
            {
                firtsUnit = yd;
            }


            if (ConvertedUnit == "m")
            {
                secondUnit = m;
            }
            else if (ConvertedUnit == "mm")
            {
                secondUnit = mm;
            }
            else if (ConvertedUnit == "cm")
            {
                secondUnit = cm;
            }

            else if (ConvertedUnit == "mi")
            {
                secondUnit = mi;
            }

            else if (ConvertedUnit == "in")
            {
                secondUnit = inch;
            }

            else if (ConvertedUnit == "km")
            {
                secondUnit = km;
            }

            else if (ConvertedUnit == "ft")
            {
                secondUnit = ft;
            }

            else if (ConvertedUnit == "yd")
            {
                secondUnit = yd;
            }

            double result = valueToConvert * (firtsUnit / secondUnit);
            Console.WriteLine($"{result} {ConvertedUnit}");

            //string re =  (10 == 5) ? "yeah" :"no" ; if na edin red
            //Console.WriteLine(re);

            ////var inputNumber = double.Parse(Console.ReadLine());
            ////var inputMetric = (Console.ReadLine());
            ////var outputMetric = (Console.ReadLine());

            ////var intermediateMeters = 0.0;

            ////var finalNumber = 0.0;

            ////if (inputMetric == "mm")

            ////{
            ////    intermediateMeters = inputNumber / 1000;

            ////}
            ////else if (inputMetric == "cm")
            ////{
            ////    intermediateMeters = inputNumber / 100;
            ////}
            ////else if (inputMetric == "mi")
            ////{
            ////    intermediateMeters = inputNumber / 0.000621371192;
            ////}
            ////else if (inputMetric == "in")
            ////{
            ////    intermediateMeters = inputNumber / 39.3700787;
            ////}
            ////else if (inputMetric == "km")
            ////{
            ////    intermediateMeters = inputNumber / 0.001;
            ////}
            ////else if (inputMetric == "ft")
            ////{
            ////    intermediateMeters = inputNumber / 3.2808399;
            ////}
            ////else if (inputMetric == "yd")
            ////{
            ////    intermediateMeters = inputNumber / 1.0936133;
            ////}


        }
    }
}
