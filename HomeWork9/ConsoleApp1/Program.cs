using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array lenght: ");
            int arrayLenght = int.Parse(Console.ReadLine());

            int [] array = new int[arrayLenght];
            Random rnd = new Random();

            for(int i = 0; i < array.Length; i++)
            {
                int random = rnd.Next(100);
                array[i] = random;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            // Max array value
            int maxValue = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            Console.WriteLine($"Max value in array = {maxValue}");

            // Min value
            int minValue = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            Console.WriteLine($"Min value in array = {minValue}");

            // SUMM of array elements
            int summ = 0;

            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            Console.WriteLine($"Summ of all elements in array = {summ}");

            // Average
            Console.WriteLine($"Math Average =  {summ / array.Length}");

            // All not even
            Console.WriteLine("Not even Elements:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine(array[i]);
                }
            }

        }
    }
}
