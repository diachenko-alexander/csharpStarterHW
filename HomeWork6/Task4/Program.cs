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
            Console.WriteLine("Программа расчета вариантов доставки");
            Console.WriteLine("Введите количество клиентов");
            int clients = int.Parse(Console.ReadLine());
            int cars = 1;
            string message = "Количество вариантов доставки = {0}";

            if (clients == 1)
            {
                Console.WriteLine(string.Format(message, clients));
            } else
            {
                do
                {
                    cars *= clients--;
                } while (clients > 0);

                Console.WriteLine(string.Format(message, cars));
            }

            
        }
    }
}
