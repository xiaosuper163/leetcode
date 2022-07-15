public class Solution {
    public bool CanJump(int[] nums) {
        int currMax = nums[0];
        
        for (int i = 1; i < nums.Length; i++) {
            if (currMax < i) return false;
            
            currMax = Math.Max(currMax, i + nums[i]);
            
        }
        
        return true;
    }
}