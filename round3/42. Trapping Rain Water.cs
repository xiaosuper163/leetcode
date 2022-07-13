public class Solution {
    public int Trap(int[] height) {
        int[] dp = new int[height.Length];
        
        int leftMax = 0;
        int rightMax = int.MinValue;
        int res = 0;
        
        for (int i = 0; i < height.Length; i ++) {
            dp[i] = leftMax;
            leftMax = Math.Max(height[i], leftMax);            
        }
        
        for (int j = height.Length - 1; j >= 0; j --) {
            if (dp[j] > height[j] && rightMax > height[j]) {
                res += Math.Min(dp[j], rightMax) - height[j];
            }
            rightMax = Math.Max(height[j], rightMax);
        }
        
        return res;
    }
}