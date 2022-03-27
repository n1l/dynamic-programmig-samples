using DynamicProgrammingSamples.Memoization;
using System;
using System.Collections.Generic;

namespace DynamicProgrammingSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciSample.GetFibonacciNumber(6));
            Console.WriteLine(FibonacciSample.GetFibonacciNumber(7));
            Console.WriteLine(FibonacciSample.GetFibonacciNumber(8));
            Console.WriteLine(FibonacciSample.GetFibonacciNumber(50));
            Console.WriteLine();

            // -----------------

            Console.WriteLine(GridTravalerSample.GridTravaler(1,1));
            Console.WriteLine(GridTravalerSample.GridTravaler(2, 3));
            Console.WriteLine(GridTravalerSample.GridTravaler(3, 2));
            Console.WriteLine(GridTravalerSample.GridTravaler(3, 3));
            Console.WriteLine(GridTravalerSample.GridTravaler(18, 18));
            Console.WriteLine();

            // -----------------

            Console.WriteLine(CanSumSample.CanSum(7, new[] { 2, 3 }));
            Console.WriteLine(CanSumSample.CanSum(7, new[] { 5, 3, 4, 7 }));
            Console.WriteLine(CanSumSample.CanSum(7, new[] { 2, 4 }));
            Console.WriteLine(CanSumSample.CanSum(8, new[] { 2, 3, 5 }));
            Console.WriteLine(CanSumSample.CanSum(300, new[] { 7, 14 }));
            Console.WriteLine();

            // -----------------

            Console.WriteLine(PrintList(HowSumSample.HowSum(7, new[] { 2, 3 })));
            Console.WriteLine(PrintList(HowSumSample.HowSum(7, new[] { 5, 3, 4, 7 })));
            Console.WriteLine(PrintList(HowSumSample.HowSum(7, new[] { 2, 4 })));
            Console.WriteLine(PrintList(HowSumSample.HowSum(8, new[] { 2, 3, 5 })));
            Console.WriteLine(PrintList(HowSumSample.HowSum(300, new[] { 7, 14 })));
            Console.WriteLine();

            // -----------------

            Console.WriteLine(PrintList(BestSumSample.BestSum(7, new[] { 5, 3, 4, 7 })));
            Console.WriteLine(PrintList(BestSumSample.BestSum(8, new[] { 2, 3, 5 })));
            Console.WriteLine(PrintList(BestSumSample.BestSum(8, new[] { 1, 4, 5 })));
            Console.WriteLine(PrintList(BestSumSample.BestSum(100, new[] { 1, 2, 5, 25 })));
            Console.WriteLine();
        }

        static string PrintList(List<int> values)
        {
            if (values is null) { return "null"; }
            return string.Join(',', values);
        }
    }
}
