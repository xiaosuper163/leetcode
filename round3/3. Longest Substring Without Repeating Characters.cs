public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0, right = 0;
        var dict = new Dictionary<char, int>();
        int res = 0;
        while (right < s.Length) {
            if (!dict.ContainsKey(s[right])) {
                dict[s[right]] = right;
                res = Math.Max(res, right - left + 1);
            } else {
                while (left != dict[s[right]]) {
                    dict.Remove(s[left]);
                    left ++;
                }
                left = dict[s[right]] + 1;
                dict[s[right]] = right;
            }
            
            right ++;
        }
        
        return res;
    }
}