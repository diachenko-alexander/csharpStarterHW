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
            // прямоугольник
            Console.WriteLine("Прямоугольник");
            for (int i = 0; i < 4; i++)
            {
                //Console.WriteLine("\n");
                for (int j = 0; j < 20; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine();

            // прямоугольный треугольник
            Console.WriteLine("Прямоугольный треугольник");
            for (int i = 0; i < 10; i++)
            {                
                for (int j = i; j < 10; j++)
                {
                    Console.Write("*");                    
                }
                Console.Write("\n");               
            }

            //равносторонний треугольник
            Console.WriteLine();
            Console.WriteLine("Равносторонний треугольник");

            int spaceTriangle = 10;
           
            for (int i = 0; i < 10; i++)
            {
                
                for (int j = spaceTriangle; j  >= 0; j--)
                {
                    Console.Write(" ");
                }
                
                spaceTriangle--;


                for (int k = 0; k <= (i*2); k++)
                {
                    Console.Write("*");                    
                }
                Console.Write("\n");
               
            }

            //ромб
            Console.WriteLine();
            Console.WriteLine("Ромб");

            int spaceRomb = 10;
            int symbolsRomb = 0;
            

            for (int i = 0; i < 10; i++)
            {

                for (int j = spaceRomb; j >= 0; j--)
                {
                    Console.Write(" ");
                }

                spaceRomb--;


                for (int k = 0; k <= (i * 2); k++)
                {
                    Console.Write("*");
                    
                }
                symbolsRomb++;
                Console.Write("\n");
            }

            symbolsRomb *= 2;

            for (int i = 0; i < 10; i++)
            {
                
                for (int j = -2; j < spaceRomb; j++)
                {
                    Console.Write(" ");
                }
                spaceRomb++;


                for (int k = symbolsRomb; k >= spaceRomb+1; k--)
                {
                    Console.Write("*");                    
                }

                symbolsRomb--;

                Console.Write("\n");
            }
        }

    }
}
