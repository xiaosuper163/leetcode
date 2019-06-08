public class Solution {
    private int centerLength(string s, int left, int right) {
        int l = left, r = right;
        while (l >= 0 && r <= s.Length-1) {
            if (s[l] == s[r]) {
                l--;
                r++;
            } else {
                break;
            }
        }
        return r - l - 1;
    }
    public string LongestPalindrome(string s) {
        if (s == null || s.Length < 1) return "";
        int start = 0, end = 0;
        for (int i = 0; i < s.Length; i++) {
            int len1 = centerLength(s, i, i);
            int len2 = centerLength(s, i, i+1);
            int len = Math.Max(len1, len2);
            if (len > end - start) {
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }
        return s.Substring(start, end - start + 1);
    }
}