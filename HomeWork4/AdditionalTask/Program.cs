using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Translate");
            Console.Write("Enter word:");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "погода":
                    {
                        Console.WriteLine("weather");
                        break;
                    }
                case "дождь":
                    {
                        Console.WriteLine("rain");
                        break;
                    }
                case "снег":
                    {
                        Console.WriteLine("Snow");
                        break;
                    }
                case "ветер":
                    {
                        Console.WriteLine("wind");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Unnknown word");
                        break;
                    }
            }


        }
    }
}
