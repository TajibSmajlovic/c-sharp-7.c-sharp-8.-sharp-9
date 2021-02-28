using System;

namespace _1_OutVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            if(DateTime.TryParse("03/12/1995", out var dt))
                Console.WriteLine(dt.Date);
        }
    }
}
