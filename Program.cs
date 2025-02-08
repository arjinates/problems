using System;
using System.Diagnostics;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            var solution = new RomanToIntegerSolution();
            Console.WriteLine(solution.RomanToInt("III"));    // Output: 3
            Console.WriteLine(solution.RomanToInt("IV"));     // Output: 4
            Console.WriteLine(solution.RomanToInt("IX"));     // Output: 9
            Console.WriteLine(solution.RomanToInt("LVIII"));  // Output: 58
            Console.WriteLine(solution.RomanToInt("MCMXCIV"));// Output: 1994
        }
    }
}