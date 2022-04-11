using System.Collections.Generic;

namespace DynamicProgrammingSamples.Memoization
{
    public static class CountConstructSample
    {
        public static int CountConstruct(string target, string[] blocks, Dictionary<string, int> memo = null)
        {
            if (target == string.Empty)
            {
                return 1;
            }

            if (memo == null)
            {
                memo = new Dictionary<string, int>();
            }

            if (memo.ContainsKey(target))
            {
                return memo[target];
            }

            int counter = 0;
            foreach (string word in blocks)
            {
                if (target.StartsWith(word))
                {
                    string suffix = target.Substring(word.Length);
                    counter += CountConstruct(suffix, blocks, memo);
                }
            }

            memo[target] = counter;
            return counter;
        }
    }
}
