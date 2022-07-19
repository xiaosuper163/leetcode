public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int count = 1;
        int cursor = 1;
        
        for (int i = 1; i < nums.Length; i ++) {
            if (nums[i] == nums[i-1] && count == 2) {
                continue;
            } else {
                if (nums[i] != nums[i-1]) count = 0;
                nums[cursor ++] = nums[i];                
                count ++;
            }
        }
        
        return cursor;
    }
}