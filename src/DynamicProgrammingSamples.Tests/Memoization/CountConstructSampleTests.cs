using System.Collections.Generic;
using FluentAssertions;
using Xunit;
using static DynamicProgrammingSamples.Memoization.CountConstructSample;

namespace DynamicProgrammingSamples.Memoization
{
    public class CountConstructSampleTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void GivenTargetAndStringsBlocks_WhenCountConstructInvoked_ThenReturnsCorrectResult(int testCase)
        {
            (string target, string[] blocks, int expected) = TestCases[testCase];

            int result = CountConstruct(target, blocks);

            result.Should().Be(expected);
        }

        private static Dictionary<int, (string, string[], int)> TestCases = new Dictionary<int, (string, string[], int)>
        {
            {0, ("purple", new[] { "purp", "p", "ur", "le", "purpl" }, 2)},
            {1, ("abcdef", new[] { "ab", "abc", "cd", "def", "abcd" }, 1)},
            {2, ("skateboard", new[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }, 0)},
            {3, ("enterapotentpot", new[] { "a", "p", "ent", "enter", "ot", "o", "t" }, 4)},
            {4, ("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }, 0)},
        };
    }
}