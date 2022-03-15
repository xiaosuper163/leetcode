public class Solution {
    public int UniquePaths(int m, int n) {
        var dp = new int[n];
        
        for (int j = 0; j < n; j ++) {
            dp[j] = 1;
        }
        
        for (int i = 1; i < m; i ++) {
            for (int j = 1; j < n; j ++) {
                dp[j] = dp[j] + dp[j-1];
            }
        }
        
        return dp[n-1];
    }
}