public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int left = 0, right = nums.Length - 1;
        while (true) {
            int curr = Partition(nums, left, right);
            if (curr == k - 1) return nums[k - 1];
            if (curr > k - 1) right = curr - 1;
            else left = curr + 1;
        }
    }
    
    private int Partition(int[] nums, int left, int right) {
        int pivot = nums[left], l = left + 1, r = right;
        while (l <= r) {
            if (nums[l] < pivot && nums[r] > pivot) Swap(nums, l, r);
            if (nums[l] >= pivot) l ++;
            if (nums[r] <= pivot) r --;            
        }
        
        Swap(nums, left, r);
        return r;
    }
    
    private void Swap(int[] nums, int left, int right) {
        int temp = nums[left];
        nums[left] = nums[right];
        nums[right] = temp;
    }
}