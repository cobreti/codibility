using System;
using System.Collections.Generic;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A)
    {

        var pairs = new Dictionary<int, int>();

        for (var idx = 0; idx < A.Length; ++idx)
        {
            var v = A[idx];
            if (pairs.ContainsKey(v))
            {
                pairs[v]++;
            }
            else
            {
                pairs.Add(v, 1);
            }
        }

        var unpair = pairs.FirstOrDefault(x => x.Value % 2 != 0);

        return unpair.Key;
    }
}
