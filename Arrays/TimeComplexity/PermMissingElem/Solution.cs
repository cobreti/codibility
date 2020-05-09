using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A)
    {
        if (A.Length == 0)
            return 1;

        Array.Sort(A);

        if (A[0] != 1)
            return 1;

        
        for (var idx = 0; idx < A.Length-1; ++idx)
        {
            if (A[idx] != A[idx + 1] - 1)
            {
                return A[idx] + 1;
            }
        }

        return A[A.Length-1] + 1;
    }
}
