using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace _1_AsyncMain
{
    internal class Program
    {
        private static string url = "http://google.com/robots.txt";

        private static async Task Main(string[] args)
        {
            Console.WriteLine(await new HttpClient().GetStringAsync(url));
        }
    }
}