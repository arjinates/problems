using System;
using System.Diagnostics;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            var twoSumSolution = new TwoSumSolution();
            var nums = new int[1000000];
            var random = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(1, 1000000);
            }
            var target = nums[0] + nums[nums.Length - 1];

            // Measure runtime and memory for Brute Force solution
            var stopwatch = Stopwatch.StartNew();
            var initialMemory = GC.GetTotalMemory(true);
            var result = twoSumSolution.TwoSumBruteForce(nums, target);
            stopwatch.Stop();
            var finalMemory = GC.GetTotalMemory(true);
            var memoryUsed = finalMemory - initialMemory;
            Console.WriteLine($"Brute Force: [{result[0]}, {result[1]}]");
            Console.WriteLine($"Brute Force Runtime: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Brute Force Memory: {memoryUsed} bytes");

            // Measure runtime and memory for Optimized solution
            stopwatch.Restart();
            initialMemory = GC.GetTotalMemory(true);
            result = twoSumSolution.TwoSumOptimized(nums, target);
            stopwatch.Stop();
            finalMemory = GC.GetTotalMemory(true);
            memoryUsed = finalMemory - initialMemory;
            Console.WriteLine($"Optimized: [{result[0]}, {result[1]}]");
            Console.WriteLine($"Optimized Runtime: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Optimized Memory: {memoryUsed} bytes");
        }
    }
}