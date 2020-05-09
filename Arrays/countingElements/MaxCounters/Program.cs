using System;

namespace MaxCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var result = new Solution().solution(5,
                new int[] {3, 4, 4, 6, 1, 4, 4});
            
            watch.Stop();
            Console.WriteLine($"runtime: {(watch.ElapsedMilliseconds / 1000.0).ToString()}");

            Console.WriteLine(string.Join(',', result));
        }
    }
}