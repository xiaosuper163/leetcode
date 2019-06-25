public class Solution {
    public int MaxSubArray(int[] nums) {
        if (nums.Length == 0) return 0;
        int currSum = nums[0];
        int res = currSum;
        for (int i=1; i<nums.Length; i++) {
            currSum = currSum + nums[i] > nums[i] ? currSum + nums[i] : nums[i];
            res = res > currSum ? res : currSum;
        }
        return res;
    }
}