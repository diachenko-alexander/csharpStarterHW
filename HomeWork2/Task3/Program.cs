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
            string a = "\nмоя строка 1"; // Новая строка
            string b = "\tмоя строка 2"; // Табуляция
            string c = "\aмоя строка 3"; // Звуковой сигнал

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
