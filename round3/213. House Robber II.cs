public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1) return nums[0];
        return Math.Max(Rob(nums, 0, nums.Length - 2), Rob(nums, 1, nums.Length - 1));
    }
    
    public int Rob(int[] nums, int start, int end) {
        if (start == end) return nums[start];
        int prev1 = nums[start], prev2 = Math.Max(prev1, nums[start+1]), curr = prev2;
        for (int i = start+2; i <= end; i ++) {
            curr = Math.Max(prev1 + nums[i], prev2);
            prev1 = prev2;
            prev2 = curr;
        }
        return curr;
    }
}