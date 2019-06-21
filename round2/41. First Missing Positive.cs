public class Solution {
    private void Swap(int[] nums, int index1, int index2) {
        int temp = nums[index2];
        nums[index2] = nums[index1];
        nums[index1] = temp;
    }
    public int FirstMissingPositive(int[] nums) {
        if (nums.Length == 0) return 1;
        int i = 0;
        while (i < nums.Length) {
            if (nums[i]>0 && nums[i]<nums.Length && nums[i]-1 != i && nums[i] != nums[nums[i]-1]) {
                Swap(nums, i, nums[i]-1);
            } else {
                i++;
            }
        }
        
        i=0;
        while (i<nums.Length && nums[i]==i+1) i++;
        return i+1;
    }
}