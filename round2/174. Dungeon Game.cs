public class Solution {
    public int CalculateMinimumHP(int[][] dungeon) {
        int m = dungeon.Length;
        int n = dungeon[0].Length;
        int[] dp = new int[n];
        dp[n-1] = Math.Max(1, 1-dungeon[m-1][n-1]);
        for (int j=n-2; j>=0; j--) {
            dp[j] = Math.Max(1, dp[j+1]-dungeon[m-1][j]);
        }
        for (int i=m-2; i>=0; i--) {
            dp[n-1] = Math.Max(1, dp[n-1]-dungeon[i][n-1]);
            for (int j=n-2; j>=0; j--) {
                dp[j] = Math.Max(1, Math.Min(dp[j], dp[j+1])-dungeon[i][j]);
            }
        }
        return dp[0];
    }
}