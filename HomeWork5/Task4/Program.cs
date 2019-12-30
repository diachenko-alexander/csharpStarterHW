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
            Console.Write("Введите выслугу лет для расчета премии:");
            int experience = int.Parse(Console.ReadLine());
            Console.Write("Введите заработную плату:");
            double salary = int.Parse(Console.ReadLine());

            int percent = 0;

            if (experience < 5) percent = 10;
            if (experience >= 5 && experience < 10) percent = 15;
            if (experience >= 10 && experience < 15) percent = 25;
            if (experience >= 15 && experience < 20) percent = 35;
            if (experience >= 20 && experience < 25) percent = 45;
            if (experience > 25) percent = 50;

            double result = salary * (100 + percent) / 100;
           
            Console.WriteLine($"Премия: {result - salary}");
            Console.WriteLine($"Зарплата с премией: {result}");
        }
    }
}
