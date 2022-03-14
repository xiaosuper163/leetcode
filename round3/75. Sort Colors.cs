public class Solution {
    public void SortColors(int[] nums) {
        if (nums.Length == 0) return;
        
        int left = 0, right = nums.Length - 1;
        int i = 0;
        while (i <= right) {
            if (nums[i] == 0) {
                // if (i == left) {
                //     i ++;
                // } else {
                //     Swap(nums, left, i);
                // }                
                // left ++;
                Swap(nums, left, i);
                i++;
                left ++;
            } else if (nums[i] == 2) {
                Swap(nums, i, right);
                right --;
            } else {
                i ++;
            }
        }
    }
    
    private void Swap(int[] nums, int left, int right) {
        int temp = nums[left];
        nums[left] = nums[right];
        nums[right] = temp;
    }
}