public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];
        int pre = 0, curr = nums[0];
        for (int i=1; i<nums.Length; i++) {
            int tmp = Math.Max(pre+nums[i], curr);
            pre = curr;
            curr = tmp;
        }
        return curr;
    }
}