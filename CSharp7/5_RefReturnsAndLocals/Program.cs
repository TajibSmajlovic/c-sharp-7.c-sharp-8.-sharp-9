using System;

namespace _5_RefReturnsAndLocals
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            ref int refToSecond = ref numbers[1];

            Console.WriteLine(string.Join(",", numbers));

            refToSecond = 321;

            Console.WriteLine(string.Join(",", numbers));

            int[] numbers2 = { 10, 11, 12, 13 };
            ref int refToNum = ref Find(numbers2, 13);
            refToNum = 645;

            Console.WriteLine(string.Join(",", numbers2));
        }

        private static ref int Find(int[] numbers, int value)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == value)
                    return ref numbers[i];
            }

            throw new ArgumentNullException();
        }
    }
}