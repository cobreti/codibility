using System;
using System.Collections.Generic;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K)
    {
        if (A.Length == 0)
            return new int[] { };

        var remainingK = K % A.Length;
        var L = A.Length - remainingK;
        var part1 = A.Take(L);
        var part2 = A.Skip(L).Take(remainingK);

        var result = new List<int>();
        result.AddRange(part2);
        result.AddRange(part1);
        
        return result.ToArray();
    }
}