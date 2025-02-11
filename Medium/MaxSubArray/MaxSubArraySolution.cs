public class MaxSubArraySolution{
    public int MaxSubArray(int[] nums) { // Time Complexity: O(n), Space Complexity: O(1)
        int maxSum = nums[0];
        int currentSum = nums[0];
        for(int i = 1; i < nums.Length; i++){
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }
        return maxSum;
    }
        
}