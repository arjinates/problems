public class WordPatternSolution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(" ");
        
        if (pattern.Length != words.Length) {
            return false;
        }

        var charToWord = new Dictionary<char, string>();
        var wordToChar = new Dictionary<string, char>();

        for(int i=0; i < pattern.Length; i++){
            char ch = pattern[i];
            string word = words[i];

            if(charToWord.TryGetValue(ch, out var mapped)){
                if(mapped != word) return false;
            }
            else{
                if(wordToChar.TryGetValue(word, out var back)){
                    if(back != ch) return false;
                }

                charToWord[ch] = word;
                wordToChar[word] = ch;
            }
        }

        return true;
    }
}