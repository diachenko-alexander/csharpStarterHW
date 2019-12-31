using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter pay: ");
            double pay = double.Parse(Console.ReadLine());
            CheckPay(pay);
        }

        static void CheckPay(double pay)
        {
            if (pay == 700)
            {
                Console.WriteLine("Your credit is finished.");
            }
            else if (pay < 700)
            {
                Console.WriteLine($"You have to pay {700 - pay}");
            }
            else
            {
                Console.WriteLine($"Over pay is {pay - 700}");
            }
        }
    }
}
