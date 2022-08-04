public class Solution {
    public int CalculateMinimumHP(int[][] dungeon) {
        int m = dungeon.Length, n = dungeon[0].Length;
                
        int[][] dp = new int[m][];
        for (int i = 0; i < m; i ++) {
            dp[i] = new int[n];
        }
        
        dp[m-1][n-1] = Math.Max(1 - dungeon[m-1][n-1], 1);
        
        for (int i = m - 2; i >= 0; i --) {
            dp[i][n-1] = Math.Max(dp[i+1][n-1] - dungeon[i][n-1], 1);
        }
        
        for (int j = n - 2; j >= 0; j --) {
            dp[m-1][j] = Math.Max(dp[m-1][j+1] - dungeon[m-1][j], 1);
        }
        
        for (int i = m - 2; i >= 0; i --) {
            for (int j = n - 2; j >= 0; j --) {
                dp[i][j] = Math.Max(Math.Min(dp[i+1][j], dp[i][j+1]) - dungeon[i][j], 1);
            }
        }
        
        return dp[0][0];
    }
}