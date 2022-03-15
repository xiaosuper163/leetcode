public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int m = obstacleGrid.Length, n = obstacleGrid[0].Length;
        var dp = new int[n];
        
        for (int j = 0; j < n; j ++) {
            if (obstacleGrid[0][j] == 1) {
                while (j < n) {
                    dp[j] = 0;
                    j ++;
                }
            } else {
                dp[j] = 1;
            }
        }
        
        for (int i = 1; i < m; i++) {
            if (obstacleGrid[i][0] == 1) dp[0] = 0;
            for (int j = 1; j < n; j++) {
                if (obstacleGrid[i][j] == 1) {
                    dp[j] = 0;
                } else {
                    dp[j] = dp[j-1] + dp[j];
                }
            }
        }
        
        return dp[n-1];
    }
}