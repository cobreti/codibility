using System;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A)
    {
        var sumA = 0;
        var sumB = A.Sum();
        var idx = 0;
        sumB -= A[idx];
        sumA += A[idx];
        var diff = Math.Abs(sumA - sumB);
        idx++;

        while (idx < A.Length-1)
        {
            sumB -= A[idx];
            sumA += A[idx];

            diff = Math.Min(Math.Abs(sumA - sumB), diff);
            ++idx;
        }

        return diff;
    }
}
