public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;
        int size = 1;
        for (int index=1; index<nums.Length; index++) {
            if (nums[index] != nums[index-1]) {
                nums[size] = nums[index];
                size ++;
            }
        }
        return size;
    }
}