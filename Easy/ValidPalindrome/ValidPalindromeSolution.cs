using System.Text.RegularExpressions;
public class ValidPalindromeSolution {
    public bool IsPalindrome(string s) {
        s = Regex.Replace(s, "[^A-Za-z0-9]", "").ToLowerInvariant();

        for(int i=0; i < s.Length/2; i++){
            if(s[i] != s[s.Length-i-1]) return false;
        }        
        return true;
    }
}