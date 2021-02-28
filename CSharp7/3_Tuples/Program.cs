using System;

namespace _3_Tuples
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            (double sum, double product) SumAndProduct(int a, int b) => (a + b, a * b);

            var sumAndProduct = SumAndProduct(7, 5);
            Console.WriteLine(sumAndProduct.sum);
            Console.WriteLine(sumAndProduct.product);

            var (sum, product) = SumAndProduct(5, 9);
            Console.WriteLine(sum);
            Console.WriteLine(product);

            var myPoint = new Point();
            var (x, _) = myPoint;
            Console.WriteLine(x);
        }

        private class Point
        {
            public int X, Y;

            public Point()
            {
                X = 10;
                Y = 5;
            }

            // Deconstruct
            public void Deconstruct(out int x, out int y)
            {
                x = X;
                y = Y;
            }
        }
    }
}