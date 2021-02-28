using System;

namespace _2_PatternMatching
{
    internal class Shape
    {
    }

    internal class Rectange : Shape
    {
    }

    internal class Circle : Shape
    {
        public int Width, Height;
    }

    internal class Program
    {
        public static void DisplayShape(Shape shape)
        {
            if (shape is Circle c)
            {
                // something
            }

            if (!(shape is Circle notC))
            {
                // something
            }

            switch (shape)
            {
                case Rectange r:
                    // something
                    break;

                case Circle cr when (cr.Width > 200 && cr.Height > 500):
                // something

                default:
                    break;
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}