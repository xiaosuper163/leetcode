public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if (nums.Length == 0) return new int[]{-1,-1};
        
        int left = 0, right = nums.Length - 1, lo, hi;
        while (left + 1 < right) {
            int mid = (int) (right - left) / 2 + left;
            if (nums[mid] >= target) {
                right = mid;
            } else {
                left = mid;
            }
        }
        if (nums[left] == target) {
            lo = left;
        } else if (nums[right] == target) {
            lo = right;
        } else {
            return new int[]{-1,-1};
        }
        
        left = 0;
        right = nums.Length - 1;
        while (left + 1 < right) {
            int mid = (int) (right - left) / 2 + left;
            if (nums[mid] <= target) {
                left = mid;
            } else {
                right = mid;
            }
        }
        if (nums[right] == target) {
            hi = right;
        } else {
            hi = left;
        }
        
        return new int[] {lo, hi};
    }
}