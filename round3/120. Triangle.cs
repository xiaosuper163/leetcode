public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        if (triangle.Count == 1) return triangle[0][0];
        
        var dp = new List<int>(triangle.Last());
        for (int i = triangle.Count - 2; i >= 0; i--) {
            for (int j = 0; j < i + 1; j++) {
                dp[j] = triangle[i][j] + Math.Min(dp[j], dp[j+1]);
            }
        }
        
        return dp[0];
    }
}