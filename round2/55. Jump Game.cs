public class Solution {
    public bool CanJump(int[] nums) {
        int currMax = 0;
        for (int i=0; i<nums.Length; i++) {
            if (currMax <i) return false;
            currMax = Math.Max(currMax, i+nums[i]);
        }
        return true;
    }
}