public class Solution {
    public int NumDistinct(string s, string t) {
        int m = s.Length, n = t.Length;
        int[][] dp = new int[m + 1][];
        for (int i = 0; i <= m; i ++) {
            dp[i] = new int[n + 1];
        }
                
        for (int i = 0; i <= m; i ++) {
            for (int j = 0; j <= n; j ++) {
                if (i == 0 && j == 0) 
                    dp[i][j] = 1;
                else if (i == 0)
                    dp[i][j] = 0;
                else if (j == 0)
                    dp[i][j] = 1;
                else
                    dp[i][j] = s[i - 1] == t[j - 1] ? dp[i - 1][j - 1] + dp[i - 1][j]: dp[i - 1][j];
            }
        }
        
        return dp[m][n];
    }
}