class ContainsDuplicateIISolution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var lastIndexMap = new Dictionary<int, int>();

        for(int i=0; i<nums.Length; i++){
            var num = nums[i];

            if(lastIndexMap.TryGetValue(num, out var value)){
                if(i-value <= k) return true;
                lastIndexMap[nums[i]] = i;
            }

            else{
                lastIndexMap.Add(nums[i], i);
            }
        }
        return false;
    }
}