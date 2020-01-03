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
            int[] array = { 1, 2, 3, 4, 5, };
            int[] newArray = AddArrayLenght(array, 99);

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }
        }

        static int [] AddArrayLenght(int [] array, int value)
        {
            int[] resultArray = new int[array.Length + 1];
            resultArray[0] = value;
            
            for (int i = 1; i < resultArray.Length; i++)
            {
                resultArray[i] = array[i - 1];
            }

            return resultArray;
        }
    }
}
