public class Solution {
    public int FindMin(int[] nums) {
        int left = 0, right = nums.Length - 1;        
        while (left + 1 < right) {
            if (nums[left] < nums[right]) return nums[left];
            int mid = (right - left) / 2 + left;
            if ((mid + 1 == nums.Length || nums[mid] < nums[mid + 1]) && (mid == 0 || nums[mid] < nums[mid - 1])) {
                return nums[mid];
            }
            if (nums[mid] > nums[left]) {
                left = mid;
            } else {
                right = mid;
            }
        }
        return Math.Min(nums[left], nums[right]);
    }
}