using System.Collections.Generic;
using System.Linq;

namespace DynamicProgrammingSamples.Memoization
{
    public static class AllConstructSample
    {
        public static List<List<string>> AllConstruct(
            string target,
            string[] blocks,
            Dictionary<string, List<List<string>>> memo = null)
        {
            if (target == string.Empty)
            {
                return new List<List<string>> { new List<string>() };
            }

            if (memo == null)
            {
                memo = new Dictionary<string, List<List<string>>>();
            }

            if (memo.ContainsKey(target))
            {
                return memo[target];
            }

            List<List<string>> waysToCreateTarget = new List<List<string>>();

            foreach (string word in blocks)
            {
                if (target.StartsWith(word))
                {
                    string suffix = target.Substring(word.Length);
                    List<List<string>> waysToCreateSuffix = AllConstruct(suffix, blocks, memo);

                    foreach (List<string> wayToCreateSuffix in waysToCreateSuffix)
                    {
                        waysToCreateTarget.Add(new List<string>(new[] { word }.Concat(wayToCreateSuffix)));
                    }
                }
            }

            memo[target] = waysToCreateTarget;
            return waysToCreateTarget;
        }
    }
}
