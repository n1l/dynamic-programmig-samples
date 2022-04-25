using System;
using System.Collections.Generic;
using System.Text;
using DynamicProgrammingSamples.Tabulation;
using static DynamicProgrammingSamples.Memoization.FibonacciSample;
using static DynamicProgrammingSamples.Memoization.GridTravalerSample;
using static DynamicProgrammingSamples.Memoization.CanSumSample;
using static DynamicProgrammingSamples.Memoization.HowSumSample;
using static DynamicProgrammingSamples.Memoization.BestSumSample;
using static DynamicProgrammingSamples.Memoization.CanConstructSample;
using static DynamicProgrammingSamples.Memoization.CountConstructSample;
using static DynamicProgrammingSamples.Memoization.AllConstructSample;

namespace DynamicProgrammingSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------

            Console.WriteLine(GetFibonacciNumber(6));
            Console.WriteLine(GetFibonacciNumber(7));
            Console.WriteLine(GetFibonacciNumber(8));
            Console.WriteLine(GetFibonacciNumber(50));
            Console.WriteLine();

            // -----------------

            Console.WriteLine(GridTravaler(1,1));
            Console.WriteLine(GridTravaler(2, 3));
            Console.WriteLine(GridTravaler(3, 2));
            Console.WriteLine(GridTravaler(3, 3));
            Console.WriteLine(GridTravaler(18, 18));
            Console.WriteLine();

            // -----------------

            Console.WriteLine(CanSum(7, new[] { 2, 3 }));
            Console.WriteLine(CanSum(7, new[] { 5, 3, 4, 7 }));
            Console.WriteLine(CanSum(7, new[] { 2, 4 }));
            Console.WriteLine(CanSum(8, new[] { 2, 3, 5 }));
            Console.WriteLine(CanSum(300, new[] { 7, 14 }));
            Console.WriteLine();

            // -----------------

            Console.WriteLine(PrintList(HowSum(7, new[] { 2, 3 })));
            Console.WriteLine(PrintList(HowSum(7, new[] { 5, 3, 4, 7 })));
            Console.WriteLine(PrintList(HowSum(7, new[] { 2, 4 })));
            Console.WriteLine(PrintList(HowSum(8, new[] { 2, 3, 5 })));
            Console.WriteLine(PrintList(HowSum(300, new[] { 7, 14 })));
            Console.WriteLine();

            // -----------------

            Console.WriteLine(PrintList(BestSum(7, new[] { 5, 3, 4, 7 })));
            Console.WriteLine(PrintList(BestSum(8, new[] { 2, 3, 5 })));
            Console.WriteLine(PrintList(BestSum(8, new[] { 1, 4, 5 })));
            Console.WriteLine(PrintList(BestSum(100, new[] { 1, 2, 5, 25 })));
            Console.WriteLine();

            // -----------------

            Console.WriteLine(CanConstruct("abcdef", new[] { "ab", "abc", "cd", "def", "abcd" }));
            Console.WriteLine(CanConstruct("skateboard", new[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }));
            Console.WriteLine(CanConstruct("enterapotentpot", new[] { "a", "p", "ent", "enter", "ot", "o", "t" }));
            Console.WriteLine(CanConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }));
            Console.WriteLine();

            // -----------------

            Console.WriteLine(CountConstruct("purple", new[] { "purp", "p", "ur", "le", "purpl" }));
            Console.WriteLine(CountConstruct("abcdef", new[] { "ab", "abc", "cd", "def", "abcd" }));
            Console.WriteLine(CountConstruct("skateboard", new[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }));
            Console.WriteLine(CountConstruct("enterapotentpot", new[] { "a", "p", "ent", "enter", "ot", "o", "t" }));
            Console.WriteLine(CountConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }));
            Console.WriteLine();

            // -----------------

            Console.WriteLine(Print2DList(AllConstruct("purple", new[] { "purp", "p", "ur", "le", "purpl" })));
            Console.WriteLine(Print2DList(AllConstruct("abcdef", new[] { "ab", "abc", "cd", "def", "abcd" })));
            Console.WriteLine(Print2DList(AllConstruct("skateboard", new[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })));
            Console.WriteLine(Print2DList(AllConstruct("enterapotentpot", new[] { "a", "p", "ent", "enter", "ot", "o", "t" })));
            Console.WriteLine(Print2DList(AllConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" })));
            Console.WriteLine();

            // -----------------

            Console.WriteLine(FibonacciTabSample.GetFibonacciNumber(6));
            Console.WriteLine(FibonacciTabSample.GetFibonacciNumber(7));
            Console.WriteLine(FibonacciTabSample.GetFibonacciNumber(8));
            Console.WriteLine(FibonacciTabSample.GetFibonacciNumber(50));
            Console.WriteLine();
        }

        static string PrintList(List<int> values)
        {
            if (values is null) { return "null"; }
            return string.Join(',', values);
        }

        static string Print2DList(List<List<string>> values)
        {
            if (values is null) { return "null"; }
            StringBuilder resultBuilder = new StringBuilder();
            foreach (List<string> innerList in values) {
                resultBuilder.AppendLine(string.Join(',', innerList));
            }

            return resultBuilder.ToString();
        }
    }
}