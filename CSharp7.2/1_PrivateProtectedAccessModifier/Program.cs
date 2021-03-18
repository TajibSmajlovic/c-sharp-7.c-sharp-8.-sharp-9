using System;

namespace _1_PrivateProtectedAccessModifier
{
    internal class Base
    {
        private int a;
        protected internal int b; // 1) derived classes (any assembly)
                                  // 2) classes in same assembly

        private protected int c;  // 1) containing class
                                  // 2) derived classes (current assembly)
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}