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
            /*Задание 2
 Используя Visual Studio, создайте проект по шаблону Console Application.
 Дано два числа A и B(A<B) выведите суму всех чисел расположенных между данными числами на экран.
 Дано два числа A и B(A<B) выведите все нечетные значения, расположенные между данными числами.
 */
            Console.WriteLine("Enter number A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number B");
            int b = int.Parse(Console.ReadLine());
           
            int amount = 0;

            for (int i = a; i < b; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine($"Not even number {i}");
                }
                amount += i;
            }
            
            Console.WriteLine($"Total amount between {a} and {b} is {amount}");

        }
    }
}
