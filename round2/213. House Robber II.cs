public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];
        return Math.Max(Helper(nums, 0, nums.Length-2), Helper(nums, 1, nums.Length-1));
    }
    private int Helper(int[] nums, int start, int end) {
        int pre = 0, curr = nums[start];
        for (int i=start+1; i<=end; i++) {
            int tmp = curr;
            curr = Math.Max(pre+nums[i], curr);
            pre = tmp;
        }
        return curr;
    }
}