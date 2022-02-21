public class Solution {
    public int FindPeakElement(int[] nums) {
        int start = 0, end = nums.Length - 1;
        while (start + 1 < end) {
            int mid = (int) (end-start) / 2 + start;
            if ((mid == 0 || nums[mid] > nums[mid-1]) && (mid == nums.Length-1 ||nums[mid] > nums[mid+1])) {
                return mid;
            } else if (nums[mid] < nums[mid-1] && nums[mid] > nums[mid+1]) {
                end = mid;
            } else {
                start = mid;
            }
        }
        
        if ((start == 0 || nums[start] > nums[start-1]) && (start == nums.Length-1 ||nums[start] > nums[start+1])) {
            return start;
        } else {
            return end;
        }
    }
}