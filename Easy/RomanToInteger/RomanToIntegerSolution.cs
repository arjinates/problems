using System.ComponentModel;

public class RomanToIntegerSolution{
    public int RomanToInt(string s) { // Time Complexity: O(n), Space Complexity: O(1)
        var dict = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int sum = 0;
        int prevValue = 0;

        for (int i = s.Length -1 ; i >= 0; i--)
        {
            int currentVal = dict[s[i]];

            if (currentVal < prevValue)
            {
                sum -= currentVal;
            }
            else
            {
                 sum += currentVal;
            }

            prevValue = currentVal;
        }
        
        return sum;
    }
}