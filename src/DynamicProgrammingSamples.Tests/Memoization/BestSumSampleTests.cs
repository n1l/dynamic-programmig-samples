using System.Collections.Generic;
using FluentAssertions;
using Xunit;
using static DynamicProgrammingSamples.Memoization.BestSumSample;

namespace DynamicProgrammingSamples.Memoization
{
    public class BestSumSampleTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void GivenTargetSumAndNums_WhenBestSumInvoked_ThenReturnsTheShortestCombination(int testCase)
        {
            (int targetSum, int[] nums, int[] expected) = TestCases[testCase];

            List<int> result = BestSum(targetSum, nums);

            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(expected);
        }

        private static Dictionary<int, (int, int[], int[])> TestCases = new Dictionary<int, (int, int[], int[])>
        {
            {0, (7, new[] { 5, 3, 4, 7 }, new[] { 7 })},
            {1, (8, new[] { 2, 3, 5 }, new[] { 5, 3 })},
            {2, (8, new[] { 1, 4, 5 }, new[] { 4,4 })},
            {3, (100, new[] { 1, 2, 5, 25 }, new[] {25,25,25,25})}
        };
    }
}