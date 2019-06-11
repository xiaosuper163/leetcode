public class Solution {
    public int RomanToInt(string s) {
        var helperDict = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        int res = 0;
        
        for (int i=0; i<s.Length; i++) {
            res += helperDict[s[i]];
            if (i < s.Length-1) {
                string temp = s.Substring(i,2);
                if (temp.Equals("IV") || temp.Equals("IX")) res -= 2;
                if (temp.Equals("XL") || temp.Equals("XC")) res -= 20;
                if (temp.Equals("CD") || temp.Equals("CM")) res -= 200;
                Console.Write(res);
            }
        }
        return res;
    }
}