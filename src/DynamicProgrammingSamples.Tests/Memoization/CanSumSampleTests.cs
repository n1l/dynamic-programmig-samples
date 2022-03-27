using System.Collections.Generic;
using FluentAssertions;
using Xunit;
using static DynamicProgrammingSamples.Memoization.CanSumSample;

namespace DynamicProgrammingSamples.Memoization
{
    public class CanSumSampleTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void GivenTargetSumAndNums_WhenCanSumInvoked_ThenReturnsCorrectResult(int testCase)
        {
            (int targetSum, int[] nums, bool expected) = TestCases[testCase];

            bool result = CanSum(targetSum, nums);

            result.Should().Be(expected);
        }

        private static Dictionary<int, (int, int[], bool)> TestCases = new Dictionary<int, (int, int[], bool)>
        {
            {0, (7, new[] { 2, 3 }, true)},
            {1, (7, new[] { 5, 3, 4, 7 }, true)},
            {2, (7, new[] { 2, 4 }, false)},
            {3, (8, new[] { 2, 3, 5 }, true)},
            {4, (300, new[] { 7, 14 }, false)}
        };
    }
}