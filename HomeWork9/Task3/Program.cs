using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reverse array
            Console.WriteLine("Reverse array");
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] revArray = MyReverse(array);

            for (int i = 0; i < revArray.Length; i++)
            {
                //Console.WriteLine(revArray[i]);
            }

            // Sub array
            Console.WriteLine("Sub array");
            int[] array2 = { 0, 1, 2, 3 };
            int[] subArray = SubArray(array2, 1, 8);

            for (int i = 0; i < subArray.Length; i++)
            {
                Console.WriteLine(subArray[i]);
            }

        }

        static int[] MyReverse(int[] array)
        {
            int[] resultArray = new int[array.Length];

            for (int i = array.Length - 1, j = 0; i >= 0; i--, j++)
            {
                resultArray[j] = array[i];
            }

            return resultArray;
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int[] resultArray = new int[count];


            for (int i = index, j = 0; i < index + count; i++, j++)
            {
                if (i > array.Length - 1)
                {
                    resultArray[j] = 1;
                }
                else
                {
                    resultArray[j] = array[i];
                }

            }

            return resultArray;
        }
    }
}
