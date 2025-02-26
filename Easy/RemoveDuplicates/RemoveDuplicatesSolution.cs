public class RemoveDuplicatesSolution{
    public int RemoveDuplicates(int[] nums) { // Time Complexity: O(n) Space Complexity: O(1)
        if (nums.Length == 0) return 0;
        int i = 0;
        for (int j = 1; j < nums.Length; j++) {
            if (nums[j] != nums[i]) {
                i++;
                nums[i] = nums[j];
            }
        }
        return i + 1;
    }
}