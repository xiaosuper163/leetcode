public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if (nums.Length == 0) return 0;
        int size = 0;
        for (int index=0; index<nums.Length; index++) {
            if (nums[index] != val) {
                nums[size] = nums[index];
                size ++;
            }
        }
        return size;
    }
}