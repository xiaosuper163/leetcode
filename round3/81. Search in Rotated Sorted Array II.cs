public class Solution {
    public bool Search(int[] nums, int target) {
        int start = 0, end = nums.Length - 1;
        
        while (start + 1 < end) {
            int mid = (end - start) / 2 + start;
            if (target == nums[mid] || target == nums[start] || target == nums[end]) return true;
            
            if (nums[mid] > nums[start]) {
                if (nums[start] < target && target < nums[mid]) {
                    end = mid;
                } else {
                    start = mid;
                }
            } else if (nums[mid] < nums[start]) {
                if (nums[mid] < target && target < nums[end]) {
                    start = mid;
                } else {
                    end = mid;
                }
            } else {
                start ++;
            }
        }
        
        return nums[start] == target || nums[end] == target;
    }
}