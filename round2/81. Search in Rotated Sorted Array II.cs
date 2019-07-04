public class Solution {
    public bool Search(int[] nums, int target) {
        if (nums.Length == 0) return false;
        int start = 0, end = nums.Length-1;
        while (start + 1 < end) {
            int mid = (end-start) / 2 + start;
            if (nums[mid] == target) return true;
            if (nums[mid] < nums[end]) {
                if (nums[mid] < target && target <= nums[end]) {
                    start = mid;
                } else {
                    end = mid;
                }
            } else if (nums[mid] > nums[end]) {
                if (nums[start] <= target && target < nums[mid]) {
                    end = mid;
                } else {
                    start = mid;
                }
            } else {
                end--;
            }
        }
        if (nums[start] == target || nums[end] == target) return true;
        return false;
    }
}