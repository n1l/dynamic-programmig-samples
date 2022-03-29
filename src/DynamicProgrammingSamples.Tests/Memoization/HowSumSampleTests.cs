using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;
using static DynamicProgrammingSamples.Memoization.HowSumSample;

namespace DynamicProgrammingSamples.Tests.Memoization
{
    public class HowSumSampleTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public static void GivenTargetSumAndNums_WhenHowSumInvoked_ThenReturnsAPossibleCombination(int testCase)
        {
            (int targetSum, int[] nums, bool solutionExists) = TestCases[testCase];

            List<int> result = HowSum(targetSum, nums);

            Assert.Equal(result !=  null, solutionExists);
            if (result != null)
            {
                int total = result.Aggregate((total, i) => total + i);
                total.Should().Be(targetSum);
            }
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