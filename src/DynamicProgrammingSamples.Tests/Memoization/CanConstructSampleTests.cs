using System.Collections.Generic;
using FluentAssertions;
using Xunit;
using static DynamicProgrammingSamples.Memoization.CanConstructSample;

namespace DynamicProgrammingSamples.Memoization
{
    public class CanConstructSampleTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void GivenTargetAndStringsBlocks_WhenCanConstructInvoked_ThenReturnsCorrectResult(int testCase)
        {
            (string target, string[] blocks, bool expected) = TestCases[testCase];

            bool result = CanConstruct(target, blocks);

            result.Should().Be(expected);
        }

        private static Dictionary<int, (string, string[], bool)> TestCases = new Dictionary<int, (string, string[], bool)>
        {
            {0, ("abcdef", new[] { "ab", "abc", "cd", "def", "abcd" }, true)},
            {1, ("skateboard", new[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }, false)},
            {2, ("enterapotentpot", new[] { "a", "p", "ent", "enter", "ot", "o", "t" }, true)},
            {3, ("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }, false)},
        };
    }
}