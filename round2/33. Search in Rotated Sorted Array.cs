public class Solution {
    private bool IsAfterPivot(int[] nums, int index) {
        return nums[index] <= nums[nums.Length-1];
    }
    
    public int Search(int[] nums, int target) {
        if (nums.Length == 0) return -1;
        
        int start = 0, end = nums.Length -1, pivotIndex = 0;
        while (start + 1 < end) {
            int mid = (int) (end-start)/2 + start;
            if (IsAfterPivot(nums, mid)) {
                end = mid;
            } else {
                start = mid;
            }
        }
        
        if (IsAfterPivot(nums, end)) pivotIndex = end;
        if (IsAfterPivot(nums, start)) pivotIndex = start;
        
        if (pivotIndex == 0) {
            start = 0;
            end = nums.Length - 1;
        } else if (nums[0] == target) {
            return 0;
        } else if (nums[0] < target) {
            start = 0;
            end = pivotIndex-1;
        } else {
            start = pivotIndex;
            end = nums.Length-1;
        }
        while (start + 1 < end) {
            int mid = (int) (end-start)/2 + start;
            if (nums[mid] == target) {
                return mid;
            } else if (nums[mid] < target) {
                start = mid;
            } else {
                end = mid;
            }
        }
        if (nums[start] == target) return start;
        if (nums[end] == target) return end;
        
        return -1;
    }
}