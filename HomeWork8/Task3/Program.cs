using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter clients:");
            int routes = CountRoutes(int.Parse(Console.ReadLine()));
            Console.WriteLine(routes);
        }

        static int CountRoutes(int clients)
        {

            if (clients == 0)
            {
                return 1;
            }
            else
            {
               return  clients * CountRoutes (clients -1);
            }               

        }
    }
}
