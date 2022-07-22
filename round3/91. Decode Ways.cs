public class Solution {
    public int NumDecodings(string s) {
        if (s[0] == '0') return 0;
        
        int[] dp = new int[s.Length];
        
        dp[0] = 1;
        
        for (int i = 1; i < s.Length; i++) {
            if (s[i-1] == '1' || (s[i-1] == '2' && s[i] <= '6' && s[i] >= '0')) {
                dp[i] += i >= 2 ? dp[i-2] : 1;
            }
            if (s[i] != '0') 
                dp[i] += dp[i-1];
            else {
                if (s[i-1] != '1' && s[i-1] != '2') return 0;
            }
        }
        
        return dp[s.Length - 1];
    }
}