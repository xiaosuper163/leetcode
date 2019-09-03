public class Solution {
    public int MaximalSquare(char[][] matrix) {
        if (matrix.Length == 0 || matrix[0].Length == 0) return 0;
        int[][] dp = new int[matrix.Length][];
        int res = 0;
        for (int i=0; i<matrix.Length; i++) {
            dp[i] = new int[matrix[0].Length];
            dp[i][0] = matrix[i][0] - '0';
            if (dp[i][0] == 1) res = 1;
        }
        for (int j=1; j<matrix[0].Length; j++) {
            dp[0][j] = matrix[0][j] - '0';
            if (dp[0][j] == 1) res = 1;
        }
        for (int i=1; i<matrix.Length; i++) {
            for (int j=1; j<matrix[0].Length; j++) {
                if (matrix[i][j] == '1') {
                    dp[i][j] = Math.Min(Math.Min(dp[i-1][j], dp[i][j-1]), dp[i-1][j-1]) + 1;
                    res = Math.Max(res, dp[i][j]);
                } else {
                    dp[i][j] = 0;
                }
            }
        }
        return res*res;
    }
}