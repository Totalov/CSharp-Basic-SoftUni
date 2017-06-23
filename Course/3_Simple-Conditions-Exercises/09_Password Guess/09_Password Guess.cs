using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            var Password = Console.ReadLine();

            if (Password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        
        }
    }
}
