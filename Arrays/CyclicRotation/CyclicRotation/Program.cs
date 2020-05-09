using System;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var r = new Solution().solution(new int[] {}, 6);
            Console.WriteLine(string.Join(',', r));
        }
    }
}