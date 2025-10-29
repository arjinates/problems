public class LengthOfLastWordSolution {
    public int LengthOfLastWord(string s) {
        int i = s.Length - 1;
        int size = 0;

        while (i >= 0 && s[i] == ' '){
            i--;
        }

        while(i >= 0 && s[i] != ' '){
            size++;
            i--;
        }

        return size;
    }
}