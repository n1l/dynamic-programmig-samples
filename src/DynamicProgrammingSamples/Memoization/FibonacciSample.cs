using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgrammingSamples.Memoization
{
    public static class FibonacciSample
    {
        public static long GetFibonacciNumber(int n, Dictionary<long, long> memo = null)
        {
            if (memo is null) { memo = new Dictionary<long, long>(); }
            if (memo.ContainsKey(n)) { return memo[n]; }
            if (n <= 2) { return 1; }

            memo[n] = GetFibonacciNumber(n - 1, memo) + GetFibonacciNumber(n - 2, memo);
            return memo[n];
        }
    }
}
