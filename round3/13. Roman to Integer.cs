public class Solution {
    public int RomanToInt(string s) {
        var dict = new Dictionary<string, int>() {
            {"M", 1000},
            {"CM", 900},
            {"D", 500},
            {"CD", 400},
            {"C", 100},
            {"XC", 90},
            {"L", 50},
            {"XL", 40},
            {"X", 10},
            {"IX", 9},
            {"V", 5},
            {"IV", 4},
            {"I", 1}
        };
        
        int i = 0, res = 0;
        
        while (i < s.Length) {
            if (i + 1 < s.Length && dict.ContainsKey(s.Substring(i, 2))) {
                res += dict[s.Substring(i, 2)];
                i += 2;
            } else {
                res += dict[s.Substring(i, 1)];
                i ++;
            }
        }
        
        return res;
    }
}