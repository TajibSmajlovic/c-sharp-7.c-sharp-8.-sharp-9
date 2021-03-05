using System;
using System.Collections.Generic;

namespace _2_DefaultExpression
{
    internal class Program
    {
        public DateTime GetTimestamps(List<int> items = default) => default;

        private static void Main(string[] args)
        {
            int a = default;

            var e = new[] { default, default, "test" };
            Console.WriteLine(e[0]);

            if (a == default)
                Console.WriteLine(e[0] == null);

            var x = a > 0 ? default : 1.5;
        }
    }
}