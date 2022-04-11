using System.Collections.Generic;

namespace DynamicProgrammingSamples.Memoization
{
    public static class CanConstructSample
    {
        public static bool CanConstruct(string target, string[] blocks, Dictionary<string, bool> memo = null)
        {
            if (target == string.Empty)
            {
                return true;
            }

            if (memo == null)
            {
                memo = new Dictionary<string, bool>();
            }

            if (memo.ContainsKey(target))
            {
                return memo[target];
            }

            foreach (string word in blocks)
            {
                if (target.StartsWith(word))
                {
                    string suffix = target.Substring(word.Length);
                    if (CanConstruct(suffix, blocks, memo))
                    {
                        memo[target] = true;
                        return true;
                    }
                }
            }

            memo[target] = false;
            return false;
        }
    }
}
