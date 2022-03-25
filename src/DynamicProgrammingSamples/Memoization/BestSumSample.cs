using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicProgrammingSamples.Memoization
{
    public static class BestSumSample
    {
        public static List<int> BestSum(int targetSum, int[] nums, Dictionary<int, List<int>> memo = null)
        {
            if (memo == null) { memo = new Dictionary<int, List<int>>(); }
            if (memo.ContainsKey(targetSum)) { return memo[targetSum]; }
            if (targetSum == 0) { return new List<int>(); }
            if (targetSum < 0) { return null; }

            List<int> shortestCombination = null;
            foreach (var num in nums)
            {
                int remainder = targetSum - num;
                List<int> remainderCombination = BestSum(remainder, nums, memo);
                if (remainderCombination != null)
                {
                    List<int> combination = new List<int>(remainderCombination.Concat(new[] { num }));
                    if (shortestCombination == null || shortestCombination.Count > combination.Count)
                    {
                        shortestCombination = combination;
                    }
                }
            }

            memo[targetSum] = shortestCombination;
            return memo[targetSum];
        }
    }
}
