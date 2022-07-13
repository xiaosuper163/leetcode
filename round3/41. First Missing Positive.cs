public class Solution {
    public int FirstMissingPositive(int[] nums) {
        for (int i = 0; i < nums.Length; i ++) {
            int num = nums[i];
            if (num <= 0 || num >= nums.Length || num == i + 1 || num == nums[num - 1]) continue;
            
            Swap(nums, i, num - 1);
            i--;
        }
        
        for (int i = 0; i < nums.Length; i ++) {
            if (nums[i] != i + 1) {
                return i + 1;
            }
        }
        
        return nums.Length + 1;
    }
    
    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}