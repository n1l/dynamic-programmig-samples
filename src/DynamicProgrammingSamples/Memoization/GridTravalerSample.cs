using System.Collections.Generic;

namespace DynamicProgrammingSamples.Memoization
{
    public static class GridTravalerSample
    {
        public static long GridTravaler(int n, int m, Dictionary<(int, int), long> memo = null)
        {
            if (memo is null) { memo = new Dictionary<(int, int), long>(); }
            if (memo.ContainsKey((n, m))) { return memo[(n, m)]; }
            if (n == 1 && m == 1) { return 1; }
            if (n == 0 || m == 0) { return 0; }

            memo[(n, m)] = GridTravaler(n - 1, m, memo) + GridTravaler(n, m - 1, memo);
            return memo[(n, m)];
        }
    }
}
