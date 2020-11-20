using System;
using System.Diagnostics;

namespace CSharpExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();

            // WRITE YOUR CODE HERE
            Console.WriteLine("To get started import your namespaces and call stuff!");
            // WRITE YOUR CODE HERE

            stopwatch.Stop();
            double elapsed = (double)stopwatch.ElapsedMilliseconds / 1000;
            Console.WriteLine($"Time elapsed: {elapsed}");
        }
    }
}
