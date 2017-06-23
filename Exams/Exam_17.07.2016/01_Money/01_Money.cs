using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitCoins = int.Parse(Console.ReadLine());
            var chineeseYoans = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine());

            var bitToLV = bitCoins * 1168.0;
            var YoansToUSD = chineeseYoans * 0.15;
            var USDToLV = 1.76;
            var EURToLV = 1.95;

            var YoansToLV = YoansToUSD * USDToLV;

            var sum = bitToLV + YoansToLV;

            var sumToEUR = sum / EURToLV;

            var SumCommission = (commission / 100) * sumToEUR;

            var result = sumToEUR - SumCommission;

            Console.WriteLine(result);




        }
    }
}
