public class Solution {
    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
    
    private void Reverse(int[] nums, int start) {
        int end = nums.Length - 1;
        while (start < end) {
            Swap(nums, start, end);
            start++;
            end--;
        }
    }
    
    public void NextPermutation(int[] nums) {
        int index = -1;
        for (int i = nums.Length-1; i >= 1; i--) {
            if (nums[i] > nums[i-1]) {
                index = i - 1;
                break;
            }
        }
        
        if (index == -1) {
            Reverse(nums, 0);
        } else {
            int j = nums.Length - 1;
            while (j >= 0 && nums[j] <= nums[index]) {
                j--;
            }
            Swap(nums, index, j);
            Reverse(nums, index+1);
        }
    }
}