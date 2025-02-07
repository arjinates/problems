public class TwoSumSolution
{
    public int[] TwoSumBruteForce(int[] nums, int target) // Time Complexity: O(n^2), Space Complexity: O(1)
    {
        var indices = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    indices[0] = i;
                    indices[1] = j;
                    return indices;
                }
            }
        }
        throw new ArgumentException("No two sum solution");
    }

    public int[] TwoSumOptimized(int[] nums, int target) // Time Complexity: O(n), Space Complexity: O(n)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (map.ContainsKey(complement)) {
                return [map[complement], i];
            }
            map[nums[i]] = i;
        }

        throw new ArgumentException("No two sum solution");
    }

}