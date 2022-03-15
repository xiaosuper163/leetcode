public class Solution {
    public int MinPathSum(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        if (m == 1) return grid[0].Sum();
                
        var dp = new int[n];
        // initialize
        dp[0] = grid[0][0];
        for (int i = 1; i < n; i++) {
            dp[i] = grid[0][i] + dp[i-1];
        }
        
        // populate
        for (int i = 1; i < m; i ++) {
            dp[0] = dp[0] + grid[i][0];
            for (int j = 1; j < n; j ++) {
                dp[j] = Math.Min(dp[j-1], dp[j]) + grid[i][j];
            }
        }
        
        return dp[n-1];
    }
}