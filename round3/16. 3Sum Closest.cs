public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int minDiff = int.MaxValue;
        int res = 0;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++) {
            
            if (i > 0 && nums[i] == nums[i-1]) continue;
            
            int curr = nums[i];            
            int left = i + 1;
            int right = nums.Length - 1;
            
            while (left < right) {
                int diff = Math.Abs(curr + nums[left] + nums[right] - target);
                if (diff == 0) return target;
                
                if (diff < minDiff) {
                    res = curr + nums[left] + nums[right];
                    minDiff = diff;
                }
                                
                if (curr + nums[left] + nums[right] < target) {
                    left ++;
                } else {
                    right --;
                }
            }
        }
        
        return res;
    }
}