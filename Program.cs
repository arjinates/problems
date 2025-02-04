using System;
using Problems.Easy.SecondLargestInteger;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            var secondLargestIntegerClass = new SecondLargestIntegerSolution();
            int secondLargest = secondLargestIntegerClass.GenerateRandomArrayAndReturnAnswer(10);
            Console.WriteLine($"Second largest: {secondLargest}");

            var fizzBuzzSolution = new FizzBuzzSolution();
            var responseList = fizzBuzzSolution.FizzBuzz(15);
            foreach (string response in responseList)
            {
                Console.WriteLine(response);
            }
        }
    }
}