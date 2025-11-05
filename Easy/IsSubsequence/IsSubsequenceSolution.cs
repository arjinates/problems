public class IsSubsequenceSolution
{ // Time Complexity: O(n), Space Complexity: O(1)
    public bool IsSubsequence(string s, string t)
    {
        int sPointer = 0;
        int tPointer = 0;

        while (sPointer < s.Length && tPointer < t.Length)
        {
            if (s[sPointer] == t[tPointer])
            {
                sPointer++;
            }
            tPointer++;
        }
        if (sPointer == s.Length) return true;
        else return false;
    }
}