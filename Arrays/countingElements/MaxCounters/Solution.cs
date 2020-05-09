using System;
using System.Collections.Generic;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A)
    {
        
        var len = A.Length;
        if (len == 0)
            return new int[] { };

        var counters = new int[N];
        var updatedCounters = new Dictionary<int, int>();
        
        var maxCounter = 0;
        var fillValue = 0;

        for (var idx = 0; idx < len; ++idx)
        {
            var v = A[idx]-1;

            if (v < N)
            {
                if (updatedCounters.ContainsKey(v))
                {
                    var counterValue = updatedCounters[v] + 1;
                    updatedCounters[v] = counterValue;
                    maxCounter = Math.Max(counterValue, maxCounter);
                }
                else
                {
                    updatedCounters[v] = fillValue + 1;
                    maxCounter = Math.Max(maxCounter, fillValue + 1);
                }
            }
            else
            {
                fillValue = maxCounter;
                updatedCounters.Clear();
            }
        }

        for (var idx = 0; idx < N; idx++)
        {
            counters[idx] = fillValue;
        }
        
        foreach (var k in updatedCounters.Keys)
        {
            counters[k] = updatedCounters[k];
        }
        
        return counters;
    }
}
