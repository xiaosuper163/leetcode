public class Solution {
    public void NextPermutation(int[] nums) {
        for (int i = nums.Length - 2; i >= 0; i --) {
            if (nums[i] < nums[i+1]) {
                for (int j = nums.Length - 1; j > i; j --) {
                    if (nums[j] > nums[i]) {
                        int temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;                        
                        
                        Array.Reverse(nums, i + 1, nums.Length - i - 1);
                        return;
                    }
                }                
            }
        }
        
        Array.Reverse(nums);
    }
}