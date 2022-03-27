using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicProgrammingSamples.Memoization
{
    public static class HowSumSample
    {
        public static List<int> HowSum(int targetSum, int[] nums, Dictionary<int, List<int>> memo = null)
        {
            if (memo == null) { memo = new Dictionary<int, List<int>>(); }
            if (memo.ContainsKey(targetSum)) { return memo[targetSum]; }
            if (targetSum == 0) { return new List<int>(); }
            if (targetSum < 0) { return null; }

            foreach (int num in nums)
            {
                int remainder = targetSum - num;
                List<int> remainderResult = HowSum(remainder, nums, memo);
                if (remainderResult != null)
                {
                    memo[targetSum] = new List<int>(remainderResult.Concat(new[] { num }));
                    return memo[targetSum];
                }
            }

            memo[targetSum] = null;
            return memo[targetSum];
        }
    }
}
