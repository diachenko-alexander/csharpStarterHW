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
            Console.WriteLine("*** Calculator ***");
            
            Console.Write("Enter operand1:");
            double operand1 = double.Parse(Console.ReadLine());
           
            Console.Write("Enter operand2:");
            double operand2 = double.Parse(Console.ReadLine());

            Console.Write("Enter sign:");
            string sign = Console.ReadLine();

            string message = "{0} {1} {2} = {3}";

            switch (sign) {
                case "+":
                    {
                        Console.WriteLine(String.Format(message, operand1, sign, operand2, Add(operand1, operand2)));
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine(String.Format(message, operand1, sign, operand2, Sub(operand1, operand2)));
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(String.Format(message, operand1, sign, operand2, Mul(operand1, operand2)));
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine(String.Format(message, operand1, sign, operand2, Div(operand1, operand2)));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid sign");
                        break;
                    }
            }

        }

        static double Add (double operand1, double oprand2)
        {
            return operand1 + oprand2;
        }

        static double Sub (double operand1, double operand2)
        {
            return operand1 - operand2;
        }

        static double Mul (double operand1, double operand2)
        {
            return operand1 * operand2;
        }

        static double Div(double operand1, double operand2)
        {
            if (operand2 == 0)
            {
                Console.WriteLine("Dividing by zero imposible");
                return 0;
            }
            return operand1 / operand2;
        }
    }
}
