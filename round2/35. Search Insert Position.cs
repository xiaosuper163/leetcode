public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int start = 0, end = nums.Length - 1;
        while(start + 1 < end) {
            int mid = (int) (end-start)/2 + start;
            if (nums[mid] == target) {
                return mid;
            } else if (nums[mid] < target) {
                start = mid;
            } else {
                end = mid;
            }
        }

        if (nums[start] >= target) {
            return start;
        } else if (nums[end] < target) {
            return end + 1;
        } else {
            return start + 1;
        }
    }
}