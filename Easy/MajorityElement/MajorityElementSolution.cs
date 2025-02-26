public class MajorityElementSolution{
    public int MajorityElement(int[] nums) { // Time complexity: O(nlogn) Space complexity: O(1)
        Array.Sort(nums);
        return nums[nums.Length/2];
    }

    public int MajorityElement2(int[] nums) { // Time complexity: O(n) Space complexity: O(n)
        int n = nums.Length;

        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach(int num in nums){
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else{
                dict.Add(num,1);
            }
        }

        int majority = n/2;

        foreach(var item in dict){
            if(item.Value > majority){
                return item.Key;
            }
        }

        return 0;
    }
}