public class Solution {
    private void Swap(int[] nums, int index1, int index2) {
        int temp = nums[index1];
        nums[index1] = nums[index2];
        nums[index2] = temp;
    }
    public void SortColors(int[] nums) {
        int p1 = 0, p2 = nums.Length-1;
        for (int i=0; i<nums.Length; i++) {
            if (nums[i] == 0 && i!=p1) {
                Swap(nums, p1, i);
                p1++;
                i--;
            } else if (nums[i] == 2 && i<p2) {
                Swap(nums, p2, i);
                p2--;
                i--; 
            }
        }
    }
}