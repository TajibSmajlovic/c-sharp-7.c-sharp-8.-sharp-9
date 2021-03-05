using System;
using System.Linq;

namespace _3_InferTupleNames
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var me = (name: "Tajib", age: 25);

            var alsoMe = (me.age, me.name);

            var random = new[] { "Test", "Maybe", "Ordering" };
            var res = random.Select(x => (x.Length, FirstChar: x[0])).Where(y => y.Length > 5);

            var now = DateTime.Now;
            var u = (now.Hour, now.Minute);
            var v = (u.Hour, u.Minute) = (11, 12);

            Console.WriteLine(v.Hour);
            Console.WriteLine(v.Minute);
        }
    }
}