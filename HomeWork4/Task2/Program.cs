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
            Console.WriteLine("Calculator");
                        
            Console.Write("Please enter operand 1:");
            double operand1 = double.Parse(Console.ReadLine());
            
            Console.Write("Please enter operand 2:");
            double operand2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter sign:");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    {
                        Console.WriteLine(operand1 + operand2);
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine(operand1 - operand2);
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(operand1 * operand2);
                        break;
                    }
                case "/":
                    {
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Dividing by zero imposible");
                        } else
                        {
                            Console.WriteLine(operand1 / operand2);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid sign");
                        break;
                    }
            }



        }
    }
}
