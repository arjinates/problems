public class RemoveDuplicatesV2{
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length <= 2) return nums.Length;

        int j = 2;

        for(int i = 2; i < nums.Length; i++){
            if(nums[i] != nums[j-2]){
                nums[j] = nums[i];
                j++;
            }
        }
        return j;
    }
}