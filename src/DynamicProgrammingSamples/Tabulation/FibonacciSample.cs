using System.Collections.Generic;

namespace DynamicProgrammingSamples.Tabulation
{
    public static class FibonacciTabSample
    {
        public static long GetFibonacciNumber(int n)
        {
            if (n <= 2) { return 1; }
            long[] table = new long[n + 1];
            table[0] = 0;
            table[1] = 1;
            table[2] = 1;

            for (int i = 2; i <= n; i++)
            {
                if (i + 1 <= n)
                {
                    table[i + 1] += table[i];
                }
                if (i + 2 <= n)
                {
                    table[i + 2] += table[i];
                }
            }

            return table[n];
        }
    }
}
