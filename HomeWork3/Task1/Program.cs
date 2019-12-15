using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;

            x += y - x++ * z; // -8 = 10 + (10 - (3*10));
            z = --x - y * 5; // -51 = 9 - (12*5);
            y /= x + 5 % z; // 1 = 12 / (10 + (5 % 3));
            z = x++ + y * 5; // 70 = 10 + (12 * 5);
            x = y - x++ * z; // -18 = 12 - (10*3);
        }
    }
}
