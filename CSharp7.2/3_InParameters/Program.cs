using System;

namespace _3_InParameters
{
    internal struct Point
    {
        public double X, Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Reset()
        {
            X = Y = 0;
        }

        // we don't want to recreate origin as new Point(), so...
        private static Point origin = new Point();

        public static ref readonly Point Origin => ref origin;

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }

    public class RefSemanticsValueTypes
    {
        // IN PARAMETERS

        private void changeMe(ref Point p)
        {
            p.X++;
        }

        // structs are passed by reference (i.e. address, so 32 or 64 bits)
        // 'in' is effectively by-ref and read-only
        private double MeasureDistance(in Point p1, in Point p2)
        {
            // cannot assign to in parameter
            // p1 = new Point();

            // cannot pass as ref or out method
            // obvious
            // changeMe(ref p2);

            p2.Reset(); // instance operations happen on a copy!

            var dx = p1.X - p2.X;
            var dy = p1.Y - p2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // cannot create overloads that differ only in presence?
        // yeah you can, but
        //double MeasureDistance(Point p1, Point p2)
        //{
        //  return 0.0;
        //}

        public RefSemanticsValueTypes()
        {
            var p1 = new Point(1, 1);
            var p2 = new Point(4, 5);

            var distance = MeasureDistance(p1, p2);
            //             ^^^^ call ambiguous
            Console.WriteLine($"Distance between {p1} and {p2} is {distance}");

            // can also pass in temporaries
            var distFromOrigin = MeasureDistance(p1, new Point());

            var alsoDistanceFromOrigin = MeasureDistance(p2, Point.Origin);

            // REF READONLY RETURNS

            // make an ordinary by-value copy
            Point copyOfOrigin = Point.Origin;

            // it's readonly, you cannot do a ref!
            //ref var messWithOrigin = ref Point.Origin;

            ref readonly var originRef = ref Point.Origin;
            // won't work
            //originRef.X = 123;
        }

        // REF STRUCTS

        // a value type that MUST be stack-allocated
        // can never be created on the heap
        // created specifically for Span

        private static void Main(string[] args)
        {
            var r = new RefSemanticsValueTypes();
        }
    }
}