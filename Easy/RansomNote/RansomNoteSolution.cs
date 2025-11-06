public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) { //O(n+m) time, O(1) space
        if (ransomNote.Length > magazine.Length) return false; // erken çıkış
        var count = new int[26];

        foreach(char c in magazine){
            count[c - 'a']++;
        }

        foreach(char c in ransomNote){
            if(--count[c - 'a'] < 0){
                return false;
            }
        }

        return true;
    }
}