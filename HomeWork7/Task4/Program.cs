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
            Console.WriteLine("Please enter number to check");
            CheckUserNumber(int.Parse(Console.ReadLine()));
                                   
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

        static void CheckUserNumber( int number)
        {
            if (IsPositiv(number))
            {
                Console.WriteLine("Number is positiv");
            } else
            {
                Console.WriteLine("Number is negativ");
            }

            if (IsPrime(number))
            {
                Console.WriteLine("Number is prime");
            } else
            {
                Console.WriteLine("Number is not prime");
            }

            if (IsDividedWithoutRestOn (number, 2, 5, 3, 6, 9))
            {
                Console.WriteLine("Is divided without rest on 2,5,3,6,9");
            }else
            {
                Console.WriteLine("Is not divided without rest on 2,5,3,6,9");
            }
        }

    }
}
