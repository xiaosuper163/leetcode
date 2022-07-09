public class Solution {
    public string IntToRoman(int num) {
        Dictionary<int, string> dict = new Dictionary<int, string>() {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };
        
        int[] bs = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        
        int cnt = 0;
        var sb = new StringBuilder();
        
        foreach (int b in bs) {
            if (num >= b) {
                cnt = num / b;
                num -= cnt * b;
                
                for (int i = 0; i < cnt; i ++) {
                    sb.Append(dict[b]);
                }
            }
        }
        
        return sb.ToString();
    }
}