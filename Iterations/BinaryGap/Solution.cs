using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N)
    {

        var gap = 0;
        var oneEncountered = 0;
        var maxGap = 0;
        
        while (N > 0)
        {
            if ((N & 1) == 1)
            {
                maxGap = Math.Max(gap, maxGap);
                
                gap = 0;
                oneEncountered = 1;
            }
            else
            {
                gap += oneEncountered;
            }
            
            N = N >> 1;
        }
        
        return maxGap;
    }
}
