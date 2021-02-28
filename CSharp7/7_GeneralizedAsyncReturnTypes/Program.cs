using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _7_GeneralizedAsyncReturnTypes
{
    internal class Program
    {
        public static async ValueTask<long> GetDirSize(string dir)
        {
            if (!Directory.EnumerateFileSystemEntries(dir).Any())
                return 0;

            return await Task.Run(() => Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories)
                                                 .Sum(f => new FileInfo(f).Length));
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(GetDirSize(@"c:\temp"));

            // Literals improvements
            int a = 123_132_123;
            var bin = 0b_111_0100_1111;
        }
    }
}