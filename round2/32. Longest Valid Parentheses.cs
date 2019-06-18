public class Solution {
    public int LongestValidParentheses(string s) {
        int res = 0;
        int[] dp = new int[s.Length];
        for (int i = 1; i < s.Length; i++) {
            if (s[i] == '(') {
                dp[i] = 0;
            } else {
                if (s[i-1] == '(') {
                    dp[i] = i>=2 ? dp[i-2]+2 : 2;
                } else if (i-dp[i-1] > 0 && s[i-dp[i-1]-1] == '(') {
                    dp[i] = dp[i-1] + 2 + (((i-dp[i-1]) >= 2) ? dp[i-dp[i-1]-2] : 0);
                } else {
                    dp[i] = 0;
                }
                res = Math.Max(res, dp[i]);
            }
        }
        return res;
    }
}