using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант 1
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"Number {number} is even");
            }
            else
            {
                Console.WriteLine($"Number {number} is not even");
            }
        }
    }
}
