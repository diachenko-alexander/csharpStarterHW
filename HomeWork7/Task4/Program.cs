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
            Console.WriteLine("Check number");


            
        }



        static bool IsPositiv (int number)
        {
            if (number > 0)
            {
                return true;
            }
            return false;
        }

        static bool IsPrime (int number)
        {


            if (number == 0 || number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <=  number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsDividedWithoutRestOn(int number, params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (number % array[i] != 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
