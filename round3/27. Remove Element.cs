public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int cursor = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != val) {
                nums[cursor++] = nums[i];
            }
        }
        
        return cursor;
    }
}