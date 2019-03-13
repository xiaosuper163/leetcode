public class Solution {
    public int FindMin(int[] nums) {
        int start = 0;
        int end = nums.Length - 1;
        while (nums[start] == nums[end] && start != end) {
            start++;
        }
        
        if (nums[start] < nums[end]) {
            return nums[start];
        }
        
        while (start + 1 < end) {
            int mid = (int) ((end - start) / 2) + start;
            if (nums[start] <= nums[mid]) {
                start = mid;
            } else {
                end = mid;
            }
        }
        return Math.Min(nums[start], nums[end]);
    }
}