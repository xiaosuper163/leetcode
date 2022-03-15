public class Solution {
    public int NumSquares(int n) {
        var dp = new int[n + 1];
        dp[0] = 0;
        for (int i = 1; i <= n; i ++) {
            dp[i] = i;
            int sqrt = (int) Math.Sqrt(i);
            for (int j = 1; j <= sqrt; j ++) {
                dp[i] = Math.Min(dp[i], dp[i - j*j] + 1);
            }
        }
        
        return dp[n];
    }
}