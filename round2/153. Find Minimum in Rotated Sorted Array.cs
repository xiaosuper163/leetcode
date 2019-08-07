public class Solution {
    public int FindMin(int[] nums) {
        if (nums[0] <= nums[nums.Length-1]) return nums[0];
        int left = 0, right = nums.Length - 1;
        while (left + 1 < right) {
            int mid = (right - left) / 2 + left;
            if (nums[mid] > nums[left]) {
                left = mid;
            } else {
                right = mid;
            }
        }
        return Math.Min(nums[left], nums[right]);
    }
}