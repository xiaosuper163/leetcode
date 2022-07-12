public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 1) return 1;
        
        int curr = nums[0];
        int cursor = 1;
        
        for (int i = 1; i < nums.Length; i ++) {
            if (nums[i] != curr) {
                curr = nums[i];
                nums[cursor++] = nums[i];
            }
        }
        
        return cursor;
    }
}