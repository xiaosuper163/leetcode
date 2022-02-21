public class Solution {
    public int[] SearchRange(int[] nums, int target) {        
        int[] ret = new int[2];
        
        if (nums.Length == 0) {
            ret[0] = -1;
            ret[1] = -1;
            return ret;
        }
        
        int start = 0;
        int end = nums.Length - 1;
        while (start + 1 < end) {
            int mid = (int) (end - start) / 2 + start;
            if (target == nums[mid]) {
                end = mid;
            } else if (target < nums[mid]) {
                end = mid;
            } else {
                start = mid;
            }
        }
        
        if (nums[start] == target) {
            ret[0] = start;
        } else if (nums[end] == target) {
            ret[0] = end;
        } else {
            ret[0] = -1;
            ret[1] = -1;
            return ret;
        }
        
        start = 0;
        end = nums.Length - 1;
        while (start + 1 < end) {
            int mid = (int) (end - start) / 2 + start;
            if (target == nums[mid]) {
                start = mid;
            } else if (target < nums[mid]) {
                end = mid;
            } else {
                start = mid;
            }
        }
        
        if (nums[end] == target) {
            ret[1] = end;
        } else {
            ret[1] = start;
        }
        
        
        return ret;
    }
}