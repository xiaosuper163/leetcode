public class Solution {
    public IList<int> GetRow(int rowIndex) {
        int[] dp = new int[rowIndex + 1];
        dp[0] = 1;
        
        int prev = 1, curr;
        
        for (int i = 1; i <= rowIndex; i ++) {
            dp[i] = 1;
            for (int j = 1; j < i; j ++) {
                curr = dp[j];
                dp[j] += prev;
                prev = curr;
            } 
        }
        
        return dp.ToList();
    }
}