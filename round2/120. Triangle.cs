public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        if (triangle.Count == 0 || triangle[0].Count == 0) return 0;
        List<int> dp = new List<int>(triangle[triangle.Count-1]);
        dp[0] = triangle[0][0];
        for (int i=1; i<triangle.Count; i++) {
            int mem = dp[0], tmp = 0;
            dp[0] += triangle[i][0];
            for (int j=1; j<i; j++) {
                tmp = dp[j];
                dp[j] = Math.Min(mem, dp[j]) + triangle[i][j];
                mem = tmp;
            }
            dp[i] = mem + triangle[i][i];
        }
        return dp.Min();
    }
}