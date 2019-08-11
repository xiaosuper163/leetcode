public class Solution {
    public int FindPeakElement(int[] nums) {
        if (nums.Length == 1) return 0;
        for(int i=0; i<nums.Length; i++) {
            if (i==0 && nums[0]>nums[1]) return 0;
            else if (i==0) continue;
            if (i==nums.Length-1 && nums[i] > nums[i-1]) return i;
            else if (i==nums.Length-1) continue;
            if (nums[i] > nums[i-1] && nums[i] > nums[i+1]) return i;
        }
        return 0;
    }
}