using System;
using BenchmarkDotNet.Running;

namespace Magicodes.Benchmarks
{
    class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            Console.ReadKey();
        }
    }
}
