public class Solution {
    public int Search(int[] nums, int target) {
        int start = 0, end = nums.Length - 1;
        while (start + 1 < end) {
            int mid = (int) (end - start) / 2 + start;
            if (target == nums[mid]) {
                return mid;
            } else if (nums[start] < nums[mid]) {
                if (nums[start] <= target && target < nums[mid]) {
                    end = mid;
                } else {
                    start = mid;
                }
            } else {
                if (nums[mid] < target && target <= nums[end]) {
                    start = mid;
                } else {
                    end = mid;
                }
            }
        }
        
        if (nums[start] == target) {
            return start;
        } else if (nums[end] == target) {
            return end;
        } else {
            return -1;
        }
    }
}