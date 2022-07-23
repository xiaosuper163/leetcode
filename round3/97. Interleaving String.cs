public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {        
        int m = s1.Length, n = s2.Length;
        if (m + n != s3.Length) return false;
        bool[][] dp = new bool[m+1][];
        for (int i = 0; i <= m; i ++) {
            dp[i] = new bool[n+1];
        }
        
        dp[0][0] = true;
        for (int i = 1; i <= m; i ++) {
            dp[i][0] = s1[i - 1] == s3[i - 1] ? dp[i - 1][0] : false;
        }
        
        for (int j = 1; j <= n; j ++) {
            dp[0][j] = s2[j - 1] == s3[j - 1] ? dp[0][j - 1] : false;
        }
        
        for (int i = 1; i <= m; i ++) {
            for (int j = 1; j <= n; j ++) {
                dp[i][j] = (dp[i-1][j] && s1[i-1] == s3[i-1+j]) || (dp[i][j-1] && s2[j-1] == s3[i+j-1]);
            }
        }
        
        return dp[m][n];
    }
}