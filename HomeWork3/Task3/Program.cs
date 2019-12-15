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
            Console.WriteLine("Программа расчета площади круга");
            const double pi = Math.PI;
            Console.WriteLine("Введите радиус круга");
            double r = double.Parse(Console.ReadLine());
            double result = pi * Math.Pow(r, 2);
            Console.WriteLine($"Площадь круга = {result}");
            Console.ReadLine();
        }
    }
}
