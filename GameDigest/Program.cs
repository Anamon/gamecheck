using System;
using System.CommandLine;
using System.Threading.Tasks;

namespace Anamon.GameDigest
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            // FIXME: Placate warning. [Anamon]
            await Task.Delay(0);

            Console.WriteLine("Hello, World!");
            return 0;
        }

        // TODO: Factor out. [Anamon]
        static string[] CreateDigest()
        {
            return new string[0];
        }
    }
}
