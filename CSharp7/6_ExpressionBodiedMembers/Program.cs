using System;
using System.Collections.Generic;

namespace _6_ExpressionBodiedMembers
{
    public class MyClass
    {
        public static readonly Dictionary<int, string> names = new Dictionary<int, string>();
        private int Id;

        public MyClass(int id, string name) => names.Add(id, name);

        ~MyClass() => names.Remove(Id);

        public string Name
        {
            get => names[Id];
            set => names[Id] = value.ToLower();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var myClass = new MyClass(1, "Test");
            Console.WriteLine(MyClass.names.Count);

            var myClass2 = new MyClass(2, "Test2");
            var myClass3 = new MyClass(3, "Test3");
            Console.WriteLine(MyClass.names.Count);
        }
    }
}