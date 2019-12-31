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
            Console.WriteLine("*** Converter ***");
           
            Console.Write("Enter amount of money: ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("Enter course: ");
            double course = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Your result is {ConvertMoney(amount, course)}");

        }

        static double ConvertMoney (double amount, double course)
        {
            return amount * course;
        }
    }
}
