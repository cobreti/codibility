using System;
using System.Collections.Generic;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int[] A)
    {
        var spots = new HashSet<int>();
        for (var idx = 0; idx < X; ++idx)
        {
            spots.Add(idx + 1);
        }
        
        for (var idx = 0; idx < A.Length; idx++)
        {
            var v = A[idx];
            spots.Remove(v);
            if (spots.Count == 0)
            {
                return idx;
            }
        }

        return -1;
    }
}
