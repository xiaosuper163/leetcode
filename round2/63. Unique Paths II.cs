public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        if (obstacleGrid[0][0] == 1) return 0;
        int m = obstacleGrid.Length;
        if (m == 0) return 0;
        int n = obstacleGrid[0].Length;
        if (n == 0) return 0;
        int[] dp = new int[n];
        dp[0] = 1;
        for (int i=1; i<n; i++) {
            if (obstacleGrid[0][i] == 1) {
                dp[i] = 0;
            } else {
                dp[i] = dp[i-1] == 1 ? 1 : 0;
            }
        }
        for (int j=1; j<m; j++) {
            for (int i=0; i<n; i++) {
                if (obstacleGrid[j][i] == 1) {
                    dp[i] = 0;
                } else if (i==0) {
                    dp[i] = dp[i] == 1 ? 1 : 0;
                } else {
                    dp[i] += dp[i-1];
                }
            }
        }
        return dp[n-1];
    }
}