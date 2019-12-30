using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= 0 && userInput <= 14)
            {
                Console.WriteLine("Your number between 0 - 14");
            } else if (userInput >= 15 && userInput <= 35)
            {
                Console.WriteLine("Your number between 15 - 35");
            } else if (userInput >= 36 && userInput <= 50)
            {
                Console.WriteLine("Your number between 36 - 50");
            } else if (userInput >= 50 && userInput <= 100)
            {
                Console.WriteLine("Your number between 50 - 100");
            } else
            {
                Console.WriteLine("Unknown range");
            }
        }
    }
}
