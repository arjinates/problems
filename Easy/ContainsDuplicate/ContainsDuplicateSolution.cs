public class ContainsDuplicateSolution {
    public bool ContainsDuplicateBruteForce(int[] nums) { // Time Complexity: O(n2), Space Complexity: O(1) but if input is too large, than that is a big problem
       for(int i = 0; i < nums.Length; i++){
           for (int j = 1; j < nums.Length; j++)
           {
                if(nums[i] == nums[j] && i != j){
                     return true;
                }
           }
       }
       return false;
    }

    public bool ContainsDuplicateOptimal(int[] nums) { // Time Complexity: O(n), Space Complexity: O(n)
       HashSet<int> set = new HashSet<int>();
       foreach (var num in nums)
       {
            if (set.Contains(num))
            {
                return true;
            }
            set.Add(num);
       }
         return false;
    }

}


























//  HashSet<int> set = new HashSet<int>();
//         foreach(int num in nums){
//             if(set.Contains(num)){
//                 return true;
//             }
//             set.Add(num);
//         }
//         return false;