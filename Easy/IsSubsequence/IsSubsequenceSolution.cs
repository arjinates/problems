public class IsSubsequenceSolution {
    public bool IsSubsequence(string s, string t) { // Time Complexity: O(n), Space Complexity: O(1)
       int i = 0, j = 0;

       while(i < s.Length && j < t.Length){
            if (s[i] == t[i])
            {
                i++;
            }

            j++;
       }

       return i == s.Length;
    }
}