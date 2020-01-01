using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int argument1 = 100;
            int argument2 = 200;
            int argument3 = 300;

            Calculate(ref argument1, ref argument2, ref argument3);
            Console.WriteLine(argument1);
            Console.WriteLine(argument2);
            Console.WriteLine(argument3);
        }

        static void Calculate(ref int argument1, ref int argument2, ref int argument3 )
        {
            argument1 /= 5;
            argument2 /= 5;
            argument3 /= 5;
        }
    }
}
