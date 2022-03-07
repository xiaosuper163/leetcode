public class Solution {
    public int MaxSubArray(int[] nums) {
        int minSum = 0;
        int maxSum = int.MinValue;
        int currSum = 0;
        
        for (int i=0; i<nums.Length; i++) {
            currSum += nums[i];            
            maxSum = maxSum > currSum - minSum ? maxSum : currSum - minSum;
            minSum = minSum < currSum ? minSum : currSum;
        }
        
        return maxSum;
    }
}