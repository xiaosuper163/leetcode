public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if (nums.Length == 0) {
            return 0;
        }
        
        if (target > nums[nums.Length - 1]) {
            return nums.Length;
        }
        
        int start = 0, end = nums.Length - 1;
        while (start + 1 < end) {
            int mid = (int) (end - start) / 2 + start;
            if (target == nums[mid]) {
                return mid;
            } else if (target < nums[mid]) {
                end = mid;
            } else {
                start = mid;
            }
        }
        
        if (target <= nums[start]) {
            return start;
        } else {
            return end;
        }
    }
}