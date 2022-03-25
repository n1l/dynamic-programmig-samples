using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgrammingSamples.Memoization
{
    public static class CanSumSample
    {
        public static bool CanSum(int targetSum, int[] nums, Dictionary<int, bool> memo = null)
        {
            if (memo is null) { memo = new Dictionary<int, bool>(); }
            if (memo.ContainsKey(targetSum)) { return memo[targetSum]; }
            if (targetSum == 0) { return true; }
            if (targetSum < 0) { return false; }

            foreach (int num in nums)
            {
                int remainder = targetSum - num;
                if (CanSum(remainder, nums, memo))
                {
                    memo[remainder] = true;
                    return memo[remainder];
                }
            }

            memo[targetSum] = false;
            return memo[targetSum];
        }
    }
}
