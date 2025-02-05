namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var secondLargestIntegerClass = new SecondLargestIntegerSolution();
            // int secondLargest = secondLargestIntegerClass.GenerateRandomArrayAndReturnAnswer(10);
            // Console.WriteLine($"Second largest: {secondLargest}");

             var fizzBuzzSolution = new FizzBuzzSolution();
            // var responseList = fizzBuzzSolution.FizzBuzz(15);
            // foreach (string response in responseList)
            // {
            //     Console.WriteLine(response);
            // }

            var mergeSortedArraySolution = new MergeSortedArraySolution();
            int[] nums1 = new int[] {1, 2, 3, 0, 0, 0};
            int[] nums2 = new int[] {2, 5, 6};
            mergeSortedArraySolution.Merge(nums1, 3, nums2, 3);
            foreach (int number in nums1)
            {
                Console.Write(number + " ");
            }
        }
    }
}