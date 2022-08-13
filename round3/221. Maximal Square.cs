public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int m = matrix.Length, n = matrix[0].Length, len = 0;
        int[][] dp = new int[m][];
        for (int i = 0; i < m; i ++) {
            dp[i] = new int[n];
            dp[i][0] = matrix[i][0] == '1' ? 1 : 0;
            if (dp[i][0] == 1) len = 1;
        }
        
        for (int j = 1; j < n; j ++) {
            dp[0][j] = matrix[0][j] == '1' ? 1 : 0;
            if (dp[0][j] == 1) len = 1;
        }
        
        for (int i = 1; i < m; i ++) {
            for (int j = 1; j < n; j ++) {
                if (matrix[i][j] == '0') dp[i][j] = 0;
                else {
                    dp[i][j] = Math.Min(Math.Min(dp[i-1][j], dp[i][j-1]), dp[i-1][j-1]) + 1;
                    len = Math.Max(len, dp[i][j]);
                }
            }
        }
        
        return len * len;
    }
}