using System;

namespace _2_NonTrailingNamedArguments
{
    internal class Program
    {
        private static void someMethod(int item1, int item2)
        {
        }

        private static void Main(string[] args)
        {
            someMethod(12, item2: 15);
            someMethod(item1: 12, 15);
            someMethod(item2: 15, item1: 12);
        }
    }
}