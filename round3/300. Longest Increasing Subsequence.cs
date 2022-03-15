public class Solution {
    public int LengthOfLIS(int[] nums) {
        var dp = new int[nums.Length];
        dp[0] = 1;
        for (int i = 1; i < nums.Length; i ++) {
            dp[i] = 1;
            for (int j = 0; j < i; j ++) {
                if (nums[i] > nums[j]) dp[i] = Math.Max(dp[i], dp[j] + 1);
            }
        }
        
        return dp.Max();
    }
}