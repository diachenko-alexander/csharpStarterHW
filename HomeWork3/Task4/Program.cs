using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Программа расчета объема и площади цилиндра***");
            Console.WriteLine("Введите радиус цилиндра");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту цилиндра");
            double h = double.Parse(Console.ReadLine());
            double v = Math.PI * (Math.Pow(r, 2) * h);
            double s = 2 * Math.PI * r * (r + h);
            Console.WriteLine($"Объем цилиндра = {v}\nПлощадь цилиндра = {s}");
            Console.ReadLine();
        }
    }
}
